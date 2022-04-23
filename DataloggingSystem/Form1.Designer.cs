
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCurrent = new System.Windows.Forms.TextBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAvg = new System.Windows.Forms.Label();
            this.txtAvg = new System.Windows.Forms.TextBox();
            this.lblMaxTemperature = new System.Windows.Forms.Label();
            this.txtMaxMeasurement = new System.Windows.Forms.TextBox();
            this.lblMinMeasurement = new System.Windows.Forms.Label();
            this.txtMinMeasurement = new System.Windows.Forms.TextBox();
            this.chartMeasurements = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.chkRunFilter = new System.Windows.Forms.CheckBox();
            this.txtUpperLimit = new System.Windows.Forms.TextBox();
            this.txtAlpha = new System.Windows.Forms.TextBox();
            this.txtLowerLimit = new System.Windows.Forms.TextBox();
            this.lblAlpha = new System.Windows.Forms.Label();
            this.lblLowerLimit = new System.Windows.Forms.Label();
            this.lblUpperLimit = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMeasurements)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(2, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(992, 549);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtCurrent);
            this.tabPage1.Controls.Add(this.btnStop);
            this.tabPage1.Controls.Add(this.btnStart);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.chartMeasurements);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(984, 520);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Logging";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(24, 341);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(527, 156);
            this.dataGridView.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(787, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Current measuerement";
            // 
            // txtCurrent
            // 
            this.txtCurrent.Enabled = false;
            this.txtCurrent.Location = new System.Drawing.Point(790, 25);
            this.txtCurrent.Name = "txtCurrent";
            this.txtCurrent.Size = new System.Drawing.Size(173, 22);
            this.txtCurrent.TabIndex = 3;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(875, 341);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(794, 341);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAvg);
            this.groupBox1.Controls.Add(this.txtAvg);
            this.groupBox1.Controls.Add(this.lblMaxTemperature);
            this.groupBox1.Controls.Add(this.txtMaxMeasurement);
            this.groupBox1.Controls.Add(this.lblMinMeasurement);
            this.groupBox1.Controls.Add(this.txtMinMeasurement);
            this.groupBox1.Location = new System.Drawing.Point(790, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 251);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Statistics";
            // 
            // lblAvg
            // 
            this.lblAvg.AutoSize = true;
            this.lblAvg.Location = new System.Drawing.Point(25, 173);
            this.lblAvg.Name = "lblAvg";
            this.lblAvg.Size = new System.Drawing.Size(60, 16);
            this.lblAvg.TabIndex = 9;
            this.lblAvg.Text = "Average";
            // 
            // txtAvg
            // 
            this.txtAvg.Enabled = false;
            this.txtAvg.Location = new System.Drawing.Point(25, 192);
            this.txtAvg.Name = "txtAvg";
            this.txtAvg.Size = new System.Drawing.Size(98, 22);
            this.txtAvg.TabIndex = 8;
            // 
            // lblMaxTemperature
            // 
            this.lblMaxTemperature.AutoSize = true;
            this.lblMaxTemperature.Location = new System.Drawing.Point(25, 105);
            this.lblMaxTemperature.Name = "lblMaxTemperature";
            this.lblMaxTemperature.Size = new System.Drawing.Size(118, 16);
            this.lblMaxTemperature.TabIndex = 7;
            this.lblMaxTemperature.Text = "Max Measurement";
            // 
            // txtMaxMeasurement
            // 
            this.txtMaxMeasurement.Enabled = false;
            this.txtMaxMeasurement.Location = new System.Drawing.Point(25, 124);
            this.txtMaxMeasurement.Name = "txtMaxMeasurement";
            this.txtMaxMeasurement.Size = new System.Drawing.Size(98, 22);
            this.txtMaxMeasurement.TabIndex = 6;
            // 
            // lblMinMeasurement
            // 
            this.lblMinMeasurement.AutoSize = true;
            this.lblMinMeasurement.Location = new System.Drawing.Point(25, 44);
            this.lblMinMeasurement.Name = "lblMinMeasurement";
            this.lblMinMeasurement.Size = new System.Drawing.Size(114, 16);
            this.lblMinMeasurement.TabIndex = 5;
            this.lblMinMeasurement.Text = "Min Measurement";
            // 
            // txtMinMeasurement
            // 
            this.txtMinMeasurement.Enabled = false;
            this.txtMinMeasurement.Location = new System.Drawing.Point(25, 63);
            this.txtMinMeasurement.Name = "txtMinMeasurement";
            this.txtMinMeasurement.Size = new System.Drawing.Size(98, 22);
            this.txtMinMeasurement.TabIndex = 4;
            // 
            // chartMeasurements
            // 
            chartArea1.Name = "ChartArea1";
            this.chartMeasurements.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chartMeasurements.Legends.Add(legend1);
            this.chartMeasurements.Location = new System.Drawing.Point(6, 6);
            this.chartMeasurements.Name = "chartMeasurements";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartMeasurements.Series.Add(series1);
            this.chartMeasurements.Size = new System.Drawing.Size(759, 320);
            this.chartMeasurements.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(984, 520);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Configuration";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.chkRunFilter);
            this.tabPage3.Controls.Add(this.txtUpperLimit);
            this.tabPage3.Controls.Add(this.txtAlpha);
            this.tabPage3.Controls.Add(this.txtLowerLimit);
            this.tabPage3.Controls.Add(this.lblAlpha);
            this.tabPage3.Controls.Add(this.lblLowerLimit);
            this.tabPage3.Controls.Add(this.lblUpperLimit);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(984, 520);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Simulator settings";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // chkRunFilter
            // 
            this.chkRunFilter.AutoSize = true;
            this.chkRunFilter.Location = new System.Drawing.Point(27, 183);
            this.chkRunFilter.Name = "chkRunFilter";
            this.chkRunFilter.Size = new System.Drawing.Size(78, 20);
            this.chkRunFilter.TabIndex = 6;
            this.chkRunFilter.Text = "Run filter";
            this.chkRunFilter.UseVisualStyleBackColor = true;
            this.chkRunFilter.CheckedChanged += new System.EventHandler(this.chkRunFilter_CheckedChanged);
            // 
            // txtUpperLimit
            // 
            this.txtUpperLimit.Location = new System.Drawing.Point(27, 39);
            this.txtUpperLimit.Name = "txtUpperLimit";
            this.txtUpperLimit.Size = new System.Drawing.Size(100, 22);
            this.txtUpperLimit.TabIndex = 5;
            this.txtUpperLimit.TextChanged += new System.EventHandler(this.txtUpperLimit_TextChanged);
            // 
            // txtAlpha
            // 
            this.txtAlpha.Location = new System.Drawing.Point(27, 137);
            this.txtAlpha.Name = "txtAlpha";
            this.txtAlpha.Size = new System.Drawing.Size(100, 22);
            this.txtAlpha.TabIndex = 4;
            this.txtAlpha.TextChanged += new System.EventHandler(this.txtAlpha_TextChanged);
            // 
            // txtLowerLimit
            // 
            this.txtLowerLimit.Location = new System.Drawing.Point(27, 85);
            this.txtLowerLimit.Name = "txtLowerLimit";
            this.txtLowerLimit.Size = new System.Drawing.Size(100, 22);
            this.txtLowerLimit.TabIndex = 3;
            this.txtLowerLimit.TextChanged += new System.EventHandler(this.txtLowerLimit_TextChanged);
            // 
            // lblAlpha
            // 
            this.lblAlpha.AutoSize = true;
            this.lblAlpha.Location = new System.Drawing.Point(24, 118);
            this.lblAlpha.Name = "lblAlpha";
            this.lblAlpha.Size = new System.Drawing.Size(43, 16);
            this.lblAlpha.TabIndex = 2;
            this.lblAlpha.Text = "Alpha";
            // 
            // lblLowerLimit
            // 
            this.lblLowerLimit.AutoSize = true;
            this.lblLowerLimit.Location = new System.Drawing.Point(24, 66);
            this.lblLowerLimit.Name = "lblLowerLimit";
            this.lblLowerLimit.Size = new System.Drawing.Size(74, 16);
            this.lblLowerLimit.TabIndex = 1;
            this.lblLowerLimit.Text = "Lower Limit";
            // 
            // lblUpperLimit
            // 
            this.lblUpperLimit.AutoSize = true;
            this.lblUpperLimit.Location = new System.Drawing.Point(24, 20);
            this.lblUpperLimit.Name = "lblUpperLimit";
            this.lblUpperLimit.Size = new System.Drawing.Size(76, 16);
            this.lblUpperLimit.TabIndex = 0;
            this.lblUpperLimit.Text = "Upper Limit";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 557);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Datalogger";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMeasurements)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
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
    }
}

