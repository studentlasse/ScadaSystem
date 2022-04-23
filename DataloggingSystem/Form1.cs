using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using DataloggingSystem.Classes;

namespace DataloggingSystem
{
    public partial class Form1 : Form
    {

        private Simulator simulator;
        private Sensor sensor;
        private Statistics stat;

        private float time;

        public Form1()
        {
            InitializeComponent();

            SetupSimulator();
            SetupSensor();
            SetupStat();

            ClearChart();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Update chart
            float newValue = simulator.SimulateData();
            chartMeasurements.Series["MeasurementData"].Points.AddXY(this.time, newValue);

            // Update textbox
            txtCurrent.Text = newValue.ToString("#.##");

            // Store data in database
            sensor.StoreSensorData(newValue);

            // Retrieve statistics data
            StatisticsData stat_data = stat.GetStatisticsData();
            txtAvg.Text = stat_data.AverageValue.ToString("#.##");
            txtMinMeasurement.Text = stat_data.MinValue.ToString("#.##");
            txtMaxMeasurement.Text = stat_data.MaxValue.ToString("#.##");

            this.time += timer1.Interval / 1000.0f;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();

            ClearChart();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();

            time = 0.0f;
        }

        private void ClearChart()
        {
            chartMeasurements.Series.Clear();
            chartMeasurements.Series.Add("MeasurementData");
            chartMeasurements.Series["MeasurementData"].ChartType = SeriesChartType.Line;
        }

        private void SetupSimulator()
        {
            float lowerLimit = 10.0f;
            float upperLimit = 30.0f;
            float alpha = 0.2f;
            bool filtering = true;

            simulator = new Simulator(lowerLimit, upperLimit, filtering, alpha);

            this.txtLowerLimit.Text = lowerLimit.ToString("#.##");
            this.txtUpperLimit.Text = upperLimit.ToString("#.##");
            this.txtAlpha.Text = alpha.ToString("#.##");
            this.chkRunFilter.Checked = true;
        }

        private void SetupSensor()
        {
            sensor = new Sensor();
        }

        private void SetupStat()
        {
            stat = new Statistics();
        }

        private void txtUpperLimit_TextChanged(object sender, EventArgs e)
        {
            float upperLimit = float.Parse(txtUpperLimit.Text);
            simulator.UpperLimit = upperLimit;
            txtUpperLimit.Text = upperLimit.ToString("#.##");
        }

        private void txtLowerLimit_TextChanged(object sender, EventArgs e)
        {
            float lowerLimit = float.Parse(txtLowerLimit.Text);
            simulator.LowerLimit = lowerLimit;
            txtLowerLimit.Text = lowerLimit.ToString("#.##");
        }

        private void txtAlpha_TextChanged(object sender, EventArgs e)
        {
            float alpha = float.Parse(txtAlpha.Text);
            simulator.Alpha = alpha;
            txtAlpha.Text = alpha.ToString("#.##");
        }

        private void chkRunFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRunFilter.Checked)
                simulator.Filtering = true;
            else
                simulator.Filtering = false;
        }
    }
}

/*
private void FillChart()
{


    ChartArea area = chartMeasurements.ChartAreas[0];
    // area.AxisY.Minimum = 10;
    // area.AxisY.Maximum = 40;
    area.AxisX.Title = "MeasurementId";

    switch (comboBoxUnit.Text)
    {
        case "Celsius":
            area.AxisY.Title = "Temperature [°C]";
            foreach (Measurement meas in measurementList)
                chartMeasurements.Series["MeasurementData"].Points.AddXY(meas.MeasurementId, meas.MeasurementValue);
            break;

        case "Fahrenheit":
            area.AxisY.Title = "Temperature [°F]";
            foreach (Measurement meas in measurementList)
                chartMeasurements.Series["MeasurementData"].Points.AddXY(meas.MeasurementId, meas.FahrenheitValue);
            break;

        default:
            throw new Exception("Temperature unit incorrect");
    }
}
*/
