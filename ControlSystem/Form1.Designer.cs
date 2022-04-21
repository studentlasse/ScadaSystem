﻿
namespace Simulation
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
            ((System.ComponentModel.ISupportInitialize)(this.chartMeasurementData)).BeginInit();
            this.SuspendLayout();
            // 
            // txtControlValue
            // 
            this.txtControlValue.Enabled = false;
            this.txtControlValue.Location = new System.Drawing.Point(596, 58);
            this.txtControlValue.Name = "txtControlValue";
            this.txtControlValue.Size = new System.Drawing.Size(100, 20);
            this.txtControlValue.TabIndex = 0;
            // 
            // txtSimProcessValue
            // 
            this.txtSimProcessValue.Enabled = false;
            this.txtSimProcessValue.Location = new System.Drawing.Point(702, 58);
            this.txtSimProcessValue.Name = "txtSimProcessValue";
            this.txtSimProcessValue.Size = new System.Drawing.Size(100, 20);
            this.txtSimProcessValue.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(596, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Control Value:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(702, 40);
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
            chartArea2.Name = "ChartArea1";
            this.chartMeasurementData.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartMeasurementData.Legends.Add(legend2);
            this.chartMeasurementData.Location = new System.Drawing.Point(43, 143);
            this.chartMeasurementData.Name = "chartMeasurementData";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartMeasurementData.Series.Add(series2);
            this.chartMeasurementData.Size = new System.Drawing.Size(788, 398);
            this.chartMeasurementData.TabIndex = 4;
            this.chartMeasurementData.Text = "chartMeasurementData";
            // 
            // txtKp
            // 
            this.txtKp.Location = new System.Drawing.Point(43, 104);
            this.txtKp.Name = "txtKp";
            this.txtKp.Size = new System.Drawing.Size(100, 20);
            this.txtKp.TabIndex = 5;
            this.txtKp.TextChanged += new System.EventHandler(this.txtKp_TextChanged);
            // 
            // txtTi
            // 
            this.txtTi.Location = new System.Drawing.Point(159, 104);
            this.txtTi.Name = "txtTi";
            this.txtTi.Size = new System.Drawing.Size(100, 20);
            this.txtTi.TabIndex = 6;
            this.txtTi.TextChanged += new System.EventHandler(this.txtTi_TextChanged);
            // 
            // txtR
            // 
            this.txtR.Location = new System.Drawing.Point(275, 104);
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(100, 20);
            this.txtR.TabIndex = 7;
            this.txtR.TextChanged += new System.EventHandler(this.txtR_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Kp:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(156, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ti:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(272, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Setpoint:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(702, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Real Process Value:";
            // 
            // txtRealProcessValue
            // 
            this.txtRealProcessValue.Enabled = false;
            this.txtRealProcessValue.Location = new System.Drawing.Point(702, 104);
            this.txtRealProcessValue.Name = "txtRealProcessValue";
            this.txtRealProcessValue.Size = new System.Drawing.Size(100, 20);
            this.txtRealProcessValue.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 561);
            this.Controls.Add(this.txtRealProcessValue);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtR);
            this.Controls.Add(this.txtTi);
            this.Controls.Add(this.txtKp);
            this.Controls.Add(this.chartMeasurementData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSimProcessValue);
            this.Controls.Add(this.txtControlValue);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.chartMeasurementData)).EndInit();
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
    }
}

