
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.txtControlValue = new System.Windows.Forms.TextBox();
            this.txtSimProcessValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chartMeasurementData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txtKp = new System.Windows.Forms.TextBox();
            this.txtTi = new System.Windows.Forms.TextBox();
            this.txtR = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRealProcessValue = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtOpcStatus = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartMeasurementData)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtControlValue
            // 
            this.txtControlValue.Enabled = false;
            this.txtControlValue.Location = new System.Drawing.Point(772, 278);
            this.txtControlValue.Name = "txtControlValue";
            this.txtControlValue.Size = new System.Drawing.Size(100, 20);
            this.txtControlValue.TabIndex = 0;
            // 
            // txtSimProcessValue
            // 
            this.txtSimProcessValue.Enabled = false;
            this.txtSimProcessValue.Location = new System.Drawing.Point(772, 223);
            this.txtSimProcessValue.Name = "txtSimProcessValue";
            this.txtSimProcessValue.Size = new System.Drawing.Size(100, 20);
            this.txtSimProcessValue.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(772, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Control Value:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(772, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Simulated Process Value:";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // chartMeasurementData
            // 
            chartArea1.Name = "ChartArea1";
            this.chartMeasurementData.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartMeasurementData.Legends.Add(legend1);
            this.chartMeasurementData.Location = new System.Drawing.Point(35, 65);
            this.chartMeasurementData.Name = "chartMeasurementData";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartMeasurementData.Series.Add(series1);
            this.chartMeasurementData.Size = new System.Drawing.Size(699, 386);
            this.chartMeasurementData.TabIndex = 4;
            this.chartMeasurementData.Text = "chartMeasurementData";
            // 
            // txtKp
            // 
            this.txtKp.Location = new System.Drawing.Point(6, 37);
            this.txtKp.Name = "txtKp";
            this.txtKp.Size = new System.Drawing.Size(100, 20);
            this.txtKp.TabIndex = 5;
            this.txtKp.TextChanged += new System.EventHandler(this.txtKp_TextChanged);
            // 
            // txtTi
            // 
            this.txtTi.Location = new System.Drawing.Point(6, 79);
            this.txtTi.Name = "txtTi";
            this.txtTi.Size = new System.Drawing.Size(100, 20);
            this.txtTi.TabIndex = 6;
            this.txtTi.TextChanged += new System.EventHandler(this.txtTi_TextChanged);
            // 
            // txtR
            // 
            this.txtR.Location = new System.Drawing.Point(772, 115);
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(100, 20);
            this.txtR.TabIndex = 7;
            this.txtR.TextChanged += new System.EventHandler(this.txtR_TextChanged);
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
            this.label5.Location = new System.Drawing.Point(769, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Setpoint:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(772, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Real Process Value:";
            // 
            // txtRealProcessValue
            // 
            this.txtRealProcessValue.Enabled = false;
            this.txtRealProcessValue.Location = new System.Drawing.Point(772, 168);
            this.txtRealProcessValue.Name = "txtRealProcessValue";
            this.txtRealProcessValue.Size = new System.Drawing.Size(100, 20);
            this.txtRealProcessValue.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtKp);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTi);
            this.groupBox1.Location = new System.Drawing.Point(766, 331);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 120);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PI Settings";
            // 
            // txtOpcStatus
            // 
            this.txtOpcStatus.Location = new System.Drawing.Point(772, 65);
            this.txtOpcStatus.Name = "txtOpcStatus";
            this.txtOpcStatus.Size = new System.Drawing.Size(100, 20);
            this.txtOpcStatus.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(772, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "OPC Client Status";
            // 
            // ControlSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 565);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtOpcStatus);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtRealProcessValue);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtR);
            this.Controls.Add(this.chartMeasurementData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSimProcessValue);
            this.Controls.Add(this.txtControlValue);
            this.Name = "ControlSystem";
            this.Text = "ControlSystem";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.chartMeasurementData)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtControlValue;
        private System.Windows.Forms.TextBox txtSimProcessValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMeasurementData;
        private System.Windows.Forms.TextBox txtKp;
        private System.Windows.Forms.TextBox txtTi;
        private System.Windows.Forms.TextBox txtR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRealProcessValue;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtOpcStatus;
        private System.Windows.Forms.Label label7;
    }
}

