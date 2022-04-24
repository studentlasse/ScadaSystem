
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblTagQuality = new System.Windows.Forms.Label();
            this.txtTagQuality = new System.Windows.Forms.TextBox();
            this.lblTagStatus = new System.Windows.Forms.Label();
            this.txtTagStatus = new System.Windows.Forms.TextBox();
            this.lblMode = new System.Windows.Forms.Label();
            this.txtMode = new System.Windows.Forms.TextBox();
            this.lblCurrTemp = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtServerEndpoint = new System.Windows.Forms.TextBox();
            this.numInterval = new System.Windows.Forms.NumericUpDown();
            this.lblInterval = new System.Windows.Forms.Label();
            this.chkRunSimulator = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.chkRunFilter = new System.Windows.Forms.CheckBox();
            this.txtUpperLimit = new System.Windows.Forms.TextBox();
            this.txtAlpha = new System.Windows.Forms.TextBox();
            this.txtLowerLimit = new System.Windows.Forms.TextBox();
            this.lblAlpha = new System.Windows.Forms.Label();
            this.lblLowerLimit = new System.Windows.Forms.Label();
            this.lblUpperLimit = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMeasurements)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numInterval)).BeginInit();
            this.tabPage3.SuspendLayout();
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
            this.tabPage1.Controls.Add(this.lblTagQuality);
            this.tabPage1.Controls.Add(this.txtTagQuality);
            this.tabPage1.Controls.Add(this.lblTagStatus);
            this.tabPage1.Controls.Add(this.txtTagStatus);
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
            // lblTagQuality
            // 
            this.lblTagQuality.AutoSize = true;
            this.lblTagQuality.Location = new System.Drawing.Point(792, 342);
            this.lblTagQuality.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTagQuality.Name = "lblTagQuality";
            this.lblTagQuality.Size = new System.Drawing.Size(58, 13);
            this.lblTagQuality.TabIndex = 15;
            this.lblTagQuality.Text = "TagQuality";
            // 
            // txtTagQuality
            // 
            this.txtTagQuality.Enabled = false;
            this.txtTagQuality.Location = new System.Drawing.Point(795, 358);
            this.txtTagQuality.Name = "txtTagQuality";
            this.txtTagQuality.Size = new System.Drawing.Size(100, 20);
            this.txtTagQuality.TabIndex = 14;
            // 
            // lblTagStatus
            // 
            this.lblTagStatus.AutoSize = true;
            this.lblTagStatus.Location = new System.Drawing.Point(656, 342);
            this.lblTagStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTagStatus.Name = "lblTagStatus";
            this.lblTagStatus.Size = new System.Drawing.Size(56, 13);
            this.lblTagStatus.TabIndex = 13;
            this.lblTagStatus.Text = "TagStatus";
            // 
            // txtTagStatus
            // 
            this.txtTagStatus.Enabled = false;
            this.txtTagStatus.Location = new System.Drawing.Point(659, 358);
            this.txtTagStatus.Name = "txtTagStatus";
            this.txtTagStatus.Size = new System.Drawing.Size(100, 20);
            this.txtTagStatus.TabIndex = 12;
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Location = new System.Drawing.Point(525, 342);
            this.lblMode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(34, 13);
            this.lblMode.TabIndex = 11;
            this.lblMode.Text = "Mode";
            // 
            // txtMode
            // 
            this.txtMode.Enabled = false;
            this.txtMode.Location = new System.Drawing.Point(528, 358);
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
            this.Column4});
            this.dataGridView.Location = new System.Drawing.Point(28, 325);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView.Size = new System.Drawing.Size(443, 206);
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
            this.Column2.HeaderText = "Temperature [°C]";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "TagStatus";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "TagQuality";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // chartMeasurements
            // 
            chartArea2.Name = "ChartArea1";
            this.chartMeasurements.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.chartMeasurements.Legends.Add(legend2);
            this.chartMeasurements.Location = new System.Drawing.Point(28, 48);
            this.chartMeasurements.Margin = new System.Windows.Forms.Padding(2);
            this.chartMeasurements.Name = "chartMeasurements";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartMeasurements.Series.Add(series2);
            this.chartMeasurements.Size = new System.Drawing.Size(731, 260);
            this.chartMeasurements.TabIndex = 0;
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
            this.groupBox1.Text = "Statistics";
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
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.chkRunFilter);
            this.tabPage3.Controls.Add(this.txtUpperLimit);
            this.tabPage3.Controls.Add(this.txtAlpha);
            this.tabPage3.Controls.Add(this.txtLowerLimit);
            this.tabPage3.Controls.Add(this.lblAlpha);
            this.tabPage3.Controls.Add(this.lblLowerLimit);
            this.tabPage3.Controls.Add(this.lblUpperLimit);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(963, 556);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Simulator settings";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(305, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(567, 52);
            this.label3.TabIndex = 7;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // chkRunFilter
            // 
            this.chkRunFilter.AutoSize = true;
            this.chkRunFilter.Location = new System.Drawing.Point(20, 155);
            this.chkRunFilter.Margin = new System.Windows.Forms.Padding(2);
            this.chkRunFilter.Name = "chkRunFilter";
            this.chkRunFilter.Size = new System.Drawing.Size(68, 17);
            this.chkRunFilter.TabIndex = 6;
            this.chkRunFilter.Text = "Run filter";
            this.chkRunFilter.UseVisualStyleBackColor = true;
            this.chkRunFilter.CheckedChanged += new System.EventHandler(this.chkRunFilter_CheckedChanged);
            // 
            // txtUpperLimit
            // 
            this.txtUpperLimit.Location = new System.Drawing.Point(20, 32);
            this.txtUpperLimit.Margin = new System.Windows.Forms.Padding(2);
            this.txtUpperLimit.Name = "txtUpperLimit";
            this.txtUpperLimit.Size = new System.Drawing.Size(76, 20);
            this.txtUpperLimit.TabIndex = 5;
            this.txtUpperLimit.TextChanged += new System.EventHandler(this.txtUpperLimit_TextChanged);
            // 
            // txtAlpha
            // 
            this.txtAlpha.Location = new System.Drawing.Point(20, 117);
            this.txtAlpha.Margin = new System.Windows.Forms.Padding(2);
            this.txtAlpha.Name = "txtAlpha";
            this.txtAlpha.Size = new System.Drawing.Size(76, 20);
            this.txtAlpha.TabIndex = 4;
            this.txtAlpha.TextChanged += new System.EventHandler(this.txtAlpha_TextChanged);
            // 
            // txtLowerLimit
            // 
            this.txtLowerLimit.Location = new System.Drawing.Point(20, 74);
            this.txtLowerLimit.Margin = new System.Windows.Forms.Padding(2);
            this.txtLowerLimit.Name = "txtLowerLimit";
            this.txtLowerLimit.Size = new System.Drawing.Size(76, 20);
            this.txtLowerLimit.TabIndex = 3;
            this.txtLowerLimit.TextChanged += new System.EventHandler(this.txtLowerLimit_TextChanged);
            // 
            // lblAlpha
            // 
            this.lblAlpha.AutoSize = true;
            this.lblAlpha.Location = new System.Drawing.Point(18, 102);
            this.lblAlpha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAlpha.Name = "lblAlpha";
            this.lblAlpha.Size = new System.Drawing.Size(34, 13);
            this.lblAlpha.TabIndex = 2;
            this.lblAlpha.Text = "Alpha";
            // 
            // lblLowerLimit
            // 
            this.lblLowerLimit.AutoSize = true;
            this.lblLowerLimit.Location = new System.Drawing.Point(18, 59);
            this.lblLowerLimit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLowerLimit.Name = "lblLowerLimit";
            this.lblLowerLimit.Size = new System.Drawing.Size(60, 13);
            this.lblLowerLimit.TabIndex = 1;
            this.lblLowerLimit.Text = "Lower Limit";
            // 
            // lblUpperLimit
            // 
            this.lblUpperLimit.AutoSize = true;
            this.lblUpperLimit.Location = new System.Drawing.Point(18, 16);
            this.lblUpperLimit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUpperLimit.Name = "lblUpperLimit";
            this.lblUpperLimit.Size = new System.Drawing.Size(60, 13);
            this.lblUpperLimit.TabIndex = 0;
            this.lblUpperLimit.Text = "Upper Limit";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
        private System.Windows.Forms.TextBox txtUpperLimit;
        private System.Windows.Forms.TextBox txtAlpha;
        private System.Windows.Forms.TextBox txtLowerLimit;
        private System.Windows.Forms.Label lblAlpha;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblCurrTemp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtServerEndpoint;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.TextBox txtMode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTagQuality;
        private System.Windows.Forms.TextBox txtTagQuality;
        private System.Windows.Forms.Label lblTagStatus;
        private System.Windows.Forms.TextBox txtTagStatus;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
    }
}

