using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Configuration;
using Opc.UaFx.Client;
using Simulation.Models;
using System.Linq;

namespace Simulation
{
    public partial class ControlSystem : Form
    {
        double simulatedProcessValue = 0;
        double realProcessValue = -1;
        double controlValue;
        double Ts = 0.1;
        double Kp = 0.8;
        double Ti = 20;
        double r = 25;

        string opcUrl = ConfigurationManager.AppSettings["opcUrl"];
        string tagRealProcessValue = ConfigurationManager.AppSettings["tagRealProcessValue"];
        string tagSimProcessValue = ConfigurationManager.AppSettings["tagSimProcessValue"];
        string tagControlValue = ConfigurationManager.AppSettings["tagControlValue"];
        string tagConnectedRandomNumbers = ConfigurationManager.AppSettings["tagConnectedRandomNumbers"];
        string tagIOError = ConfigurationManager.AppSettings["tagIOError"];

        bool useDaq = false;
        string IOStatus = "Ok";
        Daq daq;

        Filter filter;

        OpcClient client;

        PidController pidController;

        AirHeater airHeater;

        Scaling scaling;

        public ControlSystem()
        {
            InitializeComponent();

            pidController = new PidController(Ts, Kp, Ti, r);

            airHeater = new AirHeater(Ts);

            simulatedProcessValue = airHeater.Tenv;

            filter = new Filter();

            InitializeDaq();

            InitializeClient();

            txtKp.Text = Kp.ToString();
            txtTi.Text = Ti.ToString();
            txtR.Text = r.ToString();

            initializeChart();

            timer1.Interval = Convert.ToInt32(Ts * 1000);
            timer1.Start();


        }

        private void InitializeClient()
        {
            client = new OpcClient(opcUrl);

            try
            {
                client.Connect();
            }
            catch
            {
                Console.WriteLine("Error connecting to OPC Server");
            }
        }

        private void InitializeDaq()
        {
            if (useDaq)
            {
                scaling = new Scaling(0, 5, 20, 50);
                daq = new Daq();
                if (!daq.IoDeviceOk) IOStatus = "DeviceError";
            }
            else
            {
                txtRealProcessValue.Text = "No data";
                IOStatus = "IO-OFF";
            }
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
            ReadFromDac();

            ScaleValue();

            UpdateControl();

            simulatedProcessValue = airHeater.AirHeaterModel(simulatedProcessValue, controlValue);
            WriteToDac();

            UpdateUI();
            PlotData();
            WriteToOPC();
        }

        private void ReadFromDac()
        {
            if (useDaq)
            {
                realProcessValue = daq.ReadData();
                if (realProcessValue == -1)
                {
                    IOStatus = "ReadError";
                }
                realProcessValue = filter.LowPassFilter(realProcessValue);
            }
        }

        private void ScaleValue()
        {
            // TODO
        }

        private void UpdateControl()
        {
            if (!useDaq)
            {
                controlValue = pidController.PiController(simulatedProcessValue);
            }
            else if (useDaq && realProcessValue < 0)
            {
                controlValue = pidController.PiController(simulatedProcessValue);
            }
            else
            {
                controlValue = pidController.PiController(realProcessValue);
            }
        }

        private void UpdateUI()
        {
            txtOpcStatus.Text = client.State.ToString();
            txtSimProcessValue.Text = simulatedProcessValue.ToString("0.##");
            txtControlValue.Text = controlValue.ToString("0.##");
            if (useDaq) txtRealProcessValue.Text = realProcessValue.ToString("0.##");
            txtOpcStatus.Text = client.State.ToString();
        }

        private void WriteToDac()
        {
            if (useDaq)
            {
                bool writeOk = daq.WriteData(controlValue);
                if (!writeOk)
                {
                    IOStatus = "WriteError";
                }
            }
        }

        private void PlotData()
        {
            chartMeasurementData.Series["SimulatedProcessValue"].Points.AddY(simulatedProcessValue);
            if (useDaq) chartMeasurementData.Series["RealProcessValue"].Points.AddY(realProcessValue);
        }

        private void WriteToOPC()
        {
            try
            {
                if (useDaq) client.WriteNode(tagRealProcessValue, Convert.ToDouble(realProcessValue));
                client.WriteNode(tagSimProcessValue, Convert.ToDouble(simulatedProcessValue));
                client.WriteNode(tagControlValue, Convert.ToDouble(controlValue));

                client.WriteNode(tagConnectedRandomNumbers, RandomString(10));
                client.WriteNode(tagIOError, IOStatus);
 
            }
            catch
            {

            }
        }

        private string RandomString(int length)
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
