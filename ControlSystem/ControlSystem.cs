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
        double setpoint = 25;

        string opcUrl = ConfigurationManager.AppSettings["opcUrl"];
        string tagRealProcessValue = ConfigurationManager.AppSettings["tagRealProcessValue"];
        string tagSimProcessValue = ConfigurationManager.AppSettings["tagSimProcessValue"];
        string tagSetpoint = ConfigurationManager.AppSettings["tagSetpoint"];
        string tagControlValue = ConfigurationManager.AppSettings["tagControlValue"];
        string tagConnectedRandomNumbers = ConfigurationManager.AppSettings["tagConnectedRandomNumbers"];

        bool useDaq = false;
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

            simulatedProcessValue = airHeater.Tenv;

            filter = new Filter();

            InitializeDaq();

            InitializeClient();

            txtKp.Text = Kp.ToString();
            txtTi.Text = Ti.ToString();
            txtR.Text = setpoint.ToString();
            txtOPCServer.Text = opcUrl;

            initializeChart();

            timer1.Interval = Convert.ToInt32(Ts * 1000);
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
            }
            else
            {
                txtRealProcessValue.Text = "No data";
            }
        }

        private void initializeChart()
        {
            chartMeasurementData.Series.Clear();
            chartMeasurementData.Series.Add("Simulated Process Value [℃]");
            chartMeasurementData.Series["Simulated Process Value [℃]"].ChartType = SeriesChartType.Line;
            chartMeasurementData.Series.Add("Setpoint [℃]");
            chartMeasurementData.Series["Setpoint [℃]"].ChartType = SeriesChartType.Line;
            if (useDaq)
            {
                chartMeasurementData.Series.Add("Real Process Value [℃]");
                chartMeasurementData.Series["Real Process Value [℃]"].ChartType = SeriesChartType.Line;
            }
            ChartArea area1 = chartMeasurementData.ChartAreas[0];
            area1.AxisY.Minimum = 20;
            area1.AxisY.Maximum = 50;
            area1.AxisY.Title = "Temperature [℃]";
            area1.AxisX.Title = "Time [s]";

            chartMeasurementData.Legends[0].Docking = Docking.Bottom;
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
            txtR.Text = setpoint.ToString("0.##");
            txtControlValue.Text = controlValue.ToString("0.##");
            if (useDaq) txtRealProcessValue.Text = realProcessValue.ToString("0.##");
            txtOpcStatus.Text = client.State.ToString();
        }

        private void WriteToDac()
        {
            if (useDaq)
            {
                daq.WriteData(controlValue);
            }
        }

        private void PlotData()
        {
            chartMeasurementData.Series["Simulated Process Value [℃]"].Points.AddY(simulatedProcessValue);
            chartMeasurementData.Series["Setpoint [℃]"].Points.AddY(setpoint);
            if (useDaq) chartMeasurementData.Series["Real Process Value [℃]"].Points.AddY(realProcessValue);
        }

        private void WriteToOPC()
        {
            try
            {
                client.WriteNode(tagRealProcessValue, Convert.ToDouble(realProcessValue));
                client.WriteNode(tagSimProcessValue, Convert.ToDouble(simulatedProcessValue));
                client.WriteNode(tagSetpoint, Convert.ToDouble(setpoint));
                client.WriteNode(tagControlValue, Convert.ToDouble(controlValue));

                // client.WriteNode(tagConnectedRandomNumbers, RandomString(10));
 
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
            setpoint = Convert.ToDouble(txtR.Text);
            pidController.r = setpoint;
        }

        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {
            client.Disconnect();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
