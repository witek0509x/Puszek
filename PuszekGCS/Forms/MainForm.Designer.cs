﻿namespace PuszekGCS
{
    partial class MainForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cammunicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PictureSpace = new System.Windows.Forms.Panel();
            this.ActualPicture = new System.Windows.Forms.PictureBox();
            this.RighPanel = new System.Windows.Forms.Panel();
            this.DataPanel = new System.Windows.Forms.Panel();
            this.ClockLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AltitudeNameLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.HigroscopyNameLabel = new System.Windows.Forms.Label();
            this.PressureNameLabel = new System.Windows.Forms.Label();
            this.TemperatureNameLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ConsolePanel = new System.Windows.Forms.Panel();
            this.ConsoleInput = new System.Windows.Forms.TextBox();
            this.ConsoleWindow = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.IPTitle = new System.Windows.Forms.Label();
            this.IPValue = new System.Windows.Forms.Label();
            this.PortTitle = new System.Windows.Forms.Label();
            this.PortValue = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.PictureSpace.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ActualPicture)).BeginInit();
            this.RighPanel.SuspendLayout();
            this.DataPanel.SuspendLayout();
            this.ConsolePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cammunicationToolStripMenuItem,
            this.logToolStripMenuItem,
            this.dataToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1468, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cammunicationToolStripMenuItem
            // 
            this.cammunicationToolStripMenuItem.Name = "cammunicationToolStripMenuItem";
            this.cammunicationToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.cammunicationToolStripMenuItem.Text = "Cammunication";
            this.cammunicationToolStripMenuItem.Click += new System.EventHandler(this.cammunicationToolStripMenuItem_Click);
            // 
            // logToolStripMenuItem
            // 
            this.logToolStripMenuItem.Name = "logToolStripMenuItem";
            this.logToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.logToolStripMenuItem.Text = "Log";
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.dataToolStripMenuItem.Text = "Data";
            // 
            // PictureSpace
            // 
            this.PictureSpace.Controls.Add(this.ActualPicture);
            this.PictureSpace.Dock = System.Windows.Forms.DockStyle.Left;
            this.PictureSpace.Location = new System.Drawing.Point(0, 24);
            this.PictureSpace.Name = "PictureSpace";
            this.PictureSpace.Size = new System.Drawing.Size(688, 649);
            this.PictureSpace.TabIndex = 1;
            // 
            // ActualPicture
            // 
            this.ActualPicture.Location = new System.Drawing.Point(34, 27);
            this.ActualPicture.Name = "ActualPicture";
            this.ActualPicture.Size = new System.Drawing.Size(611, 577);
            this.ActualPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ActualPicture.TabIndex = 0;
            this.ActualPicture.TabStop = false;
            // 
            // RighPanel
            // 
            this.RighPanel.Controls.Add(this.ConsolePanel);
            this.RighPanel.Controls.Add(this.DataPanel);
            this.RighPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RighPanel.Location = new System.Drawing.Point(688, 24);
            this.RighPanel.Name = "RighPanel";
            this.RighPanel.Size = new System.Drawing.Size(780, 649);
            this.RighPanel.TabIndex = 2;
            // 
            // DataPanel
            // 
            this.DataPanel.Controls.Add(this.panel1);
            this.DataPanel.Controls.Add(this.ClockLabel);
            this.DataPanel.Controls.Add(this.label6);
            this.DataPanel.Controls.Add(this.AltitudeNameLabel);
            this.DataPanel.Controls.Add(this.label4);
            this.DataPanel.Controls.Add(this.HigroscopyNameLabel);
            this.DataPanel.Controls.Add(this.PressureNameLabel);
            this.DataPanel.Controls.Add(this.TemperatureNameLabel);
            this.DataPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.DataPanel.Location = new System.Drawing.Point(0, 0);
            this.DataPanel.Name = "DataPanel";
            this.DataPanel.Size = new System.Drawing.Size(780, 419);
            this.DataPanel.TabIndex = 0;
            // 
            // ClockLabel
            // 
            this.ClockLabel.AutoSize = true;
            this.ClockLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClockLabel.Location = new System.Drawing.Point(603, 15);
            this.ClockLabel.Name = "ClockLabel";
            this.ClockLabel.Size = new System.Drawing.Size(165, 40);
            this.ClockLabel.TabIndex = 1;
            this.ClockLabel.Text = "00:00:00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(34, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "label1";
            // 
            // AltitudeNameLabel
            // 
            this.AltitudeNameLabel.AutoSize = true;
            this.AltitudeNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AltitudeNameLabel.Location = new System.Drawing.Point(34, 151);
            this.AltitudeNameLabel.Name = "AltitudeNameLabel";
            this.AltitudeNameLabel.Size = new System.Drawing.Size(76, 20);
            this.AltitudeNameLabel.TabIndex = 0;
            this.AltitudeNameLabel.Text = "Altitude:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(34, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "label1";
            // 
            // HigroscopyNameLabel
            // 
            this.HigroscopyNameLabel.AutoSize = true;
            this.HigroscopyNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HigroscopyNameLabel.Location = new System.Drawing.Point(34, 110);
            this.HigroscopyNameLabel.Name = "HigroscopyNameLabel";
            this.HigroscopyNameLabel.Size = new System.Drawing.Size(103, 20);
            this.HigroscopyNameLabel.TabIndex = 0;
            this.HigroscopyNameLabel.Text = "Higroscopy:";
            this.HigroscopyNameLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // PressureNameLabel
            // 
            this.PressureNameLabel.AutoSize = true;
            this.PressureNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PressureNameLabel.Location = new System.Drawing.Point(34, 73);
            this.PressureNameLabel.Name = "PressureNameLabel";
            this.PressureNameLabel.Size = new System.Drawing.Size(85, 20);
            this.PressureNameLabel.TabIndex = 0;
            this.PressureNameLabel.Text = "Pressure:";
            // 
            // TemperatureNameLabel
            // 
            this.TemperatureNameLabel.AutoSize = true;
            this.TemperatureNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TemperatureNameLabel.Location = new System.Drawing.Point(34, 37);
            this.TemperatureNameLabel.Name = "TemperatureNameLabel";
            this.TemperatureNameLabel.Size = new System.Drawing.Size(116, 20);
            this.TemperatureNameLabel.TabIndex = 0;
            this.TemperatureNameLabel.Text = "Temperature:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ConsolePanel
            // 
            this.ConsolePanel.Controls.Add(this.ConsoleWindow);
            this.ConsolePanel.Controls.Add(this.ConsoleInput);
            this.ConsolePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsolePanel.Location = new System.Drawing.Point(0, 419);
            this.ConsolePanel.Name = "ConsolePanel";
            this.ConsolePanel.Size = new System.Drawing.Size(780, 230);
            this.ConsolePanel.TabIndex = 1;
            // 
            // ConsoleInput
            // 
            this.ConsoleInput.BackColor = System.Drawing.SystemColors.MenuText;
            this.ConsoleInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.ConsoleInput.ForeColor = System.Drawing.SystemColors.Info;
            this.ConsoleInput.Location = new System.Drawing.Point(0, 0);
            this.ConsoleInput.Name = "ConsoleInput";
            this.ConsoleInput.Size = new System.Drawing.Size(780, 20);
            this.ConsoleInput.TabIndex = 0;
            // 
            // ConsoleWindow
            // 
            this.ConsoleWindow.BackColor = System.Drawing.SystemColors.MenuText;
            this.ConsoleWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsoleWindow.ForeColor = System.Drawing.SystemColors.Info;
            this.ConsoleWindow.Location = new System.Drawing.Point(0, 20);
            this.ConsoleWindow.Name = "ConsoleWindow";
            this.ConsoleWindow.Size = new System.Drawing.Size(780, 210);
            this.ConsoleWindow.TabIndex = 1;
            this.ConsoleWindow.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PortValue);
            this.panel1.Controls.Add(this.PortTitle);
            this.panel1.Controls.Add(this.IPValue);
            this.panel1.Controls.Add(this.IPTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 286);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 133);
            this.panel1.TabIndex = 2;
            // 
            // IPTitle
            // 
            this.IPTitle.AutoSize = true;
            this.IPTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IPTitle.Location = new System.Drawing.Point(62, 63);
            this.IPTitle.Name = "IPTitle";
            this.IPTitle.Size = new System.Drawing.Size(31, 20);
            this.IPTitle.TabIndex = 0;
            this.IPTitle.Text = "IP:";
            this.IPTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // IPValue
            // 
            this.IPValue.AutoSize = true;
            this.IPValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IPValue.Location = new System.Drawing.Point(99, 63);
            this.IPValue.Name = "IPValue";
            this.IPValue.Size = new System.Drawing.Size(0, 20);
            this.IPValue.TabIndex = 0;
            // 
            // PortTitle
            // 
            this.PortTitle.AutoSize = true;
            this.PortTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PortTitle.Location = new System.Drawing.Point(497, 63);
            this.PortTitle.Name = "PortTitle";
            this.PortTitle.Size = new System.Drawing.Size(47, 20);
            this.PortTitle.TabIndex = 0;
            this.PortTitle.Text = "Port:";
            // 
            // PortValue
            // 
            this.PortValue.AutoSize = true;
            this.PortValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PortValue.Location = new System.Drawing.Point(560, 63);
            this.PortValue.Name = "PortValue";
            this.PortValue.Size = new System.Drawing.Size(0, 20);
            this.PortValue.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1468, 673);
            this.Controls.Add(this.RighPanel);
            this.Controls.Add(this.PictureSpace);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.PictureSpace.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ActualPicture)).EndInit();
            this.RighPanel.ResumeLayout(false);
            this.DataPanel.ResumeLayout(false);
            this.DataPanel.PerformLayout();
            this.ConsolePanel.ResumeLayout(false);
            this.ConsolePanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cammunicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.Panel PictureSpace;
        private System.Windows.Forms.PictureBox ActualPicture;
        private System.Windows.Forms.Panel RighPanel;
        private System.Windows.Forms.Panel DataPanel;
        private System.Windows.Forms.Label ClockLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label AltitudeNameLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label HigroscopyNameLabel;
        private System.Windows.Forms.Label PressureNameLabel;
        private System.Windows.Forms.Label TemperatureNameLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel ConsolePanel;
        private System.Windows.Forms.RichTextBox ConsoleWindow;
        private System.Windows.Forms.TextBox ConsoleInput;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label PortValue;
        private System.Windows.Forms.Label PortTitle;
        private System.Windows.Forms.Label IPValue;
        private System.Windows.Forms.Label IPTitle;
    }
}

