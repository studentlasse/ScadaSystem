using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Configuration;
using Opc.UaFx.Client;
using NationalInstruments.DAQmx;
using Simulation.Models;

namespace Simulation
{
    public partial class Form1 : Form
    {
        double processValue = 0;
        double controlValue;
        double Ts = 0.1;
        double Kp = 0.8;
        double Ti = 20;
        double r = 25;

        string opcUrl = ConfigurationManager.AppSettings["opcUrl"];
        string tagRealProcessValue = ConfigurationManager.AppSettings["tagRealProcessValue"];
        string tagSimProcessValue = ConfigurationManager.AppSettings["tagSimProcessValue"];
        string tagControlValue = ConfigurationManager.AppSettings["tagControlValue"];

        bool useDaq = false;
        Task analogInTask = new Task();
        AIChannel myAiChannel;


        OpcClient client;

        PidController pidController;

        AirHeater airHeater;


        // TODO:
        // Add daq in a class
        // Add scaling class? With scaling functions. 


        public Form1()
        {
            InitializeComponent();

            pidController = new PidController(Ts, Kp, Ti, r);

            airHeater = new AirHeater(Ts);

            processValue = airHeater.Tenv;

            client = new OpcClient(opcUrl);
            client.Connect();

            txtKp.Text = Kp.ToString();
            txtTi.Text = Ti.ToString();
            txtR.Text = r.ToString();

            initializeChart();

            timer1.Interval = Convert.ToInt32(Ts * 1000);
            timer1.Start();


        }

        private void initializeChart()
        {
            chartMeasurementData.Series.Clear();
            chartMeasurementData.Series.Add("ProcessValue");
            chartMeasurementData.Series["ProcessValue"].ChartType = SeriesChartType.Line;
            ChartArea area1 = chartMeasurementData.ChartAreas[0];
            area1.AxisY.Minimum = 0;
            area1.AxisY.Maximum = 50;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            controlValue = pidController.PiController(processValue);
            processValue = airHeater.AirHeaterModel(processValue, controlValue);

            txtOutput.Text = processValue.ToString("0.##");
            txtControlValue.Text = controlValue.ToString("0.##");

            chartMeasurementData.Series["ProcessValue"].Points.AddY(processValue);

            if (useDaq)
            {
                myAiChannel = analogInTask.AIChannels.CreateVoltageChannel(
                    "dev1/ai0",
                    "myAIChannel",
                    AITerminalConfiguration.Differential,
                    0,
                    10,
                    AIVoltageUnits.Volts
                    );

                AnalogSingleChannelReader reader = new AnalogSingleChannelReader(analogInTask.Stream);

                double analogDataIn = reader.ReadSingleSample();
            }

            client.WriteNode(tagSimProcessValue, Convert.ToDouble(processValue));
            client.WriteNode(tagControlValue, Convert.ToDouble(controlValue));

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
        private void txtR_TextChanged(object sender, EventArgs e)
        {
            r = Convert.ToDouble(txtR.Text);
            pidController.r = r;
        }

        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {
            client.Disconnect();
        }

    }
}
