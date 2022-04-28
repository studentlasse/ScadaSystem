
namespace Simulation
{
    partial class ControlSystem
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.txtSimProcessValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chartMeasurementData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txtKp = new System.Windows.Forms.TextBox();
            this.txtTi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRealProcessValue = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtOpcStatus = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbUseDaq = new System.Windows.Forms.CheckBox();
            this.txtIoStatus = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbAuto = new System.Windows.Forms.CheckBox();
            this.numControlValue = new System.Windows.Forms.NumericUpDown();
            this.numR = new System.Windows.Forms.NumericUpDown();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtOPCServer = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chartMeasurementData)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numControlValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numR)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSimProcessValue
            // 
            this.txtSimProcessValue.Enabled = false;
            this.txtSimProcessValue.Location = new System.Drawing.Point(9, 211);
            this.txtSimProcessValue.Name = "txtSimProcessValue";
            this.txtSimProcessValue.Size = new System.Drawing.Size(144, 20);
            this.txtSimProcessValue.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Control Value:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Simulated Process Value [℃]:";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // chartMeasurementData
            // 
            chartArea4.Name = "ChartArea1";
            this.chartMeasurementData.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartMeasurementData.Legends.Add(legend4);
            this.chartMeasurementData.Location = new System.Drawing.Point(6, 6);
            this.chartMeasurementData.Name = "chartMeasurementData";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartMeasurementData.Series.Add(series4);
            this.chartMeasurementData.Size = new System.Drawing.Size(663, 417);
            this.chartMeasurementData.TabIndex = 4;
            this.chartMeasurementData.Text = "chartMeasurementData";
            // 
            // txtKp
            // 
            this.txtKp.Location = new System.Drawing.Point(9, 33);
            this.txtKp.Name = "txtKp";
            this.txtKp.Size = new System.Drawing.Size(100, 20);
            this.txtKp.TabIndex = 5;
            this.txtKp.TextChanged += new System.EventHandler(this.txtKp_TextChanged);
            // 
            // txtTi
            // 
            this.txtTi.Location = new System.Drawing.Point(9, 79);
            this.txtTi.Name = "txtTi";
            this.txtTi.Size = new System.Drawing.Size(100, 20);
            this.txtTi.TabIndex = 6;
            this.txtTi.TextChanged += new System.EventHandler(this.txtTi_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Kp:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ti:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Setpoint [℃]:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Real Process Value  [℃]:";
            // 
            // txtRealProcessValue
            // 
            this.txtRealProcessValue.Enabled = false;
            this.txtRealProcessValue.Location = new System.Drawing.Point(9, 163);
            this.txtRealProcessValue.Name = "txtRealProcessValue";
            this.txtRealProcessValue.Size = new System.Drawing.Size(144, 20);
            this.txtRealProcessValue.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtKp);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTi);
            this.groupBox1.Location = new System.Drawing.Point(20, 178);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 120);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PI Settings";
            // 
            // txtOpcStatus
            // 
            this.txtOpcStatus.Location = new System.Drawing.Point(9, 47);
            this.txtOpcStatus.Name = "txtOpcStatus";
            this.txtOpcStatus.Size = new System.Drawing.Size(100, 20);
            this.txtOpcStatus.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "OPC Client Status";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(653, 485);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 16;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(784, 485);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 17;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(851, 455);
            this.tabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.chartMeasurementData);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(843, 429);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Plot";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbUseDaq);
            this.groupBox2.Controls.Add(this.txtIoStatus);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cbAuto);
            this.groupBox2.Controls.Add(this.numControlValue);
            this.groupBox2.Controls.Add(this.numR);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtSimProcessValue);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtRealProcessValue);
            this.groupBox2.Location = new System.Drawing.Point(675, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(162, 346);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Control Data";
            // 
            // cbUseDaq
            // 
            this.cbUseDaq.AutoSize = true;
            this.cbUseDaq.Location = new System.Drawing.Point(9, 65);
            this.cbUseDaq.Name = "cbUseDaq";
            this.cbUseDaq.Size = new System.Drawing.Size(68, 17);
            this.cbUseDaq.TabIndex = 23;
            this.cbUseDaq.Text = "Use Daq";
            this.cbUseDaq.UseVisualStyleBackColor = true;
            // 
            // txtIoStatus
            // 
            this.txtIoStatus.Location = new System.Drawing.Point(9, 312);
            this.txtIoStatus.Name = "txtIoStatus";
            this.txtIoStatus.Size = new System.Drawing.Size(144, 20);
            this.txtIoStatus.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 295);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "IO Status";
            // 
            // cbAuto
            // 
            this.cbAuto.AutoSize = true;
            this.cbAuto.Location = new System.Drawing.Point(9, 32);
            this.cbAuto.Name = "cbAuto";
            this.cbAuto.Size = new System.Drawing.Size(73, 17);
            this.cbAuto.TabIndex = 20;
            this.cbAuto.Text = "Automatic";
            this.cbAuto.UseVisualStyleBackColor = true;
            // 
            // numControlValue
            // 
            this.numControlValue.DecimalPlaces = 2;
            this.numControlValue.Enabled = false;
            this.numControlValue.Location = new System.Drawing.Point(9, 259);
            this.numControlValue.Name = "numControlValue";
            this.numControlValue.Size = new System.Drawing.Size(144, 20);
            this.numControlValue.TabIndex = 14;
            this.numControlValue.ValueChanged += new System.EventHandler(this.numControlValue_ValueChanged);
            // 
            // numR
            // 
            this.numR.DecimalPlaces = 2;
            this.numR.Location = new System.Drawing.Point(9, 118);
            this.numR.Name = "numR";
            this.numR.Size = new System.Drawing.Size(144, 20);
            this.numR.TabIndex = 13;
            this.numR.ValueChanged += new System.EventHandler(this.numR_ValueChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(843, 429);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Config";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtOpcStatus);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtOPCServer);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(20, 38);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(284, 134);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "OPC Server";
            // 
            // txtOPCServer
            // 
            this.txtOPCServer.Location = new System.Drawing.Point(9, 98);
            this.txtOPCServer.Name = "txtOPCServer";
            this.txtOPCServer.Size = new System.Drawing.Size(265, 20);
            this.txtOPCServer.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "OPC Server Adress";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // ControlSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 525);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Name = "ControlSystem";
            this.Text = "ControlSystem";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.chartMeasurementData)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numControlValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numR)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtSimProcessValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMeasurementData;
        private System.Windows.Forms.TextBox txtKp;
        private System.Windows.Forms.TextBox txtTi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRealProcessValue;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtOpcStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtOPCServer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown numR;
        private System.Windows.Forms.CheckBox cbAuto;
        private System.Windows.Forms.NumericUpDown numControlValue;
        private System.Windows.Forms.TextBox txtIoStatus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox cbUseDaq;
        private System.Windows.Forms.Timer timer2;
    }
}

