
namespace DataloggingSystem
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblConControl = new System.Windows.Forms.Label();
            this.txtControlSystemStatus = new System.Windows.Forms.TextBox();
            this.btnSaveHistory = new System.Windows.Forms.Button();
            this.lblCurrSetpoint = new System.Windows.Forms.Label();
            this.txtCurrentSetpoint = new System.Windows.Forms.TextBox();
            this.lblMode = new System.Windows.Forms.Label();
            this.txtMode = new System.Windows.Forms.TextBox();
            this.lblCurrTemp = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartMeasurements = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCurrent = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAvg = new System.Windows.Forms.Label();
            this.txtAvg = new System.Windows.Forms.TextBox();
            this.lblMaxTemperature = new System.Windows.Forms.Label();
            this.txtMaxMeasurement = new System.Windows.Forms.TextBox();
            this.lblMinMeasurement = new System.Windows.Forms.Label();
            this.txtMinMeasurement = new System.Windows.Forms.TextBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtServerEndpoint = new System.Windows.Forms.TextBox();
            this.numInterval = new System.Windows.Forms.NumericUpDown();
            this.lblInterval = new System.Windows.Forms.Label();
            this.chkRunSimulator = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.grpOtherTags = new System.Windows.Forms.GroupBox();
            this.lblControlSystemOnlineStatus = new System.Windows.Forms.Label();
            this.lblAutomaticStatus = new System.Windows.Forms.Label();
            this.lblSimulatedProcessVariable = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numAutomatic = new System.Windows.Forms.NumericUpDown();
            this.lblAutomatic = new System.Windows.Forms.Label();
            this.numControlSystemOnline = new System.Windows.Forms.NumericUpDown();
            this.lblSetpointStatus = new System.Windows.Forms.Label();
            this.numSimulatedPV = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.numSimControlSignal = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.lblSimValue = new System.Windows.Forms.Label();
            this.lblControlSystemOnline = new System.Windows.Forms.Label();
            this.lblControlValue = new System.Windows.Forms.Label();
            this.numSimSetpoint = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.lblSetpoint = new System.Windows.Forms.Label();
            this.grpProcessVariable = new System.Windows.Forms.GroupBox();
            this.numAlpha = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.numLowerLimit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.numUpperLimit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.lblAlpha = new System.Windows.Forms.Label();
            this.lblPVStatus = new System.Windows.Forms.Label();
            this.lblUpperLimit = new System.Windows.Forms.Label();
            this.lblLowerLimit = new System.Windows.Forms.Label();
            this.chkRunFilter = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.grpStatus = new System.Windows.Forms.GroupBox();
            this.txtCurrentContolSignal = new System.Windows.Forms.TextBox();
            this.lblCurrCS = new System.Windows.Forms.Label();
            this.cbxSetPointStatus = new System.Windows.Forms.ComboBox();
            this.cbxControlSignalStatus = new System.Windows.Forms.ComboBox();
            this.cbxSimulatedPVStatus = new System.Windows.Forms.ComboBox();
            this.cbxControlSystemOnlineStatus = new System.Windows.Forms.ComboBox();
            this.cbxAutomaticStatus = new System.Windows.Forms.ComboBox();
            this.cbxPVStatus = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMeasurements)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numInterval)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.grpOtherTags.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAutomatic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numControlSystemOnline)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSimulatedPV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSimControlSignal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSimSetpoint)).BeginInit();
            this.grpProcessVariable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAlpha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLowerLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpperLimit)).BeginInit();
            this.grpStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1295, 716);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grpStatus);
            this.tabPage1.Controls.Add(this.btnSaveHistory);
            this.tabPage1.Controls.Add(this.lblCurrCS);
            this.tabPage1.Controls.Add(this.lblCurrSetpoint);
            this.tabPage1.Controls.Add(this.txtCurrentContolSignal);
            this.tabPage1.Controls.Add(this.txtCurrentSetpoint);
            this.tabPage1.Controls.Add(this.lblCurrTemp);
            this.tabPage1.Controls.Add(this.dataGridView);
            this.tabPage1.Controls.Add(this.chartMeasurements);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtCurrent);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btnStop);
            this.tabPage1.Controls.Add(this.btnStart);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1287, 687);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "Logging";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblConControl
            // 
            this.lblConControl.AutoSize = true;
            this.lblConControl.Location = new System.Drawing.Point(25, 88);
            this.lblConControl.Name = "lblConControl";
            this.lblConControl.Size = new System.Drawing.Size(147, 17);
            this.lblConControl.TabIndex = 16;
            this.lblConControl.Text = "Control System Status";
            // 
            // txtControlSystemStatus
            // 
            this.txtControlSystemStatus.Enabled = false;
            this.txtControlSystemStatus.Location = new System.Drawing.Point(29, 106);
            this.txtControlSystemStatus.Margin = new System.Windows.Forms.Padding(4);
            this.txtControlSystemStatus.Name = "txtControlSystemStatus";
            this.txtControlSystemStatus.Size = new System.Drawing.Size(132, 22);
            this.txtControlSystemStatus.TabIndex = 15;
            // 
            // btnSaveHistory
            // 
            this.btnSaveHistory.Location = new System.Drawing.Point(1088, 488);
            this.btnSaveHistory.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveHistory.Name = "btnSaveHistory";
            this.btnSaveHistory.Size = new System.Drawing.Size(133, 46);
            this.btnSaveHistory.TabIndex = 14;
            this.btnSaveHistory.Text = "Save history to file";
            this.btnSaveHistory.UseVisualStyleBackColor = true;
            this.btnSaveHistory.Click += new System.EventHandler(this.btnSaveHistory_Click);
            // 
            // lblCurrSetpoint
            // 
            this.lblCurrSetpoint.AutoSize = true;
            this.lblCurrSetpoint.Location = new System.Drawing.Point(386, 23);
            this.lblCurrSetpoint.Name = "lblCurrSetpoint";
            this.lblCurrSetpoint.Size = new System.Drawing.Size(91, 17);
            this.lblCurrSetpoint.TabIndex = 13;
            this.lblCurrSetpoint.Text = "Setpoint [°C]:";
            // 
            // txtCurrentSetpoint
            // 
            this.txtCurrentSetpoint.Enabled = false;
            this.txtCurrentSetpoint.Location = new System.Drawing.Point(483, 20);
            this.txtCurrentSetpoint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCurrentSetpoint.Name = "txtCurrentSetpoint";
            this.txtCurrentSetpoint.Size = new System.Drawing.Size(173, 22);
            this.txtCurrentSetpoint.TabIndex = 12;
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Location = new System.Drawing.Point(25, 27);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(43, 17);
            this.lblMode.TabIndex = 11;
            this.lblMode.Text = "Mode";
            // 
            // txtMode
            // 
            this.txtMode.Enabled = false;
            this.txtMode.Location = new System.Drawing.Point(30, 48);
            this.txtMode.Margin = new System.Windows.Forms.Padding(4);
            this.txtMode.Name = "txtMode";
            this.txtMode.Size = new System.Drawing.Size(132, 22);
            this.txtMode.TabIndex = 10;
            // 
            // lblCurrTemp
            // 
            this.lblCurrTemp.AutoSize = true;
            this.lblCurrTemp.Location = new System.Drawing.Point(65, 23);
            this.lblCurrTemp.Name = "lblCurrTemp";
            this.lblCurrTemp.Size = new System.Drawing.Size(121, 17);
            this.lblCurrTemp.TabIndex = 6;
            this.lblCurrTemp.Text = "Temperature [°C]:";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView.Location = new System.Drawing.Point(37, 400);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView.Size = new System.Drawing.Size(975, 254);
            this.dataGridView.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Time [s]";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "PV Temp [°C]";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "PV status";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 85;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "SP Temp [°C]";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "SP Status";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 85;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "CS Temp [V]";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "CS Status";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 85;
            // 
            // chartMeasurements
            // 
            chartArea1.Name = "ChartArea1";
            this.chartMeasurements.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartMeasurements.Legends.Add(legend1);
            this.chartMeasurements.Location = new System.Drawing.Point(37, 59);
            this.chartMeasurements.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartMeasurements.Name = "chartMeasurements";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartMeasurements.Series.Add(series1);
            this.chartMeasurements.Size = new System.Drawing.Size(975, 320);
            this.chartMeasurements.TabIndex = 0;
            title1.Name = "Title1";
            this.chartMeasurements.Titles.Add(title1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Current measuerement";
            // 
            // txtCurrent
            // 
            this.txtCurrent.Enabled = false;
            this.txtCurrent.Location = new System.Drawing.Point(192, 18);
            this.txtCurrent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCurrent.Name = "txtCurrent";
            this.txtCurrent.Size = new System.Drawing.Size(173, 22);
            this.txtCurrent.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAvg);
            this.groupBox1.Controls.Add(this.txtAvg);
            this.groupBox1.Controls.Add(this.lblMaxTemperature);
            this.groupBox1.Controls.Add(this.txtMaxMeasurement);
            this.groupBox1.Controls.Add(this.lblMinMeasurement);
            this.groupBox1.Controls.Add(this.txtMinMeasurement);
            this.groupBox1.Location = new System.Drawing.Point(1060, 59);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(191, 255);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PV Statistics";
            // 
            // lblAvg
            // 
            this.lblAvg.AutoSize = true;
            this.lblAvg.Location = new System.Drawing.Point(43, 172);
            this.lblAvg.Name = "lblAvg";
            this.lblAvg.Size = new System.Drawing.Size(94, 17);
            this.lblAvg.TabIndex = 9;
            this.lblAvg.Text = "Avg temp [°C]";
            // 
            // txtAvg
            // 
            this.txtAvg.Enabled = false;
            this.txtAvg.Location = new System.Drawing.Point(43, 191);
            this.txtAvg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAvg.Name = "txtAvg";
            this.txtAvg.Size = new System.Drawing.Size(97, 22);
            this.txtAvg.TabIndex = 8;
            // 
            // lblMaxTemperature
            // 
            this.lblMaxTemperature.AutoSize = true;
            this.lblMaxTemperature.Location = new System.Drawing.Point(43, 107);
            this.lblMaxTemperature.Name = "lblMaxTemperature";
            this.lblMaxTemperature.Size = new System.Drawing.Size(100, 17);
            this.lblMaxTemperature.TabIndex = 7;
            this.lblMaxTemperature.Text = "Max Temp [°C]";
            // 
            // txtMaxMeasurement
            // 
            this.txtMaxMeasurement.Enabled = false;
            this.txtMaxMeasurement.Location = new System.Drawing.Point(43, 126);
            this.txtMaxMeasurement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaxMeasurement.Name = "txtMaxMeasurement";
            this.txtMaxMeasurement.Size = new System.Drawing.Size(97, 22);
            this.txtMaxMeasurement.TabIndex = 6;
            // 
            // lblMinMeasurement
            // 
            this.lblMinMeasurement.AutoSize = true;
            this.lblMinMeasurement.Location = new System.Drawing.Point(43, 42);
            this.lblMinMeasurement.Name = "lblMinMeasurement";
            this.lblMinMeasurement.Size = new System.Drawing.Size(97, 17);
            this.lblMinMeasurement.TabIndex = 5;
            this.lblMinMeasurement.Text = "Min Temp [°C]";
            // 
            // txtMinMeasurement
            // 
            this.txtMinMeasurement.Enabled = false;
            this.txtMinMeasurement.Location = new System.Drawing.Point(43, 60);
            this.txtMinMeasurement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMinMeasurement.Name = "txtMinMeasurement";
            this.txtMinMeasurement.Size = new System.Drawing.Size(97, 22);
            this.txtMinMeasurement.TabIndex = 4;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(1176, 631);
            this.btnStop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(1095, 631);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txtServerEndpoint);
            this.tabPage2.Controls.Add(this.numInterval);
            this.tabPage2.Controls.Add(this.lblInterval);
            this.tabPage2.Controls.Add(this.chkRunSimulator);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1287, 687);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Configuration";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(403, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(633, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "The clear database buttons empties all the content of the TAGDATA table in the SC" +
    "ADA database. ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 122);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 28);
            this.button1.TabIndex = 11;
            this.button1.Text = "Clear database";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(403, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "OPC Server Endpoint URL";
            // 
            // txtServerEndpoint
            // 
            this.txtServerEndpoint.Enabled = false;
            this.txtServerEndpoint.Location = new System.Drawing.Point(407, 76);
            this.txtServerEndpoint.Margin = new System.Windows.Forms.Padding(4);
            this.txtServerEndpoint.Name = "txtServerEndpoint";
            this.txtServerEndpoint.Size = new System.Drawing.Size(724, 22);
            this.txtServerEndpoint.TabIndex = 9;
            // 
            // numInterval
            // 
            this.numInterval.Location = new System.Drawing.Point(36, 76);
            this.numInterval.Margin = new System.Windows.Forms.Padding(4);
            this.numInterval.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numInterval.Name = "numInterval";
            this.numInterval.Size = new System.Drawing.Size(160, 22);
            this.numInterval.TabIndex = 8;
            this.numInterval.ValueChanged += new System.EventHandler(this.numInterval_ValueChanged);
            // 
            // lblInterval
            // 
            this.lblInterval.AutoSize = true;
            this.lblInterval.Location = new System.Drawing.Point(32, 57);
            this.lblInterval.Name = "lblInterval";
            this.lblInterval.Size = new System.Drawing.Size(139, 17);
            this.lblInterval.TabIndex = 7;
            this.lblInterval.Text = "Logging interval [ms]";
            // 
            // chkRunSimulator
            // 
            this.chkRunSimulator.AutoSize = true;
            this.chkRunSimulator.Location = new System.Drawing.Point(36, 23);
            this.chkRunSimulator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkRunSimulator.Name = "chkRunSimulator";
            this.chkRunSimulator.Size = new System.Drawing.Size(117, 21);
            this.chkRunSimulator.TabIndex = 3;
            this.chkRunSimulator.Text = "Run simulator";
            this.chkRunSimulator.UseVisualStyleBackColor = true;
            this.chkRunSimulator.CheckedChanged += new System.EventHandler(this.chkRunSimulator_CheckedChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.grpOtherTags);
            this.tabPage3.Controls.Add(this.grpProcessVariable);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1287, 687);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Simulator settings";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // grpOtherTags
            // 
            this.grpOtherTags.Controls.Add(this.cbxAutomaticStatus);
            this.grpOtherTags.Controls.Add(this.cbxControlSystemOnlineStatus);
            this.grpOtherTags.Controls.Add(this.cbxSimulatedPVStatus);
            this.grpOtherTags.Controls.Add(this.cbxControlSignalStatus);
            this.grpOtherTags.Controls.Add(this.lblControlSystemOnlineStatus);
            this.grpOtherTags.Controls.Add(this.cbxSetPointStatus);
            this.grpOtherTags.Controls.Add(this.lblAutomaticStatus);
            this.grpOtherTags.Controls.Add(this.lblSimulatedProcessVariable);
            this.grpOtherTags.Controls.Add(this.label5);
            this.grpOtherTags.Controls.Add(this.numAutomatic);
            this.grpOtherTags.Controls.Add(this.lblAutomatic);
            this.grpOtherTags.Controls.Add(this.numControlSystemOnline);
            this.grpOtherTags.Controls.Add(this.lblSetpointStatus);
            this.grpOtherTags.Controls.Add(this.numSimulatedPV);
            this.grpOtherTags.Controls.Add(this.numSimControlSignal);
            this.grpOtherTags.Controls.Add(this.lblSimValue);
            this.grpOtherTags.Controls.Add(this.lblControlSystemOnline);
            this.grpOtherTags.Controls.Add(this.lblControlValue);
            this.grpOtherTags.Controls.Add(this.numSimSetpoint);
            this.grpOtherTags.Controls.Add(this.lblSetpoint);
            this.grpOtherTags.Location = new System.Drawing.Point(301, 23);
            this.grpOtherTags.Margin = new System.Windows.Forms.Padding(4);
            this.grpOtherTags.Name = "grpOtherTags";
            this.grpOtherTags.Padding = new System.Windows.Forms.Padding(4);
            this.grpOtherTags.Size = new System.Drawing.Size(473, 353);
            this.grpOtherTags.TabIndex = 10;
            this.grpOtherTags.TabStop = false;
            this.grpOtherTags.Text = "Other Tags";
            // 
            // lblControlSystemOnlineStatus
            // 
            this.lblControlSystemOnlineStatus.AutoSize = true;
            this.lblControlSystemOnlineStatus.Location = new System.Drawing.Point(273, 220);
            this.lblControlSystemOnlineStatus.Name = "lblControlSystemOnlineStatus";
            this.lblControlSystemOnlineStatus.Size = new System.Drawing.Size(192, 17);
            this.lblControlSystemOnlineStatus.TabIndex = 18;
            this.lblControlSystemOnlineStatus.Text = "Control System Online Status";
            // 
            // lblAutomaticStatus
            // 
            this.lblAutomaticStatus.AutoSize = true;
            this.lblAutomaticStatus.Location = new System.Drawing.Point(275, 285);
            this.lblAutomaticStatus.Name = "lblAutomaticStatus";
            this.lblAutomaticStatus.Size = new System.Drawing.Size(114, 17);
            this.lblAutomaticStatus.TabIndex = 16;
            this.lblAutomaticStatus.Text = "Automatic Status";
            // 
            // lblSimulatedProcessVariable
            // 
            this.lblSimulatedProcessVariable.AutoSize = true;
            this.lblSimulatedProcessVariable.Location = new System.Drawing.Point(273, 154);
            this.lblSimulatedProcessVariable.Name = "lblSimulatedProcessVariable";
            this.lblSimulatedProcessVariable.Size = new System.Drawing.Size(136, 17);
            this.lblSimulatedProcessVariable.TabIndex = 14;
            this.lblSimulatedProcessVariable.Text = "Simulated PV Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(275, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Control Signal Status";
            // 
            // numAutomatic
            // 
            this.numAutomatic.Location = new System.Drawing.Point(37, 303);
            this.numAutomatic.Margin = new System.Windows.Forms.Padding(4);
            this.numAutomatic.Name = "numAutomatic";
            this.numAutomatic.Size = new System.Drawing.Size(160, 22);
            this.numAutomatic.TabIndex = 11;
            // 
            // lblAutomatic
            // 
            this.lblAutomatic.AutoSize = true;
            this.lblAutomatic.Location = new System.Drawing.Point(33, 285);
            this.lblAutomatic.Name = "lblAutomatic";
            this.lblAutomatic.Size = new System.Drawing.Size(70, 17);
            this.lblAutomatic.TabIndex = 2;
            this.lblAutomatic.Text = "Automatic";
            // 
            // numControlSystemOnline
            // 
            this.numControlSystemOnline.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numControlSystemOnline.Location = new System.Drawing.Point(37, 239);
            this.numControlSystemOnline.Margin = new System.Windows.Forms.Padding(4);
            this.numControlSystemOnline.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numControlSystemOnline.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numControlSystemOnline.Name = "numControlSystemOnline";
            this.numControlSystemOnline.Size = new System.Drawing.Size(160, 22);
            this.numControlSystemOnline.TabIndex = 11;
            // 
            // lblSetpointStatus
            // 
            this.lblSetpointStatus.AutoSize = true;
            this.lblSetpointStatus.Location = new System.Drawing.Point(273, 37);
            this.lblSetpointStatus.Name = "lblSetpointStatus";
            this.lblSetpointStatus.Size = new System.Drawing.Size(104, 17);
            this.lblSetpointStatus.TabIndex = 1;
            this.lblSetpointStatus.Text = "Setpoint Status";
            // 
            // numSimulatedPV
            // 
            this.numSimulatedPV.Location = new System.Drawing.Point(37, 172);
            this.numSimulatedPV.Margin = new System.Windows.Forms.Padding(4);
            this.numSimulatedPV.Name = "numSimulatedPV";
            this.numSimulatedPV.Size = new System.Drawing.Size(160, 22);
            this.numSimulatedPV.TabIndex = 8;
            // 
            // numSimControlSignal
            // 
            this.numSimControlSignal.Location = new System.Drawing.Point(36, 112);
            this.numSimControlSignal.Margin = new System.Windows.Forms.Padding(4);
            this.numSimControlSignal.Name = "numSimControlSignal";
            this.numSimControlSignal.Size = new System.Drawing.Size(160, 22);
            this.numSimControlSignal.TabIndex = 8;
            // 
            // lblSimValue
            // 
            this.lblSimValue.AutoSize = true;
            this.lblSimValue.Location = new System.Drawing.Point(33, 153);
            this.lblSimValue.Name = "lblSimValue";
            this.lblSimValue.Size = new System.Drawing.Size(208, 17);
            this.lblSimValue.TabIndex = 2;
            this.lblSimValue.Text = "Simulated Process Variable [°C]";
            // 
            // lblControlSystemOnline
            // 
            this.lblControlSystemOnline.AutoSize = true;
            this.lblControlSystemOnline.Location = new System.Drawing.Point(31, 220);
            this.lblControlSystemOnline.Name = "lblControlSystemOnline";
            this.lblControlSystemOnline.Size = new System.Drawing.Size(148, 17);
            this.lblControlSystemOnline.TabIndex = 2;
            this.lblControlSystemOnline.Text = "Control System Online";
            // 
            // lblControlValue
            // 
            this.lblControlValue.AutoSize = true;
            this.lblControlValue.Location = new System.Drawing.Point(33, 92);
            this.lblControlValue.Name = "lblControlValue";
            this.lblControlValue.Size = new System.Drawing.Size(123, 17);
            this.lblControlValue.TabIndex = 2;
            this.lblControlValue.Text = "Control Signal [°C]";
            // 
            // numSimSetpoint
            // 
            this.numSimSetpoint.Location = new System.Drawing.Point(35, 55);
            this.numSimSetpoint.Margin = new System.Windows.Forms.Padding(4);
            this.numSimSetpoint.Name = "numSimSetpoint";
            this.numSimSetpoint.Size = new System.Drawing.Size(160, 22);
            this.numSimSetpoint.TabIndex = 8;
            // 
            // lblSetpoint
            // 
            this.lblSetpoint.AutoSize = true;
            this.lblSetpoint.Location = new System.Drawing.Point(32, 36);
            this.lblSetpoint.Name = "lblSetpoint";
            this.lblSetpoint.Size = new System.Drawing.Size(87, 17);
            this.lblSetpoint.TabIndex = 2;
            this.lblSetpoint.Text = "Setpoint [°C]";
            // 
            // grpProcessVariable
            // 
            this.grpProcessVariable.Controls.Add(this.cbxPVStatus);
            this.grpProcessVariable.Controls.Add(this.numAlpha);
            this.grpProcessVariable.Controls.Add(this.numLowerLimit);
            this.grpProcessVariable.Controls.Add(this.numUpperLimit);
            this.grpProcessVariable.Controls.Add(this.lblAlpha);
            this.grpProcessVariable.Controls.Add(this.lblPVStatus);
            this.grpProcessVariable.Controls.Add(this.lblUpperLimit);
            this.grpProcessVariable.Controls.Add(this.lblLowerLimit);
            this.grpProcessVariable.Controls.Add(this.chkRunFilter);
            this.grpProcessVariable.Location = new System.Drawing.Point(33, 23);
            this.grpProcessVariable.Margin = new System.Windows.Forms.Padding(4);
            this.grpProcessVariable.Name = "grpProcessVariable";
            this.grpProcessVariable.Padding = new System.Windows.Forms.Padding(4);
            this.grpProcessVariable.Size = new System.Drawing.Size(243, 353);
            this.grpProcessVariable.TabIndex = 9;
            this.grpProcessVariable.TabStop = false;
            this.grpProcessVariable.Text = "Process Variable";
            // 
            // numAlpha
            // 
            this.numAlpha.Location = new System.Drawing.Point(41, 172);
            this.numAlpha.Margin = new System.Windows.Forms.Padding(4);
            this.numAlpha.Name = "numAlpha";
            this.numAlpha.Size = new System.Drawing.Size(160, 22);
            this.numAlpha.TabIndex = 25;
            // 
            // numLowerLimit
            // 
            this.numLowerLimit.Location = new System.Drawing.Point(41, 114);
            this.numLowerLimit.Margin = new System.Windows.Forms.Padding(4);
            this.numLowerLimit.Name = "numLowerLimit";
            this.numLowerLimit.Size = new System.Drawing.Size(160, 22);
            this.numLowerLimit.TabIndex = 24;
            // 
            // numUpperLimit
            // 
            this.numUpperLimit.Location = new System.Drawing.Point(41, 55);
            this.numUpperLimit.Margin = new System.Windows.Forms.Padding(4);
            this.numUpperLimit.Name = "numUpperLimit";
            this.numUpperLimit.Size = new System.Drawing.Size(160, 22);
            this.numUpperLimit.TabIndex = 23;
            // 
            // lblAlpha
            // 
            this.lblAlpha.AutoSize = true;
            this.lblAlpha.Location = new System.Drawing.Point(37, 154);
            this.lblAlpha.Name = "lblAlpha";
            this.lblAlpha.Size = new System.Drawing.Size(44, 17);
            this.lblAlpha.TabIndex = 22;
            this.lblAlpha.Text = "Alpha";
            // 
            // lblPVStatus
            // 
            this.lblPVStatus.AutoSize = true;
            this.lblPVStatus.Location = new System.Drawing.Point(37, 286);
            this.lblPVStatus.Name = "lblPVStatus";
            this.lblPVStatus.Size = new System.Drawing.Size(70, 17);
            this.lblPVStatus.TabIndex = 20;
            this.lblPVStatus.Text = "PV Status";
            // 
            // lblUpperLimit
            // 
            this.lblUpperLimit.AutoSize = true;
            this.lblUpperLimit.Location = new System.Drawing.Point(37, 37);
            this.lblUpperLimit.Name = "lblUpperLimit";
            this.lblUpperLimit.Size = new System.Drawing.Size(107, 17);
            this.lblUpperLimit.TabIndex = 0;
            this.lblUpperLimit.Text = "Upper Limit [°C]";
            // 
            // lblLowerLimit
            // 
            this.lblLowerLimit.AutoSize = true;
            this.lblLowerLimit.Location = new System.Drawing.Point(37, 95);
            this.lblLowerLimit.Name = "lblLowerLimit";
            this.lblLowerLimit.Size = new System.Drawing.Size(106, 17);
            this.lblLowerLimit.TabIndex = 1;
            this.lblLowerLimit.Text = "Lower Limit [°C]";
            // 
            // chkRunFilter
            // 
            this.chkRunFilter.AutoSize = true;
            this.chkRunFilter.Location = new System.Drawing.Point(41, 239);
            this.chkRunFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkRunFilter.Name = "chkRunFilter";
            this.chkRunFilter.Size = new System.Drawing.Size(87, 21);
            this.chkRunFilter.TabIndex = 6;
            this.chkRunFilter.Text = "Run filter";
            this.chkRunFilter.UseVisualStyleBackColor = true;
            this.chkRunFilter.CheckedChanged += new System.EventHandler(this.chkRunFilter_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(29, 402);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(766, 119);
            this.label3.TabIndex = 7;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // grpStatus
            // 
            this.grpStatus.Controls.Add(this.txtMode);
            this.grpStatus.Controls.Add(this.lblConControl);
            this.grpStatus.Controls.Add(this.lblMode);
            this.grpStatus.Controls.Add(this.txtControlSystemStatus);
            this.grpStatus.Location = new System.Drawing.Point(1060, 319);
            this.grpStatus.Name = "grpStatus";
            this.grpStatus.Size = new System.Drawing.Size(191, 150);
            this.grpStatus.TabIndex = 17;
            this.grpStatus.TabStop = false;
            this.grpStatus.Text = "Status";
            // 
            // txtCurrentContolSignal
            // 
            this.txtCurrentContolSignal.Enabled = false;
            this.txtCurrentContolSignal.Location = new System.Drawing.Point(801, 22);
            this.txtCurrentContolSignal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCurrentContolSignal.Name = "txtCurrentContolSignal";
            this.txtCurrentContolSignal.Size = new System.Drawing.Size(173, 22);
            this.txtCurrentContolSignal.TabIndex = 12;
            // 
            // lblCurrCS
            // 
            this.lblCurrCS.AutoSize = true;
            this.lblCurrCS.Location = new System.Drawing.Point(676, 25);
            this.lblCurrCS.Name = "lblCurrCS";
            this.lblCurrCS.Size = new System.Drawing.Size(119, 17);
            this.lblCurrCS.TabIndex = 13;
            this.lblCurrCS.Text = "Control signal [V]:";
            // 
            // cbxSetPointStatus
            // 
            this.cbxSetPointStatus.FormattingEnabled = true;
            this.cbxSetPointStatus.Items.AddRange(new object[] {
            "Good",
            "Bad",
            "Uncertain",
            "Overflow",
            "Status Unknown"});
            this.cbxSetPointStatus.Location = new System.Drawing.Point(278, 55);
            this.cbxSetPointStatus.Name = "cbxSetPointStatus";
            this.cbxSetPointStatus.Size = new System.Drawing.Size(121, 24);
            this.cbxSetPointStatus.TabIndex = 11;
            // 
            // cbxControlSignalStatus
            // 
            this.cbxControlSignalStatus.FormattingEnabled = true;
            this.cbxControlSignalStatus.Items.AddRange(new object[] {
            "Good",
            "Bad",
            "Uncertain",
            "Overflow",
            "Status Unknown"});
            this.cbxControlSignalStatus.Location = new System.Drawing.Point(278, 110);
            this.cbxControlSignalStatus.Name = "cbxControlSignalStatus";
            this.cbxControlSignalStatus.Size = new System.Drawing.Size(121, 24);
            this.cbxControlSignalStatus.TabIndex = 11;
            // 
            // cbxSimulatedPVStatus
            // 
            this.cbxSimulatedPVStatus.FormattingEnabled = true;
            this.cbxSimulatedPVStatus.Items.AddRange(new object[] {
            "Good",
            "Bad",
            "Uncertain",
            "Overflow",
            "Status Unknown"});
            this.cbxSimulatedPVStatus.Location = new System.Drawing.Point(278, 170);
            this.cbxSimulatedPVStatus.Name = "cbxSimulatedPVStatus";
            this.cbxSimulatedPVStatus.Size = new System.Drawing.Size(121, 24);
            this.cbxSimulatedPVStatus.TabIndex = 11;
            // 
            // cbxControlSystemOnlineStatus
            // 
            this.cbxControlSystemOnlineStatus.FormattingEnabled = true;
            this.cbxControlSystemOnlineStatus.Items.AddRange(new object[] {
            "Good",
            "Bad",
            "Uncertain",
            "Overflow",
            "Status Unknown"});
            this.cbxControlSystemOnlineStatus.Location = new System.Drawing.Point(278, 240);
            this.cbxControlSystemOnlineStatus.Name = "cbxControlSystemOnlineStatus";
            this.cbxControlSystemOnlineStatus.Size = new System.Drawing.Size(121, 24);
            this.cbxControlSystemOnlineStatus.TabIndex = 11;
            // 
            // cbxAutomaticStatus
            // 
            this.cbxAutomaticStatus.FormattingEnabled = true;
            this.cbxAutomaticStatus.Items.AddRange(new object[] {
            "Good",
            "Bad",
            "Uncertain",
            "Overflow",
            "Status Unknown"});
            this.cbxAutomaticStatus.Location = new System.Drawing.Point(278, 303);
            this.cbxAutomaticStatus.Name = "cbxAutomaticStatus";
            this.cbxAutomaticStatus.Size = new System.Drawing.Size(121, 24);
            this.cbxAutomaticStatus.TabIndex = 11;
            // 
            // cbxPVStatus
            // 
            this.cbxPVStatus.FormattingEnabled = true;
            this.cbxPVStatus.Items.AddRange(new object[] {
            "Good",
            "Bad",
            "Uncertain",
            "Overflow",
            "Status Unknown"});
            this.cbxPVStatus.Location = new System.Drawing.Point(40, 303);
            this.cbxPVStatus.Name = "cbxPVStatus";
            this.cbxPVStatus.Size = new System.Drawing.Size(121, 24);
            this.cbxPVStatus.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 714);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Datalogger";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMeasurements)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numInterval)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.grpOtherTags.ResumeLayout(false);
            this.grpOtherTags.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAutomatic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numControlSystemOnline)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSimulatedPV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSimControlSignal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSimSetpoint)).EndInit();
            this.grpProcessVariable.ResumeLayout(false);
            this.grpProcessVariable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAlpha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLowerLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpperLimit)).EndInit();
            this.grpStatus.ResumeLayout(false);
            this.grpStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMeasurements;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCurrent;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblSetpoint;
        private System.Windows.Forms.Label lblLowerLimit;
        private System.Windows.Forms.Label lblUpperLimit;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label lblAvg;
        private System.Windows.Forms.TextBox txtAvg;
        private System.Windows.Forms.Label lblMaxTemperature;
        private System.Windows.Forms.TextBox txtMaxMeasurement;
        private System.Windows.Forms.Label lblMinMeasurement;
        private System.Windows.Forms.TextBox txtMinMeasurement;
        private System.Windows.Forms.CheckBox chkRunFilter;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblInterval;
        private System.Windows.Forms.CheckBox chkRunSimulator;
        private System.Windows.Forms.NumericUpDown numInterval;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblCurrTemp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtServerEndpoint;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.TextBox txtMode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpOtherTags;
        private NationalInstruments.UI.WindowsForms.NumericEdit numSimSetpoint;
        private System.Windows.Forms.GroupBox grpProcessVariable;
        private System.Windows.Forms.NumericUpDown numControlSystemOnline;
        private System.Windows.Forms.NumericUpDown numAutomatic;
        private NationalInstruments.UI.WindowsForms.NumericEdit numSimControlSignal;
        private System.Windows.Forms.Label lblControlSystemOnline;
        private System.Windows.Forms.Label lblAutomatic;
        private System.Windows.Forms.Label lblControlValue;
        private NationalInstruments.UI.WindowsForms.NumericEdit numSimulatedPV;
        private System.Windows.Forms.Label lblSimValue;
        private System.Windows.Forms.Label lblControlSystemOnlineStatus;
        private System.Windows.Forms.Label lblAutomaticStatus;
        private System.Windows.Forms.Label lblSimulatedProcessVariable;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSetpointStatus;
        private System.Windows.Forms.Label lblPVStatus;
        private System.Windows.Forms.Label lblAlpha;
        private NationalInstruments.UI.WindowsForms.NumericEdit numAlpha;
        private NationalInstruments.UI.WindowsForms.NumericEdit numLowerLimit;
        private NationalInstruments.UI.WindowsForms.NumericEdit numUpperLimit;
        private System.Windows.Forms.Label lblCurrSetpoint;
        private System.Windows.Forms.TextBox txtCurrentSetpoint;
        private System.Windows.Forms.Button btnSaveHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Label lblConControl;
        private System.Windows.Forms.TextBox txtControlSystemStatus;
        private System.Windows.Forms.GroupBox grpStatus;
        private System.Windows.Forms.Label lblCurrCS;
        private System.Windows.Forms.TextBox txtCurrentContolSignal;
        private System.Windows.Forms.ComboBox cbxAutomaticStatus;
        private System.Windows.Forms.ComboBox cbxControlSystemOnlineStatus;
        private System.Windows.Forms.ComboBox cbxSimulatedPVStatus;
        private System.Windows.Forms.ComboBox cbxControlSignalStatus;
        private System.Windows.Forms.ComboBox cbxSetPointStatus;
        private System.Windows.Forms.ComboBox cbxPVStatus;
    }
}

