using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        // Store historic data
        private List<Tag> history = new List<Tag>();

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
            chartMeasurements.Titles.Add("Temperature development");
            ClearChart();

            // Server endpoing URL
            txtServerEndpoint.Text = opcClient.OpcUrl;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (chkRunSimulator.Checked)
            {
                Simulator();
                
            }
            else
            {
                OPC();
            }

            this.time += timer1.Interval / 1000.0f;
        }

        private void Simulator()
        {
            // Only simulates the process variable and setpoint (static)
            float newProcessValue = simulator.SimulateData();
            float simValue = (float)numSimulatedPV.Value;
            float setpoint = (float) numSimSetpoint.Value;
            float controlValue = (float) numSimControlSignal.Value;
            float ioError = (float) numSimIoError.Value;
            float randomNumber = (float)numSimRandomNumber.Value;

            string newProcessValueStatus = txtPVStatus.Text;
            string simValueStatus = txtSimPVStatus.Text;
            string setpointStatus = txtSetpointStatus.Text;
            string controlValueStatus = txtControlSignalStatus.Text;
            string ioErrorStatus = txtIOStatus.Text;
            string randomNumberStatus = txtRandomNumberStatus.Text;

            // Update history
            Tag tag = new Tag(time, newProcessValue, simValue, setpoint, controlValue, ioError, randomNumber);
            history.Add(tag);

            // Update chart
            chartMeasurements.Series["Temperature [°C]"].Points.AddXY(this.time, newProcessValue);
            chartMeasurements.Series["Setpoint [°C]"].Points.AddXY(this.time, setpoint);

            // Update textbox
            txtCurrent.Text = newProcessValue.ToString("#.##");
            txtCurrentSetpoint.Text = setpoint.ToString("#.##");

            // Store data in database
            sqlManager.StoreSensorData(newProcessValue, "tagRealProcessValue", newProcessValueStatus);
            sqlManager.StoreSensorData(simValue, "tagSimProcessValue", simValueStatus);
            sqlManager.StoreSensorData(setpoint, "tagSetpoint", setpointStatus);
            sqlManager.StoreSensorData(controlValue, "tagControlValue", controlValueStatus);
            sqlManager.StoreSensorData(ioError, "tagIOError", ioErrorStatus);
            sqlManager.StoreSensorData(randomNumber, "tagConnectedRandomNumbers", randomNumberStatus);

            // Update statisticsdata
            stat.Update(newProcessValue);
            txtAvg.Text = stat.Average.ToString("#.##");
            txtMinMeasurement.Text = stat.Min.ToString("#.##");
            txtMaxMeasurement.Text = stat.Max.ToString("#.##");

            // Insert data into datagrid
            int index = dataGridView.Rows.Add();
            dataGridView.Rows[index].Cells["Column1"].Value = this.time;
            dataGridView.Rows[index].Cells["Column2"].Value = newProcessValue.ToString("#.##");
            dataGridView.Rows[index].Cells["Column3"].Value = newProcessValueStatus;
            dataGridView.Rows[index].Cells["Column4"].Value = setpoint.ToString("#.##");
            dataGridView.Rows[index].Cells["Column5"].Value = setpointStatus;
            dataGridView.Rows[index].Cells["Column6"].Value = controlValue.ToString("#.##");
            dataGridView.Rows[index].Cells["Column7"].Value = controlValueStatus;
        }

        private void OPC()
        {
            opcClient.GetData();

            // Process value
            float processValue = opcClient.ProcessValue;
            string processValueStatus = opcClient.ProcessValueStatus;
            sqlManager.StoreSensorData(processValue, "tagRealProcessValue", processValueStatus);

            // Simulation process value
            float simProcessValue = opcClient.SimProcessValue;
            string simulationProcessStatus = opcClient.SimProcessValueStatus;
            sqlManager.StoreSensorData(simProcessValue, "tagRealProcessValue", simulationProcessStatus);

            // Setpoint
            float setpoint = opcClient.Setpoint;
            string setpointStatus = opcClient.SetpointStatus;
            sqlManager.StoreSensorData(setpoint, "tagSetpoint", setpointStatus);

            // Control value
            float controlValue = opcClient.ControlValue;
            string controlValueStatus = opcClient.ControlValueStatus;
            sqlManager.StoreSensorData(controlValue, "tagControlValue", controlValueStatus);

            // I/O error
            float ioError = opcClient.IoError;
            string ioErrorStatus = opcClient.IoErrorStatus;
            sqlManager.StoreSensorData(ioError, "tagIOError", ioErrorStatus);

            // Connected random numbers
            float randomNumber = opcClient.ConnectedRandomNumber;
            string randomNumberStatus = opcClient.ConnectedRandomNumberStatus;
            sqlManager.StoreSensorData(randomNumber, "tagConnectedRandomNumbers", randomNumberStatus);

            // Update history
            Tag tag = new Tag(time, processValue, simProcessValue, setpoint, controlValue, ioError, randomNumber);
            history.Add(tag);

            // Update chart
            chartMeasurements.Series["Temperature [°C]"].Points.AddXY(this.time, processValue);
            chartMeasurements.Series["Setpoint [°C]"].Points.AddXY(this.time, setpoint);
            //chartMeasurements.Series["Control signal [V]"].Points.AddXY(this.time, controlValue);

            // Update textbox
            txtCurrent.Text = processValue.ToString("#.##");
            txtCurrentSetpoint.Text = setpoint.ToString("#.##");

            // Update statisticsdata
            stat.Update(processValue);
            txtAvg.Text = stat.Average.ToString("#.##");
            txtMinMeasurement.Text = stat.Min.ToString("#.##");
            txtMaxMeasurement.Text = stat.Max.ToString("#.##");

            // Insert data into datagrid
            int index = dataGridView.Rows.Add();
            dataGridView.Rows[index].Cells["Column1"].Value = this.time;
            dataGridView.Rows[index].Cells["Column2"].Value = processValue.ToString("#.##");
            dataGridView.Rows[index].Cells["Column3"].Value = processValueStatus;
            dataGridView.Rows[index].Cells["Column4"].Value = setpoint;
            dataGridView.Rows[index].Cells["Column5"].Value = setpointStatus;
            dataGridView.Rows[index].Cells["Column6"].Value = controlValue;
            dataGridView.Rows[index].Cells["Column7"].Value = controlValueStatus;
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

            // Reset history
            history.Clear();
        }

        private void ClearChart()
        {
            chartMeasurements.Series.Clear();
            
            chartMeasurements.Series.Add("Temperature [°C]");
            chartMeasurements.Series["Temperature [°C]"].ChartType = SeriesChartType.Line;

            chartMeasurements.Series.Add("Setpoint [°C]");
            chartMeasurements.Series["Setpoint [°C]"].ChartType = SeriesChartType.Line;

            /*
            chartMeasurements.Series.Add("Control signal [V]");
            chartMeasurements.Series["Control signal [V]"].ChartType = SeriesChartType.Line;
            */

            chartMeasurements.Legends[0].Docking = Docking.Bottom;
            ChartArea area = chartMeasurements.ChartAreas[0];
            area.AxisY.Title = "Temperature  [°C]";
            area.AxisX.Title = "Time [s]";
        }

        private void SetupSimulator()
        {
            float lowerLimit = 10.0f;
            float upperLimit = 30.0f;
            float alpha = 0.2f;
            bool filtering = true;

            this.simulator = new Simulator(lowerLimit, upperLimit, filtering, alpha);

            this.numUpperLimit.Value = upperLimit;
            this.numLowerLimit.Value = lowerLimit;
            this.numAlpha.Value = alpha;
            this.chkRunFilter.Checked = true;

            // System starts in OPC mode
            this.chkRunSimulator.Checked = false;
            this.txtMode.Text = "OPC";

            // Initial values
            numSimulatedPV.Value = 10.0;
            numSimSetpoint.Value = (simulator.UpperLimit - simulator.LowerLimit) / 2.0f + simulator.LowerLimit;
            numSimControlSignal.Value = 30.0f;
            numSimRandomNumber.Value = 42;
            numSimIoError.Value = 0;

            txtPVStatus.Text = "Good";
            txtSimPVStatus.Text = "Good";
            txtSetpointStatus.Text = "Good";
            txtControlSignalStatus.Text = "Good";
            txtIOStatus.Text = "Good";
            txtRandomNumberStatus.Text = "Good";
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

        private void btnSaveHistory_Click(object sender, EventArgs e)
        {
            using (StreamWriter writetext = new StreamWriter("log.txt"))
            {
                writetext.WriteLine(
                    string.Format("{0,-15}", "Time") +
                    string.Format("{0,-15}", "PV") +
                    string.Format("{0,-15}", "Sim PV") +
                    string.Format("{0,-15}", "Setpoint") +
                    string.Format("{0,-15}", "Control Signal") +
                    string.Format("{0,-15}", "IO Error") +
                    string.Format("{0,-15}", "Random Number")
                    );

                foreach (Tag tag in history)
                {
                    writetext.WriteLine(
                        string.Format("{0,-15}", tag.time) +
                        string.Format("{0,-15}", tag.processValue) +
                        string.Format("{0,-15}", tag.simValue) +
                        string.Format("{0,-15}", tag.setpoint) +
                        string.Format("{0,-15}", tag.controlValue) +
                        string.Format("{0,-15}", tag.ioError) +
                        string.Format("{0,-15}", tag.randomNumber)
                        );
                }
            }
        }
    }
}
