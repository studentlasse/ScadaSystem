using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Configuration;
using Opc.UaFx.Client;
using Simulation.Models;

namespace Simulation
{
    public partial class Form1 : Form
    {
        double simulatedProcessValue = 0;
        double realProcessValue;
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
        Daq daq;

        Filter filter;

        OpcClient client;

        PidController pidController;

        AirHeater airHeater;


        // TODO:
        // Add scaling class? With scaling functions. 


        public Form1()
        {
            InitializeComponent();

            pidController = new PidController(Ts, Kp, Ti, r);

            airHeater = new AirHeater(Ts);

            simulatedProcessValue = airHeater.Tenv;
            if (useDaq)
            {
                daq = new Daq();
                realProcessValue = daq.ReadData(); // TODO: Scaling!!!
                realProcessValue = filter.LowPassFilter(realProcessValue);
            }
            else
            {
                txtRealProcessValue.Text = "No data";
            }

            filter = new Filter();
     
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
            chartMeasurementData.Series.Add("SimulatedProcessValue");
            chartMeasurementData.Series["SimulatedProcessValue"].ChartType = SeriesChartType.Line;
            if (useDaq)
            {
                chartMeasurementData.Series.Add("RealProcessValue");
                chartMeasurementData.Series["RealProcessValue"].ChartType = SeriesChartType.Line;
            }
            ChartArea area1 = chartMeasurementData.ChartAreas[0];
            area1.AxisY.Minimum = 0;
            area1.AxisY.Maximum = 50;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (useDaq)
            {
                realProcessValue = daq.ReadData();
                realProcessValue = filter.LowPassFilter(realProcessValue);
                controlValue = pidController.PiController(realProcessValue);
                daq.WriteData(controlValue); // TODO: Scaling!!!!!
            } 
            else
            {
                controlValue = pidController.PiController(simulatedProcessValue);
            }
            simulatedProcessValue = airHeater.AirHeaterModel(simulatedProcessValue, controlValue);

            txtSimProcessValue.Text = simulatedProcessValue.ToString("0.##");
            txtControlValue.Text = controlValue.ToString("0.##");

            chartMeasurementData.Series["SimulatedProcessValue"].Points.AddY(simulatedProcessValue);

            if (useDaq)
            {
                txtRealProcessValue.Text = realProcessValue.ToString("0.##");
                chartMeasurementData.Series["RealProcessValue"].Points.AddY(realProcessValue);
                client.WriteNode(tagRealProcessValue, Convert.ToDouble(realProcessValue));
            }
            client.WriteNode(tagSimProcessValue, Convert.ToDouble(simulatedProcessValue));
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
