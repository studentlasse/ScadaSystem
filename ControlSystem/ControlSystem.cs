﻿using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Configuration;
using Opc.UaFx.Client;
using Opc.UaFx;
using Simulation.Models;
using System.Linq;

namespace Simulation
{
    public partial class ControlSystem : Form
    {
        double simulatedProcessValue = 0;
        double realProcessValue = 0;
        double controlValue;
        double Ts = 0.1;
        double Kp = 0.8;
        double Ti = 20;
        double setpoint = 20;

        string opcUrl = ConfigurationManager.AppSettings["opcUrl"];
        string tagRealProcessValue = ConfigurationManager.AppSettings["tagRealProcessValue"];
        string tagSimProcessValue = ConfigurationManager.AppSettings["tagSimProcessValue"];
        string tagSetpoint = ConfigurationManager.AppSettings["tagSetpoint"];
        string tagControlValue = ConfigurationManager.AppSettings["tagControlValue"];
        string tagControlSystemOnlineVerification = ConfigurationManager.AppSettings["tagControlSystemOnlineVerification"];
        string tagAutomatic = ConfigurationManager.AppSettings["tagAutomatic"];

        Daq daq;

        Filter filter;

        OpcClient client;

        PidController pidController;

        AirHeater airHeater;

        Scaling scaling;

        public ControlSystem()
        {
            InitializeComponent();

            pidController = new PidController(Ts, Kp, Ti, setpoint);

            airHeater = new AirHeater(Ts);

            scaling = new Scaling(1, 5, 20, 50);

            simulatedProcessValue = airHeater.Tenv;

            filter = new Filter();

            InitializeClient();

            txtKp.Text = Kp.ToString();
            txtTi.Text = Ti.ToString();
            txtOPCServer.Text = opcUrl;
            numR.Value = (decimal)setpoint;

            initializeChart();

            timer1.Interval = Convert.ToInt32(Ts * 1000);
            timer2.Interval = timer1.Interval / 2;
        }

        private void InitializeClient()
        {
            client = new OpcClient(opcUrl);
            client.Connect();
        }

        

        private void initializeChart()
        {
            chartMeasurementData.Series.Clear();
            chartMeasurementData.Series.Add("Simulated Process Value [℃]");
            chartMeasurementData.Series["Simulated Process Value [℃]"].ChartType = SeriesChartType.Line;
            chartMeasurementData.Series.Add("Setpoint [℃]");
            chartMeasurementData.Series["Setpoint [℃]"].ChartType = SeriesChartType.Line;
            chartMeasurementData.Series.Add("Real Process Value [℃]");
            chartMeasurementData.Series["Real Process Value [℃]"].ChartType = SeriesChartType.Line;
            ChartArea area1 = chartMeasurementData.ChartAreas[0];
            area1.AxisY.Minimum = 20;
            area1.AxisY.Maximum = 50;
            area1.AxisY.Title = "Temperature [℃]";
            area1.AxisX.Title = "Time [s]";

            chartMeasurementData.Legends[0].Docking = Docking.Bottom;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            ControlAuto();

            ReadFromDac();

            ScaleValue();

            UpdateControl();

            simulatedProcessValue = airHeater.AirHeaterModel(simulatedProcessValue, controlValue);
            WriteToDac();

            UpdateUI();
            PlotData();
            WriteToOPC();
        }

        private void ControlAuto()
        {
            if(cbAuto.Checked)
            {
                numControlValue.Enabled = false;
            }
            else
            {
                numControlValue.Enabled = true;
            }
        }

        private void ReadFromDac()
        {
            if (cbUseDaq.Checked)
            {
                realProcessValue = daq.ReadData();
                realProcessValue = filter.LowPassFilter(realProcessValue);
            }
        }

        private void ScaleValue()
        {
            if (realProcessValue > 0)
            {
                realProcessValue = scaling.LinearScaling(realProcessValue);
            }
        }

