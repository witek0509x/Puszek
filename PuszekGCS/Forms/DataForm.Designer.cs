namespace PuszekGCS.Forms
{
    partial class DataForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Temp1 = new System.Windows.Forms.RadioButton();
            this.Temp2 = new System.Windows.Forms.RadioButton();
            this.Press1 = new System.Windows.Forms.RadioButton();
            this.Press2 = new System.Windows.Forms.RadioButton();
            this.Gyrox = new System.Windows.Forms.RadioButton();
            this.gyroy = new System.Windows.Forms.RadioButton();
            this.gyroz = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gyroz);
            this.panel1.Controls.Add(this.gyroy);
            this.panel1.Controls.Add(this.Gyrox);
            this.panel1.Controls.Add(this.Press2);
            this.panel1.Controls.Add(this.Press1);
            this.panel1.Controls.Add(this.Temp2);
            this.panel1.Controls.Add(this.Temp1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(876, 36);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chart);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(876, 333);
            this.panel2.TabIndex = 1;
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(0, 0);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(876, 333);
            this.chart.TabIndex = 0;
            this.chart.Text = "Values";
            this.chart.Click += new System.EventHandler(this.chart_Click);
            // 
            // Temp1
            // 
            this.Temp1.AutoSize = true;
            this.Temp1.Checked = true;
            this.Temp1.Location = new System.Drawing.Point(13, 13);
            this.Temp1.Name = "Temp1";
            this.Temp1.Size = new System.Drawing.Size(94, 17);
            this.Temp1.TabIndex = 0;
            this.Temp1.TabStop = true;
            this.Temp1.Text = "Temperature 1";
            this.Temp1.UseVisualStyleBackColor = true;
            this.Temp1.CheckedChanged += new System.EventHandler(this.Temp1_CheckedChanged);
            // 
            // Temp2
            // 
            this.Temp2.AutoSize = true;
            this.Temp2.Location = new System.Drawing.Point(113, 13);
            this.Temp2.Name = "Temp2";
            this.Temp2.Size = new System.Drawing.Size(94, 17);
            this.Temp2.TabIndex = 0;
            this.Temp2.Text = "Temperature 2";
            this.Temp2.UseVisualStyleBackColor = true;
            this.Temp2.CheckedChanged += new System.EventHandler(this.Temp2_CheckedChanged);
            // 
            // Press1
            // 
            this.Press1.AutoSize = true;
            this.Press1.Location = new System.Drawing.Point(213, 12);
            this.Press1.Name = "Press1";
            this.Press1.Size = new System.Drawing.Size(75, 17);
            this.Press1.TabIndex = 0;
            this.Press1.Text = "Pressure 1";
            this.Press1.UseVisualStyleBackColor = true;
            this.Press1.CheckedChanged += new System.EventHandler(this.Press1_CheckedChanged);
            // 
            // Press2
            // 
            this.Press2.AutoSize = true;
            this.Press2.Location = new System.Drawing.Point(304, 12);
            this.Press2.Name = "Press2";
            this.Press2.Size = new System.Drawing.Size(75, 17);
            this.Press2.TabIndex = 0;
            this.Press2.Text = "Pressure 2";
            this.Press2.UseVisualStyleBackColor = true;
            this.Press2.CheckedChanged += new System.EventHandler(this.Press2_CheckedChanged);
            // 
            // Gyrox
            // 
            this.Gyrox.AutoSize = true;
            this.Gyrox.Location = new System.Drawing.Point(395, 12);
            this.Gyrox.Name = "Gyrox";
            this.Gyrox.Size = new System.Drawing.Size(84, 17);
            this.Gyrox.TabIndex = 0;
            this.Gyrox.Text = "Gyroscope x";
            this.Gyrox.UseVisualStyleBackColor = true;
            this.Gyrox.CheckedChanged += new System.EventHandler(this.Gyrox_CheckedChanged);
            // 
            // gyroy
            // 
            this.gyroy.AutoSize = true;
            this.gyroy.Location = new System.Drawing.Point(486, 12);
            this.gyroy.Name = "gyroy";
            this.gyroy.Size = new System.Drawing.Size(84, 17);
            this.gyroy.TabIndex = 0;
            this.gyroy.Text = "Gyroscope y";
            this.gyroy.UseVisualStyleBackColor = true;
            this.gyroy.CheckedChanged += new System.EventHandler(this.gyroy_CheckedChanged);
            // 
            // gyroz
            // 
            this.gyroz.AutoSize = true;
            this.gyroz.Location = new System.Drawing.Point(577, 12);
            this.gyroz.Name = "gyroz";
            this.gyroz.Size = new System.Drawing.Size(87, 17);
            this.gyroz.TabIndex = 0;
            this.gyroz.Text = "Gytroscope z";
            this.gyroz.UseVisualStyleBackColor = true;
            this.gyroz.CheckedChanged += new System.EventHandler(this.gyroz_CheckedChanged);
            // 
            // DataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 369);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "DataForm";
            this.Text = "DataForm";
            this.Load += new System.EventHandler(this.DataForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.RadioButton Gyrox;
        private System.Windows.Forms.RadioButton Press2;
        private System.Windows.Forms.RadioButton Press1;
        private System.Windows.Forms.RadioButton Temp2;
        private System.Windows.Forms.RadioButton Temp1;
        private System.Windows.Forms.RadioButton gyroz;
        private System.Windows.Forms.RadioButton gyroy;
    }
}