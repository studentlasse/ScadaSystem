
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
            this.lblRandomNumberStatus = new System.Windows.Forms.Label();
            this.txtRandomNumberStatus = new System.Windows.Forms.TextBox();
            this.lblIoErrorStatus = new System.Windows.Forms.Label();
            this.txtIOStatus = new System.Windows.Forms.TextBox();
            this.lblSimulatedProcessVariable = new System.Windows.Forms.Label();
            this.txtSimPVStatus = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtControlSignalStatus = new System.Windows.Forms.TextBox();
            this.numSimRandomNumber = new System.Windows.Forms.NumericUpDown();
            this.numSimIoError = new System.Windows.Forms.NumericUpDown();
            this.lblSetpointStatus = new System.Windows.Forms.Label();
            this.numSimulatedPV = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.txtSetpointStatus = new System.Windows.Forms.TextBox();
            this.numSimControlSignal = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.lblSimValue = new System.Windows.Forms.Label();
            this.lblRandomNumber = new System.Windows.Forms.Label();
            this.lblIoError = new System.Windows.Forms.Label();
            this.lblControlValue = new System.Windows.Forms.Label();
            this.numSimSetpoint = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.lblSetpoint = new System.Windows.Forms.Label();
            this.grpProcessVariable = new System.Windows.Forms.GroupBox();
            this.numAlpha = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.numLowerLimit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.numUpperLimit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.lblAlpha = new System.Windows.Forms.Label();
            this.lblPVStatus = new System.Windows.Forms.Label();
            this.txtPVStatus = new System.Windows.Forms.TextBox();
            this.lblUpperLimit = new System.Windows.Forms.Label();
            this.lblLowerLimit = new System.Windows.Forms.Label();
            this.chkRunFilter = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl = new System.Windows.Forms.Label();
            this.txtCurrentSetpoint = new System.Windows.Forms.TextBox();
            this.btnSaveHistory = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMeasurements)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numInterval)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.grpOtherTags.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSimRandomNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSimIoError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSimulatedPV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSimControlSignal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSimSetpoint)).BeginInit();
            this.grpProcessVariable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAlpha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLowerLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpperLimit)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(971, 582);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnSaveHistory);
            this.tabPage1.Controls.Add(this.lbl);
            this.tabPage1.Controls.Add(this.txtCurrentSetpoint);
            this.tabPage1.Controls.Add(this.lblMode);
            this.tabPage1.Controls.Add(this.txtMode);
            this.tabPage1.Controls.Add(this.lblCurrTemp);
            this.tabPage1.Controls.Add(this.dataGridView);
            this.tabPage1.Controls.Add(this.chartMeasurements);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtCurrent);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btnStop);
            this.tabPage1.Controls.Add(this.btnStart);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(963, 556);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "Logging";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Location = new System.Drawing.Point(824, 310);
            this.lblMode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(34, 13);
            this.lblMode.TabIndex = 11;
            this.lblMode.Text = "Mode";
            // 
            // txtMode
            // 
            this.txtMode.Enabled = false;
            this.txtMode.Location = new System.Drawing.Point(827, 325);
            this.txtMode.Name = "txtMode";
            this.txtMode.Size = new System.Drawing.Size(100, 20);
            this.txtMode.TabIndex = 10;
            // 
            // lblCurrTemp
            // 
            this.lblCurrTemp.AutoSize = true;
            this.lblCurrTemp.Location = new System.Drawing.Point(25, 17);
            this.lblCurrTemp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrTemp.Name = "lblCurrTemp";
            this.lblCurrTemp.Size = new System.Drawing.Size(90, 13);
            this.lblCurrTemp.TabIndex = 6;
            this.lblCurrTemp.Text = "Current temp [°C]:";
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
            this.dataGridView.Location = new System.Drawing.Point(28, 325);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView.Size = new System.Drawing.Size(743, 206);
            this.dataGridView.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Time [s]";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "PV Temp [°C]";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "PV status";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "SP Temp [°C]";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "SP Status";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "CS Temp [°C]";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "CS Status";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // chartMeasurements
            // 
            chartArea1.Name = "ChartArea1";
            this.chartMeasurements.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartMeasurements.Legends.Add(legend1);
            this.chartMeasurements.Location = new System.Drawing.Point(28, 48);
            this.chartMeasurements.Margin = new System.Windows.Forms.Padding(2);
            this.chartMeasurements.Name = "chartMeasurements";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartMeasurements.Series.Add(series1);
            this.chartMeasurements.Size = new System.Drawing.Size(731, 260);
            this.chartMeasurements.TabIndex = 0;
            title1.Name = "Title1";
            this.chartMeasurements.Titles.Add(title1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 148);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Current measuerement";
            // 
            // txtCurrent
            // 
            this.txtCurrent.Enabled = false;
            this.txtCurrent.Location = new System.Drawing.Point(129, 14);
            this.txtCurrent.Margin = new System.Windows.Forms.Padding(2);
            this.txtCurrent.Name = "txtCurrent";
            this.txtCurrent.Size = new System.Drawing.Size(131, 20);
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
            this.groupBox1.Location = new System.Drawing.Point(795, 79);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(143, 207);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PV Statistics";
            // 
            // lblAvg
            // 
            this.lblAvg.AutoSize = true;
            this.lblAvg.Location = new System.Drawing.Point(32, 140);
            this.lblAvg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAvg.Name = "lblAvg";
            this.lblAvg.Size = new System.Drawing.Size(72, 13);
            this.lblAvg.TabIndex = 9;
            this.lblAvg.Text = "Avg temp [°C]";
            // 
            // txtAvg
            // 
            this.txtAvg.Enabled = false;
            this.txtAvg.Location = new System.Drawing.Point(32, 155);
            this.txtAvg.Margin = new System.Windows.Forms.Padding(2);
            this.txtAvg.Name = "txtAvg";
            this.txtAvg.Size = new System.Drawing.Size(74, 20);
            this.txtAvg.TabIndex = 8;
            // 
            // lblMaxTemperature
            // 
            this.lblMaxTemperature.AutoSize = true;
            this.lblMaxTemperature.Location = new System.Drawing.Point(32, 87);
            this.lblMaxTemperature.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaxTemperature.Name = "lblMaxTemperature";
            this.lblMaxTemperature.Size = new System.Drawing.Size(77, 13);
            this.lblMaxTemperature.TabIndex = 7;
            this.lblMaxTemperature.Text = "Max Temp [°C]";
            // 
            // txtMaxMeasurement
            // 
            this.txtMaxMeasurement.Enabled = false;
            this.txtMaxMeasurement.Location = new System.Drawing.Point(32, 102);
            this.txtMaxMeasurement.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaxMeasurement.Name = "txtMaxMeasurement";
            this.txtMaxMeasurement.Size = new System.Drawing.Size(74, 20);
            this.txtMaxMeasurement.TabIndex = 6;
            // 
            // lblMinMeasurement
            // 
            this.lblMinMeasurement.AutoSize = true;
            this.lblMinMeasurement.Location = new System.Drawing.Point(32, 34);
            this.lblMinMeasurement.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMinMeasurement.Name = "lblMinMeasurement";
            this.lblMinMeasurement.Size = new System.Drawing.Size(74, 13);
            this.lblMinMeasurement.TabIndex = 5;
            this.lblMinMeasurement.Text = "Min Temp [°C]";
            // 
            // txtMinMeasurement
            // 
            this.txtMinMeasurement.Enabled = false;
            this.txtMinMeasurement.Location = new System.Drawing.Point(32, 49);
            this.txtMinMeasurement.Margin = new System.Windows.Forms.Padding(2);
            this.txtMinMeasurement.Name = "txtMinMeasurement";
            this.txtMinMeasurement.Size = new System.Drawing.Size(74, 20);
            this.txtMinMeasurement.TabIndex = 4;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(882, 512);
            this.btnStop.Margin = new System.Windows.Forms.Padding(2);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(56, 19);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(821, 512);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(56, 19);
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
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(963, 556);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Configuration";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(302, 99);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(477, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "The clear database buttons empties all the content of the TAGDATA table in the SC" +
    "ADA database. ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Clear database";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(302, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "OPC Server Endpoint URL";
            // 
            // txtServerEndpoint
            // 
            this.txtServerEndpoint.Enabled = false;
            this.txtServerEndpoint.Location = new System.Drawing.Point(305, 62);
            this.txtServerEndpoint.Name = "txtServerEndpoint";
            this.txtServerEndpoint.Size = new System.Drawing.Size(544, 20);
            this.txtServerEndpoint.TabIndex = 9;
            // 
            // numInterval
            // 
            this.numInterval.Location = new System.Drawing.Point(27, 62);
            this.numInterval.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numInterval.Name = "numInterval";
            this.numInterval.Size = new System.Drawing.Size(120, 20);
            this.numInterval.TabIndex = 8;
            this.numInterval.ValueChanged += new System.EventHandler(this.numInterval_ValueChanged);
            // 
            // lblInterval
            // 
            this.lblInterval.AutoSize = true;
            this.lblInterval.Location = new System.Drawing.Point(24, 46);
            this.lblInterval.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInterval.Name = "lblInterval";
            this.lblInterval.Size = new System.Drawing.Size(104, 13);
            this.lblInterval.TabIndex = 7;
            this.lblInterval.Text = "Logging interval [ms]";
            // 
            // chkRunSimulator
            // 
            this.chkRunSimulator.AutoSize = true;
            this.chkRunSimulator.Location = new System.Drawing.Point(27, 19);
            this.chkRunSimulator.Margin = new System.Windows.Forms.Padding(2);
            this.chkRunSimulator.Name = "chkRunSimulator";
            this.chkRunSimulator.Size = new System.Drawing.Size(90, 17);
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
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(963, 556);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Simulator settings";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // grpOtherTags
            // 
            this.grpOtherTags.Controls.Add(this.lblRandomNumberStatus);
            this.grpOtherTags.Controls.Add(this.txtRandomNumberStatus);
            this.grpOtherTags.Controls.Add(this.lblIoErrorStatus);
            this.grpOtherTags.Controls.Add(this.txtIOStatus);
            this.grpOtherTags.Controls.Add(this.lblSimulatedProcessVariable);
            this.grpOtherTags.Controls.Add(this.txtSimPVStatus);
            this.grpOtherTags.Controls.Add(this.label5);
            this.grpOtherTags.Controls.Add(this.txtControlSignalStatus);
            this.grpOtherTags.Controls.Add(this.numSimRandomNumber);
            this.grpOtherTags.Controls.Add(this.numSimIoError);
            this.grpOtherTags.Controls.Add(this.lblSetpointStatus);
            this.grpOtherTags.Controls.Add(this.numSimulatedPV);
            this.grpOtherTags.Controls.Add(this.txtSetpointStatus);
            this.grpOtherTags.Controls.Add(this.numSimControlSignal);
            this.grpOtherTags.Controls.Add(this.lblSimValue);
            this.grpOtherTags.Controls.Add(this.lblRandomNumber);
            this.grpOtherTags.Controls.Add(this.lblIoError);
            this.grpOtherTags.Controls.Add(this.lblControlValue);
            this.grpOtherTags.Controls.Add(this.numSimSetpoint);
            this.grpOtherTags.Controls.Add(this.lblSetpoint);
            this.grpOtherTags.Location = new System.Drawing.Point(226, 19);
            this.grpOtherTags.Name = "grpOtherTags";
            this.grpOtherTags.Size = new System.Drawing.Size(331, 287);
            this.grpOtherTags.TabIndex = 10;
            this.grpOtherTags.TabStop = false;
            this.grpOtherTags.Text = "Other Tags";
            // 
            // lblRandomNumberStatus
            // 
            this.lblRandomNumberStatus.AutoSize = true;
            this.lblRandomNumberStatus.Location = new System.Drawing.Point(206, 232);
            this.lblRandomNumberStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRandomNumberStatus.Name = "lblRandomNumberStatus";
            this.lblRandomNumberStatus.Size = new System.Drawing.Size(120, 13);
            this.lblRandomNumberStatus.TabIndex = 18;
            this.lblRandomNumberStatus.Text = "Random Number Status";
            // 
            // txtRandomNumberStatus
            // 
            this.txtRandomNumberStatus.Location = new System.Drawing.Point(208, 247);
            this.txtRandomNumberStatus.Margin = new System.Windows.Forms.Padding(2);
            this.txtRandomNumberStatus.Name = "txtRandomNumberStatus";
            this.txtRandomNumberStatus.Size = new System.Drawing.Size(76, 20);
            this.txtRandomNumberStatus.TabIndex = 19;
            // 
            // lblIoErrorStatus
            // 
            this.lblIoErrorStatus.AutoSize = true;
            this.lblIoErrorStatus.Location = new System.Drawing.Point(206, 179);
            this.lblIoErrorStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIoErrorStatus.Name = "lblIoErrorStatus";
            this.lblIoErrorStatus.Size = new System.Drawing.Size(76, 13);
            this.lblIoErrorStatus.TabIndex = 16;
            this.lblIoErrorStatus.Text = "IO Error Status";
            // 
            // txtIOStatus
            // 
            this.txtIOStatus.Location = new System.Drawing.Point(208, 194);
            this.txtIOStatus.Margin = new System.Windows.Forms.Padding(2);
            this.txtIOStatus.Name = "txtIOStatus";
            this.txtIOStatus.Size = new System.Drawing.Size(76, 20);
            this.txtIOStatus.TabIndex = 17;
            // 
            // lblSimulatedProcessVariable
            // 
            this.lblSimulatedProcessVariable.AutoSize = true;
            this.lblSimulatedProcessVariable.Location = new System.Drawing.Point(205, 125);
            this.lblSimulatedProcessVariable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSimulatedProcessVariable.Name = "lblSimulatedProcessVariable";
            this.lblSimulatedProcessVariable.Size = new System.Drawing.Size(103, 13);
            this.lblSimulatedProcessVariable.TabIndex = 14;
            this.lblSimulatedProcessVariable.Text = "Simulated PV Status";
            // 
            // txtSimPVStatus
            // 
            this.txtSimPVStatus.Location = new System.Drawing.Point(207, 140);
            this.txtSimPVStatus.Margin = new System.Windows.Forms.Padding(2);
            this.txtSimPVStatus.Name = "txtSimPVStatus";
            this.txtSimPVStatus.Size = new System.Drawing.Size(76, 20);
            this.txtSimPVStatus.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(206, 77);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Control Signal Status";
            // 
            // txtControlSignalStatus
            // 
            this.txtControlSignalStatus.Location = new System.Drawing.Point(208, 92);
            this.txtControlSignalStatus.Margin = new System.Windows.Forms.Padding(2);
            this.txtControlSignalStatus.Name = "txtControlSignalStatus";
            this.txtControlSignalStatus.Size = new System.Drawing.Size(76, 20);
            this.txtControlSignalStatus.TabIndex = 13;
            // 
            // numSimRandomNumber
            // 
            this.numSimRandomNumber.Location = new System.Drawing.Point(28, 248);
            this.numSimRandomNumber.Name = "numSimRandomNumber";
            this.numSimRandomNumber.Size = new System.Drawing.Size(120, 20);
            this.numSimRandomNumber.TabIndex = 11;
            // 
            // numSimIoError
            // 
            this.numSimIoError.Location = new System.Drawing.Point(28, 195);
            this.numSimIoError.Name = "numSimIoError";
            this.numSimIoError.Size = new System.Drawing.Size(120, 20);
            this.numSimIoError.TabIndex = 11;
            // 
            // lblSetpointStatus
            // 
            this.lblSetpointStatus.AutoSize = true;
            this.lblSetpointStatus.Location = new System.Drawing.Point(205, 30);
            this.lblSetpointStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSetpointStatus.Name = "lblSetpointStatus";
            this.lblSetpointStatus.Size = new System.Drawing.Size(79, 13);
            this.lblSetpointStatus.TabIndex = 1;
            this.lblSetpointStatus.Text = "Setpoint Status";
            // 
            // numSimulatedPV
            // 
            this.numSimulatedPV.Location = new System.Drawing.Point(28, 140);
            this.numSimulatedPV.Name = "numSimulatedPV";
            this.numSimulatedPV.Size = new System.Drawing.Size(120, 20);
            this.numSimulatedPV.TabIndex = 8;
            // 
            // txtSetpointStatus
            // 
            this.txtSetpointStatus.Location = new System.Drawing.Point(207, 45);
            this.txtSetpointStatus.Margin = new System.Windows.Forms.Padding(2);
            this.txtSetpointStatus.Name = "txtSetpointStatus";
            this.txtSetpointStatus.Size = new System.Drawing.Size(76, 20);
            this.txtSetpointStatus.TabIndex = 3;
            // 
            // numSimControlSignal
            // 
            this.numSimControlSignal.Location = new System.Drawing.Point(27, 91);
            this.numSimControlSignal.Name = "numSimControlSignal";
            this.numSimControlSignal.Size = new System.Drawing.Size(120, 20);
            this.numSimControlSignal.TabIndex = 8;
            // 
            // lblSimValue
            // 
            this.lblSimValue.AutoSize = true;
            this.lblSimValue.Location = new System.Drawing.Point(25, 124);
            this.lblSimValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSimValue.Name = "lblSimValue";
            this.lblSimValue.Size = new System.Drawing.Size(155, 13);
            this.lblSimValue.TabIndex = 2;
            this.lblSimValue.Text = "Simulated Process Variable [°C]";
            // 
            // lblRandomNumber
            // 
            this.lblRandomNumber.AutoSize = true;
            this.lblRandomNumber.Location = new System.Drawing.Point(25, 232);
            this.lblRandomNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRandomNumber.Name = "lblRandomNumber";
            this.lblRandomNumber.Size = new System.Drawing.Size(87, 13);
            this.lblRandomNumber.TabIndex = 2;
            this.lblRandomNumber.Text = "Random Number";
            // 
            // lblIoError
            // 
            this.lblIoError.AutoSize = true;
            this.lblIoError.Location = new System.Drawing.Point(25, 179);
            this.lblIoError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIoError.Name = "lblIoError";
            this.lblIoError.Size = new System.Drawing.Size(43, 13);
            this.lblIoError.TabIndex = 2;
            this.lblIoError.Text = "IO Error";
            // 
            // lblControlValue
            // 
            this.lblControlValue.AutoSize = true;
            this.lblControlValue.Location = new System.Drawing.Point(25, 75);
            this.lblControlValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblControlValue.Name = "lblControlValue";
            this.lblControlValue.Size = new System.Drawing.Size(92, 13);
            this.lblControlValue.TabIndex = 2;
            this.lblControlValue.Text = "Control Signal [°C]";
            // 
            // numSimSetpoint
            // 
            this.numSimSetpoint.Location = new System.Drawing.Point(26, 45);
            this.numSimSetpoint.Name = "numSimSetpoint";
            this.numSimSetpoint.Size = new System.Drawing.Size(120, 20);
            this.numSimSetpoint.TabIndex = 8;
            // 
            // lblSetpoint
            // 
            this.lblSetpoint.AutoSize = true;
            this.lblSetpoint.Location = new System.Drawing.Point(24, 29);
            this.lblSetpoint.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSetpoint.Name = "lblSetpoint";
            this.lblSetpoint.Size = new System.Drawing.Size(66, 13);
            this.lblSetpoint.TabIndex = 2;
            this.lblSetpoint.Text = "Setpoint [°C]";
            // 
            // grpProcessVariable
            // 
            this.grpProcessVariable.Controls.Add(this.numAlpha);
            this.grpProcessVariable.Controls.Add(this.numLowerLimit);
            this.grpProcessVariable.Controls.Add(this.numUpperLimit);
            this.grpProcessVariable.Controls.Add(this.lblAlpha);
            this.grpProcessVariable.Controls.Add(this.lblPVStatus);
            this.grpProcessVariable.Controls.Add(this.txtPVStatus);
            this.grpProcessVariable.Controls.Add(this.lblUpperLimit);
            this.grpProcessVariable.Controls.Add(this.lblLowerLimit);
            this.grpProcessVariable.Controls.Add(this.chkRunFilter);
            this.grpProcessVariable.Location = new System.Drawing.Point(25, 19);
            this.grpProcessVariable.Name = "grpProcessVariable";
            this.grpProcessVariable.Size = new System.Drawing.Size(182, 287);
            this.grpProcessVariable.TabIndex = 9;
            this.grpProcessVariable.TabStop = false;
            this.grpProcessVariable.Text = "Process Variable";
            // 
            // numAlpha
            // 
            this.numAlpha.Location = new System.Drawing.Point(31, 140);
            this.numAlpha.Name = "numAlpha";
            this.numAlpha.Size = new System.Drawing.Size(120, 20);
            this.numAlpha.TabIndex = 25;
            // 
            // numLowerLimit
            // 
            this.numLowerLimit.Location = new System.Drawing.Point(31, 93);
            this.numLowerLimit.Name = "numLowerLimit";
            this.numLowerLimit.Size = new System.Drawing.Size(120, 20);
            this.numLowerLimit.TabIndex = 24;
            // 
            // numUpperLimit
            // 
            this.numUpperLimit.Location = new System.Drawing.Point(31, 45);
            this.numUpperLimit.Name = "numUpperLimit";
            this.numUpperLimit.Size = new System.Drawing.Size(120, 20);
            this.numUpperLimit.TabIndex = 23;
            // 
            // lblAlpha
            // 
            this.lblAlpha.AutoSize = true;
            this.lblAlpha.Location = new System.Drawing.Point(28, 125);
            this.lblAlpha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAlpha.Name = "lblAlpha";
            this.lblAlpha.Size = new System.Drawing.Size(34, 13);
            this.lblAlpha.TabIndex = 22;
            this.lblAlpha.Text = "Alpha";
            // 
            // lblPVStatus
            // 
            this.lblPVStatus.AutoSize = true;
            this.lblPVStatus.Location = new System.Drawing.Point(28, 232);
            this.lblPVStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPVStatus.Name = "lblPVStatus";
            this.lblPVStatus.Size = new System.Drawing.Size(54, 13);
            this.lblPVStatus.TabIndex = 20;
            this.lblPVStatus.Text = "PV Status";
            // 
            // txtPVStatus
            // 
            this.txtPVStatus.Location = new System.Drawing.Point(31, 248);
            this.txtPVStatus.Margin = new System.Windows.Forms.Padding(2);
            this.txtPVStatus.Name = "txtPVStatus";
            this.txtPVStatus.Size = new System.Drawing.Size(76, 20);
            this.txtPVStatus.TabIndex = 21;
            // 
            // lblUpperLimit
            // 
            this.lblUpperLimit.AutoSize = true;
            this.lblUpperLimit.Location = new System.Drawing.Point(28, 30);
            this.lblUpperLimit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUpperLimit.Name = "lblUpperLimit";
            this.lblUpperLimit.Size = new System.Drawing.Size(80, 13);
            this.lblUpperLimit.TabIndex = 0;
            this.lblUpperLimit.Text = "Upper Limit [°C]";
            // 
            // lblLowerLimit
            // 
            this.lblLowerLimit.AutoSize = true;
            this.lblLowerLimit.Location = new System.Drawing.Point(28, 77);
            this.lblLowerLimit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLowerLimit.Name = "lblLowerLimit";
            this.lblLowerLimit.Size = new System.Drawing.Size(80, 13);
            this.lblLowerLimit.TabIndex = 1;
            this.lblLowerLimit.Text = "Lower Limit [°C]";
            // 
            // chkRunFilter
            // 
            this.chkRunFilter.AutoSize = true;
            this.chkRunFilter.Location = new System.Drawing.Point(31, 194);
            this.chkRunFilter.Margin = new System.Windows.Forms.Padding(2);
            this.chkRunFilter.Name = "chkRunFilter";
            this.chkRunFilter.Size = new System.Drawing.Size(68, 17);
            this.chkRunFilter.TabIndex = 6;
            this.chkRunFilter.Text = "Run filter";
            this.chkRunFilter.UseVisualStyleBackColor = true;
            this.chkRunFilter.CheckedChanged += new System.EventHandler(this.chkRunFilter_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(22, 327);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(567, 91);
            this.label3.TabIndex = 7;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(295, 17);
            this.lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(104, 13);
            this.lbl.TabIndex = 13;
            this.lbl.Text = "Current setpoint [°C]:";
            // 
            // txtCurrentSetpoint
            // 
            this.txtCurrentSetpoint.Enabled = false;
            this.txtCurrentSetpoint.Location = new System.Drawing.Point(414, 14);
            this.txtCurrentSetpoint.Margin = new System.Windows.Forms.Padding(2);
            this.txtCurrentSetpoint.Name = "txtCurrentSetpoint";
            this.txtCurrentSetpoint.Size = new System.Drawing.Size(131, 20);
            this.txtCurrentSetpoint.TabIndex = 12;
            // 
            // btnSaveHistory
            // 
            this.btnSaveHistory.Location = new System.Drawing.Point(827, 360);
            this.btnSaveHistory.Name = "btnSaveHistory";
            this.btnSaveHistory.Size = new System.Drawing.Size(100, 37);
            this.btnSaveHistory.TabIndex = 14;
            this.btnSaveHistory.Text = "Save history to file";
            this.btnSaveHistory.UseVisualStyleBackColor = true;
            this.btnSaveHistory.Click += new System.EventHandler(this.btnSaveHistory_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 580);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
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
            ((System.ComponentModel.ISupportInitialize)(this.numSimRandomNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSimIoError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSimulatedPV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSimControlSignal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSimSetpoint)).EndInit();
            this.grpProcessVariable.ResumeLayout(false);
            this.grpProcessVariable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAlpha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLowerLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpperLimit)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.GroupBox grpOtherTags;
        private NationalInstruments.UI.WindowsForms.NumericEdit numSimSetpoint;
        private System.Windows.Forms.GroupBox grpProcessVariable;
        private System.Windows.Forms.NumericUpDown numSimRandomNumber;
        private System.Windows.Forms.NumericUpDown numSimIoError;
        private NationalInstruments.UI.WindowsForms.NumericEdit numSimControlSignal;
        private System.Windows.Forms.Label lblRandomNumber;
        private System.Windows.Forms.Label lblIoError;
        private System.Windows.Forms.Label lblControlValue;
        private NationalInstruments.UI.WindowsForms.NumericEdit numSimulatedPV;
        private System.Windows.Forms.Label lblSimValue;
        private System.Windows.Forms.Label lblRandomNumberStatus;
        private System.Windows.Forms.TextBox txtRandomNumberStatus;
        private System.Windows.Forms.Label lblIoErrorStatus;
        private System.Windows.Forms.TextBox txtIOStatus;
        private System.Windows.Forms.Label lblSimulatedProcessVariable;
        private System.Windows.Forms.TextBox txtSimPVStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtControlSignalStatus;
        private System.Windows.Forms.Label lblSetpointStatus;
        private System.Windows.Forms.TextBox txtSetpointStatus;
        private System.Windows.Forms.Label lblPVStatus;
        private System.Windows.Forms.TextBox txtPVStatus;
        private System.Windows.Forms.Label lblAlpha;
        private NationalInstruments.UI.WindowsForms.NumericEdit numAlpha;
        private NationalInstruments.UI.WindowsForms.NumericEdit numLowerLimit;
        private NationalInstruments.UI.WindowsForms.NumericEdit numUpperLimit;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox txtCurrentSetpoint;
        private System.Windows.Forms.Button btnSaveHistory;
    }
}

