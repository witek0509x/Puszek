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
            Syncfusion.Windows.Forms.Chart.ChartSeries chartSeries1 = new Syncfusion.Windows.Forms.Chart.ChartSeries();
            Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo chartCustomShapeInfo1 = new Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo();
            Syncfusion.Windows.Forms.Chart.ChartLineInfo chartLineInfo1 = new Syncfusion.Windows.Forms.Chart.ChartLineInfo();
            Syncfusion.Windows.Forms.Chart.ChartSeries chartSeries2 = new Syncfusion.Windows.Forms.Chart.ChartSeries();
            Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo chartCustomShapeInfo2 = new Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo();
            Syncfusion.Windows.Forms.Chart.ChartSeries chartSeries3 = new Syncfusion.Windows.Forms.Chart.ChartSeries();
            Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo chartCustomShapeInfo3 = new Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chartControl1 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.Temperature1Checkbox = new System.Windows.Forms.CheckBox();
            this.Temperature2CheckBox = new System.Windows.Forms.CheckBox();
            this.PressureCheckbox = new System.Windows.Forms.CheckBox();
            this.HigroscopyCheckbox = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBox6);
            this.panel1.Controls.Add(this.PressureCheckbox);
            this.panel1.Controls.Add(this.checkBox5);
            this.panel1.Controls.Add(this.Temperature2CheckBox);
            this.panel1.Controls.Add(this.HigroscopyCheckbox);
            this.panel1.Controls.Add(this.Temperature1Checkbox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(876, 36);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chartControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(876, 333);
            this.panel2.TabIndex = 1;
            // 
            // chartControl1
            // 
            this.chartControl1.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            this.chartControl1.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.chartControl1.ChartArea.CursorReDraw = false;
            this.chartControl1.DataSourceName = "[none]";
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.IsWindowLess = false;
            // 
            // 
            // 
            this.chartControl1.Legend.Location = new System.Drawing.Point(765, 75);
            this.chartControl1.Localize = null;
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.PrimaryXAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.chartControl1.PrimaryXAxis.Margin = true;
            this.chartControl1.PrimaryXAxis.TitleColor = System.Drawing.SystemColors.ControlText;
            this.chartControl1.PrimaryYAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.chartControl1.PrimaryYAxis.Margin = true;
            this.chartControl1.PrimaryYAxis.TitleColor = System.Drawing.SystemColors.ControlText;
            chartSeries1.FancyToolTip.ResizeInsideSymbol = true;
            chartSeries1.Name = "Default0";
            chartSeries1.Resolution = 0D;
            chartSeries1.StackingGroup = "Default Group";
            chartSeries1.Style.AltTagFormat = "";
            chartSeries1.Style.Border.Width = 2F;
            chartSeries1.Style.DisplayShadow = true;
            chartSeries1.Style.DrawTextShape = false;
            chartLineInfo1.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;
            chartLineInfo1.Color = System.Drawing.SystemColors.ControlText;
            chartLineInfo1.DashPattern = null;
            chartLineInfo1.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            chartLineInfo1.Width = 1F;
            chartCustomShapeInfo1.Border = chartLineInfo1;
            chartCustomShapeInfo1.Color = System.Drawing.SystemColors.HighlightText;
            chartCustomShapeInfo1.Type = Syncfusion.Windows.Forms.Chart.ChartCustomShape.Square;
            chartSeries1.Style.TextShape = chartCustomShapeInfo1;
            chartSeries1.Text = "Default0";
            chartSeries1.Type = Syncfusion.Windows.Forms.Chart.ChartSeriesType.Line;
            chartSeries2.FancyToolTip.ResizeInsideSymbol = true;
            chartSeries2.Name = "Default1";
            chartSeries2.Resolution = 0D;
            chartSeries2.StackingGroup = "Default Group";
            chartSeries2.Style.AltTagFormat = "";
            chartSeries2.Style.Border.Width = 2F;
            chartSeries2.Style.DisplayShadow = true;
            chartSeries2.Style.DrawTextShape = false;
            chartCustomShapeInfo2.Border = chartLineInfo1;
            chartCustomShapeInfo2.Color = System.Drawing.SystemColors.HighlightText;
            chartCustomShapeInfo2.Type = Syncfusion.Windows.Forms.Chart.ChartCustomShape.Square;
            chartSeries2.Style.TextShape = chartCustomShapeInfo2;
            chartSeries2.Text = "Default1";
            chartSeries2.Type = Syncfusion.Windows.Forms.Chart.ChartSeriesType.Line;
            chartSeries3.FancyToolTip.ResizeInsideSymbol = true;
            chartSeries3.Name = "Default2";
            chartSeries3.Resolution = 0D;
            chartSeries3.StackingGroup = "Default Group";
            chartSeries3.Style.AltTagFormat = "";
            chartSeries3.Style.Border.Width = 2F;
            chartSeries3.Style.DisplayShadow = true;
            chartSeries3.Style.DrawTextShape = false;
            chartCustomShapeInfo3.Border = chartLineInfo1;
            chartCustomShapeInfo3.Color = System.Drawing.SystemColors.HighlightText;
            chartCustomShapeInfo3.Type = Syncfusion.Windows.Forms.Chart.ChartCustomShape.Square;
            chartSeries3.Style.TextShape = chartCustomShapeInfo3;
            chartSeries3.Text = "Default2";
            chartSeries3.Type = Syncfusion.Windows.Forms.Chart.ChartSeriesType.Line;
            this.chartControl1.Series.Add(chartSeries1);
            this.chartControl1.Series.Add(chartSeries2);
            this.chartControl1.Series.Add(chartSeries3);
            this.chartControl1.Size = new System.Drawing.Size(876, 333);
            this.chartControl1.TabIndex = 1;
            this.chartControl1.Text = "chartControl1";
            // 
            // 
            // 
            this.chartControl1.Title.Name = "Default";
            this.chartControl1.Titles.Add(this.chartControl1.Title);
            // 
            // Temperature1Checkbox
            // 
            this.Temperature1Checkbox.AutoSize = true;
            this.Temperature1Checkbox.Location = new System.Drawing.Point(12, 12);
            this.Temperature1Checkbox.Name = "Temperature1Checkbox";
            this.Temperature1Checkbox.Size = new System.Drawing.Size(95, 17);
            this.Temperature1Checkbox.TabIndex = 0;
            this.Temperature1Checkbox.Text = "Temperature 1";
            this.Temperature1Checkbox.UseVisualStyleBackColor = true;
            // 
            // Temperature2CheckBox
            // 
            this.Temperature2CheckBox.AutoSize = true;
            this.Temperature2CheckBox.Location = new System.Drawing.Point(113, 12);
            this.Temperature2CheckBox.Name = "Temperature2CheckBox";
            this.Temperature2CheckBox.Size = new System.Drawing.Size(95, 17);
            this.Temperature2CheckBox.TabIndex = 0;
            this.Temperature2CheckBox.Text = "Temperature 2";
            this.Temperature2CheckBox.UseVisualStyleBackColor = true;
            // 
            // PressureCheckbox
            // 
            this.PressureCheckbox.AutoSize = true;
            this.PressureCheckbox.Location = new System.Drawing.Point(214, 12);
            this.PressureCheckbox.Name = "PressureCheckbox";
            this.PressureCheckbox.Size = new System.Drawing.Size(67, 17);
            this.PressureCheckbox.TabIndex = 0;
            this.PressureCheckbox.Text = "Pressure";
            this.PressureCheckbox.UseVisualStyleBackColor = true;
            // 
            // HigroscopyCheckbox
            // 
            this.HigroscopyCheckbox.AutoSize = true;
            this.HigroscopyCheckbox.Location = new System.Drawing.Point(300, 12);
            this.HigroscopyCheckbox.Name = "HigroscopyCheckbox";
            this.HigroscopyCheckbox.Size = new System.Drawing.Size(79, 17);
            this.HigroscopyCheckbox.TabIndex = 0;
            this.HigroscopyCheckbox.Text = "Higroscopy";
            this.HigroscopyCheckbox.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(386, 12);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(80, 17);
            this.checkBox5.TabIndex = 0;
            this.checkBox5.Text = "checkBox1";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(472, 12);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(80, 17);
            this.checkBox6.TabIndex = 0;
            this.checkBox6.Text = "checkBox1";
            this.checkBox6.UseVisualStyleBackColor = true;
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox PressureCheckbox;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox Temperature2CheckBox;
        private System.Windows.Forms.CheckBox HigroscopyCheckbox;
        private System.Windows.Forms.CheckBox Temperature1Checkbox;
        private System.Windows.Forms.Panel panel2;
        private Syncfusion.Windows.Forms.Chart.ChartControl chartControl1;
    }
}