        private void UpdateControl()
        {
            if (cbAuto.Checked)
            {
                if (!cbUseDaq.Checked)
                {
                    controlValue = pidController.PiController(simulatedProcessValue);
                }
                else if (cbUseDaq.Checked && realProcessValue < 0)
                {
                    controlValue = pidController.PiController(simulatedProcessValue);
                }
                else
                {
                    controlValue = pidController.PiController(realProcessValue);
                }
            }
            else
            {
                controlValue = (double) numControlValue.Value;
            }
            
        }

        private void UpdateUI()
        {
            txtOpcStatus.Text = client.State.ToString();
            txtSimProcessValue.Text = simulatedProcessValue.ToString("0.##");
            numR.Value = (decimal) setpoint;
            numControlValue.Value = (decimal)controlValue;
            if (cbUseDaq.Checked) txtRealProcessValue.Text = realProcessValue.ToString("0.##");
            txtOpcStatus.Text = client.State.ToString();

            if (!cbUseDaq.Checked) txtIoStatus.Text = "IO OFF";
            if (cbUseDaq.Checked && realProcessValue < 0) txtIoStatus.Text = "IO Error";
            if (cbUseDaq.Checked && realProcessValue > 0) txtIoStatus.Text = "IO OK";
        }

        private void WriteToDac()
        {
            if (cbUseDaq.Checked)
            {
                daq.WriteData(controlValue);
            }
        }

        private void PlotData()
        {
            chartMeasurementData.Series["Simulated Process Value [℃]"].Points.AddY(simulatedProcessValue);
            chartMeasurementData.Series["Setpoint [℃]"].Points.AddY(setpoint);
            if (cbUseDaq.Checked) chartMeasurementData.Series["Real Process Value [℃]"].Points.AddY(realProcessValue);
        }

        private void WriteToOPC()
        {
            try
            {
                OpcWriteNode[] commands = new OpcWriteNode[] {
                new OpcWriteNode(tagRealProcessValue, realProcessValue),
                new OpcWriteNode(tagSimProcessValue, simulatedProcessValue),
                new OpcWriteNode(tagSetpoint, setpoint),
                new OpcWriteNode(tagControlValue, controlValue)
                };

                OpcStatusCollection results = client.WriteNodes(commands);

                if (cbAuto.Checked)
                {
                    client.WriteNode(tagAutomatic, 1);
                }
                else
                {
                    client.WriteNode(tagAutomatic, -1);
                }
 
            }
            catch
            {

            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            client.WriteNode(tagControlSystemOnlineVerification, GenerateVerificationString(10));
        }

            private string GenerateVerificationString(int length)
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void txtKp_TextChanged(object sender, EventArgs e)
        {
            Kp = Convert.ToDouble(txtKp.Text);
            pidController.Kp = Kp;
    }
        private void txtTi_TextChanged(object sender, EventArgs e)
        {
            Ti = Convert.ToDouble(txtTi.Text);
            pidController.Ti = Ti;
        }


        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {
            client.Disconnect();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
            InitializeDaq();
            cbUseDaq.Enabled = false;
        }

        private void InitializeDaq()
        {
            if (cbUseDaq.Checked)
            {
                scaling = new Scaling(0, 5, 20, 50);
                daq = new Daq();
            }
            else
            {
                txtRealProcessValue.Text = "No data";
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            cbUseDaq.Enabled = true;
        }

        private void numR_ValueChanged(object sender, EventArgs e)
        {
            if (numR.Value > 50) numR.Value = 50;
            if (numR.Value < 20) numR.Value = 20;
            setpoint = (double)numR.Value;
            pidController.r = setpoint;
        }

        private void numControlValue_ValueChanged(object sender, EventArgs e)
        {
            if (numControlValue.Value > 5) numControlValue.Value = 5;
            if (numControlValue.Value < 0) numControlValue.Value = 0;
            controlValue = (double) numControlValue.Value;
        }
    }
}
