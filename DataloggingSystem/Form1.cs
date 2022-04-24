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
        private OpcManager opcClient;
        private SqlManager sqlManager;
        private Statistics stat;

        private float time;

        public Form1()
        {
            InitializeComponent();

            // Set up different modules
            SetupSimulator();
            SetupOPC();
            SetupSensor();
            SetupStat();

            // Initialize chart
            ClearChart();

            // Server endpoing URL
            txtServerEndpoint.Text = opcClient.OpcUrl;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            float newValue;
            string tagStatus;
            string tagQuality;
            if (chkRunSimulator.Checked)
            {
                newValue = simulator.SimulateData();
                tagStatus = "OK";
                tagQuality = "High";
            }
            else
            {
                opcClient.GetData();
                newValue = opcClient.ProcessValue;
                tagStatus = opcClient.IoError;

                if (opcClient.NewData)
                    tagQuality = "High";
                else
                    tagQuality = "Low";
            }

            // Update chart
            chartMeasurements.Series["MeasurementData"].Points.AddXY(this.time, newValue);

            // Update textbox
            txtCurrent.Text = newValue.ToString("#.##");

            // Store data in database
            sqlManager.StoreSensorData(newValue, tagStatus, tagQuality);

            // Update statisticsdata
            stat.Update(newValue);
            txtAvg.Text = stat.Average.ToString("#.##");
            txtMinMeasurement.Text = stat.Min.ToString("#.##");
            txtMaxMeasurement.Text = stat.Max.ToString("#.##");

            // Update textboxes
            txtTagStatus.Text = tagStatus;
            txtTagQuality.Text = tagQuality;

            // Insert data into datagrid
            int index = dataGridView.Rows.Add();
            dataGridView.Rows[index].Cells["Column1"].Value = this.time;
            dataGridView.Rows[index].Cells["Column2"].Value = newValue.ToString("#.##");
            dataGridView.Rows[index].Cells["Column3"].Value = tagStatus;
            dataGridView.Rows[index].Cells["Column4"].Value = tagQuality;

            this.time += timer1.Interval / 1000.0f;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            numInterval.Value = 1000;
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

            // Reset statistics class
            stat.Reset();

            // Clear datagrid
            dataGridView.Rows.Clear();
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

            // System starts in OPC mode
            this.chkRunSimulator.Checked = false;
            this.txtMode.Text = "OPC";
        }

        private void SetupOPC()
        {
            this.opcClient = new OpcManager();
            this.opcClient.Start();
        }

        private void SetupSensor()
        {
            sqlManager = new SqlManager();
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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            opcClient.Close();
        }

        private void numInterval_ValueChanged(object sender, EventArgs e)
        {
            timer1.Interval = (int) numInterval.Value;
        }

        private void chkRunSimulator_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRunSimulator.Checked)
                this.txtMode.Text = "Simulator";
            else
                this.txtMode.Text = "OPC";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to delete the logged data in the SCADA database?", "Warning!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                sqlManager.ClearDataDatabase();
            }
        }
    }
}
