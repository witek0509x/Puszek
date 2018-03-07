namespace PuszekGCS
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
            this.ConsolePanel = new System.Windows.Forms.Panel();
            this.ConsoleWindow = new System.Windows.Forms.RichTextBox();
            this.ConsoleInput = new System.Windows.Forms.TextBox();
            this.DataPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PortValue = new System.Windows.Forms.Label();
            this.PortTitle = new System.Windows.Forms.Label();
            this.IPValue = new System.Windows.Forms.Label();
            this.IPTitle = new System.Windows.Forms.Label();
            this.ClockLabel = new System.Windows.Forms.Label();
            this.GyroyLabel = new System.Windows.Forms.Label();
            this.GyrozLabel = new System.Windows.Forms.Label();
            this.GyroxLabel = new System.Windows.Forms.Label();
            this.PressureLabel = new System.Windows.Forms.Label();
            this.TemperatureLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TemperatureValue = new System.Windows.Forms.Label();
            this.PressureValue = new System.Windows.Forms.Label();
            this.GyroxValue = new System.Windows.Forms.Label();
            this.GyrozValue = new System.Windows.Forms.Label();
            this.GyroyValue = new System.Windows.Forms.Label();
            this.connected = new System.Windows.Forms.Label();
            this.connect = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.PictureSpace.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ActualPicture)).BeginInit();
            this.RighPanel.SuspendLayout();
            this.ConsolePanel.SuspendLayout();
            this.DataPanel.SuspendLayout();
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
            // DataPanel
            // 
            this.DataPanel.Controls.Add(this.panel1);
            this.DataPanel.Controls.Add(this.ClockLabel);
            this.DataPanel.Controls.Add(this.GyroyValue);
            this.DataPanel.Controls.Add(this.GyroyLabel);
            this.DataPanel.Controls.Add(this.GyrozValue);
            this.DataPanel.Controls.Add(this.GyrozLabel);
            this.DataPanel.Controls.Add(this.GyroxValue);
            this.DataPanel.Controls.Add(this.GyroxLabel);
            this.DataPanel.Controls.Add(this.PressureValue);
            this.DataPanel.Controls.Add(this.PressureLabel);
            this.DataPanel.Controls.Add(this.TemperatureValue);
            this.DataPanel.Controls.Add(this.TemperatureLabel);
            this.DataPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.DataPanel.Location = new System.Drawing.Point(0, 0);
            this.DataPanel.Name = "DataPanel";
            this.DataPanel.Size = new System.Drawing.Size(780, 419);
            this.DataPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.connect);
            this.panel1.Controls.Add(this.PortValue);
            this.panel1.Controls.Add(this.connected);
            this.panel1.Controls.Add(this.PortTitle);
            this.panel1.Controls.Add(this.IPValue);
            this.panel1.Controls.Add(this.IPTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 286);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 133);
            this.panel1.TabIndex = 2;
            // 
            // PortValue
            // 
            this.PortValue.AutoSize = true;
            this.PortValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PortValue.Location = new System.Drawing.Point(342, 63);
            this.PortValue.Name = "PortValue";
            this.PortValue.Size = new System.Drawing.Size(0, 20);
            this.PortValue.TabIndex = 0;
            // 
            // PortTitle
            // 
            this.PortTitle.AutoSize = true;
            this.PortTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PortTitle.Location = new System.Drawing.Point(279, 63);
            this.PortTitle.Name = "PortTitle";
            this.PortTitle.Size = new System.Drawing.Size(47, 20);
            this.PortTitle.TabIndex = 0;
            this.PortTitle.Text = "Port:";
            // 
            // IPValue
            // 
            this.IPValue.AutoSize = true;
            this.IPValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IPValue.Location = new System.Drawing.Point(91, 63);
            this.IPValue.Name = "IPValue";
            this.IPValue.Size = new System.Drawing.Size(0, 20);
            this.IPValue.TabIndex = 0;
            // 
            // IPTitle
            // 
            this.IPTitle.AutoSize = true;
            this.IPTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IPTitle.Location = new System.Drawing.Point(54, 63);
            this.IPTitle.Name = "IPTitle";
            this.IPTitle.Size = new System.Drawing.Size(31, 20);
            this.IPTitle.TabIndex = 0;
            this.IPTitle.Text = "IP:";
            this.IPTitle.Click += new System.EventHandler(this.label1_Click);
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
            // GyroyLabel
            // 
            this.GyroyLabel.AutoSize = true;
            this.GyroyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GyroyLabel.Location = new System.Drawing.Point(31, 169);
            this.GyroyLabel.Name = "GyroyLabel";
            this.GyroyLabel.Size = new System.Drawing.Size(113, 20);
            this.GyroyLabel.TabIndex = 0;
            this.GyroyLabel.Text = "Gyroscope y:";
            // 
            // GyrozLabel
            // 
            this.GyrozLabel.AutoSize = true;
            this.GyrozLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GyrozLabel.Location = new System.Drawing.Point(31, 201);
            this.GyrozLabel.Name = "GyrozLabel";
            this.GyrozLabel.Size = new System.Drawing.Size(114, 20);
            this.GyrozLabel.TabIndex = 0;
            this.GyrozLabel.Text = "Gyroscope z:";
            // 
            // GyroxLabel
            // 
            this.GyroxLabel.AutoSize = true;
            this.GyroxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GyroxLabel.Location = new System.Drawing.Point(31, 133);
            this.GyroxLabel.Name = "GyroxLabel";
            this.GyroxLabel.Size = new System.Drawing.Size(113, 20);
            this.GyroxLabel.TabIndex = 0;
            this.GyroxLabel.Text = "Gyroscope x:";
            this.GyroxLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // PressureLabel
            // 
            this.PressureLabel.AutoSize = true;
            this.PressureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PressureLabel.Location = new System.Drawing.Point(31, 96);
            this.PressureLabel.Name = "PressureLabel";
            this.PressureLabel.Size = new System.Drawing.Size(85, 20);
            this.PressureLabel.TabIndex = 0;
            this.PressureLabel.Text = "Pressure:";
            // 
            // TemperatureLabel
            // 
            this.TemperatureLabel.AutoSize = true;
            this.TemperatureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TemperatureLabel.Location = new System.Drawing.Point(31, 60);
            this.TemperatureLabel.Name = "TemperatureLabel";
            this.TemperatureLabel.Size = new System.Drawing.Size(116, 20);
            this.TemperatureLabel.TabIndex = 0;
            this.TemperatureLabel.Text = "Temperature:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TemperatureValue
            // 
            this.TemperatureValue.AutoSize = true;
            this.TemperatureValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TemperatureValue.Location = new System.Drawing.Point(153, 60);
            this.TemperatureValue.Name = "TemperatureValue";
            this.TemperatureValue.Size = new System.Drawing.Size(0, 20);
            this.TemperatureValue.TabIndex = 0;
            // 
            // PressureValue
            // 
            this.PressureValue.AutoSize = true;
            this.PressureValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PressureValue.Location = new System.Drawing.Point(153, 96);
            this.PressureValue.Name = "PressureValue";
            this.PressureValue.Size = new System.Drawing.Size(0, 20);
            this.PressureValue.TabIndex = 0;
            // 
            // GyroxValue
            // 
            this.GyroxValue.AutoSize = true;
            this.GyroxValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GyroxValue.Location = new System.Drawing.Point(153, 133);
            this.GyroxValue.Name = "GyroxValue";
            this.GyroxValue.Size = new System.Drawing.Size(0, 20);
            this.GyroxValue.TabIndex = 0;
            this.GyroxValue.Click += new System.EventHandler(this.label3_Click);
            // 
            // GyrozValue
            // 
            this.GyrozValue.AutoSize = true;
            this.GyrozValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GyrozValue.Location = new System.Drawing.Point(153, 201);
            this.GyrozValue.Name = "GyrozValue";
            this.GyrozValue.Size = new System.Drawing.Size(0, 20);
            this.GyrozValue.TabIndex = 0;
            // 
            // GyroyValue
            // 
            this.GyroyValue.AutoSize = true;
            this.GyroyValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GyroyValue.Location = new System.Drawing.Point(153, 169);
            this.GyroyValue.Name = "GyroyValue";
            this.GyroyValue.Size = new System.Drawing.Size(0, 20);
            this.GyroyValue.TabIndex = 0;
            // 
            // connected
            // 
            this.connected.AutoSize = true;
            this.connected.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.connected.Location = new System.Drawing.Point(548, 63);
            this.connected.Name = "connected";
            this.connected.Size = new System.Drawing.Size(0, 20);
            this.connected.TabIndex = 0;
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(610, 63);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(75, 23);
            this.connect.TabIndex = 1;
            this.connect.Text = "Connect";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Visible = false;
            this.connect.Click += new System.EventHandler(this.connect_Click);
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
            this.ConsolePanel.ResumeLayout(false);
            this.ConsolePanel.PerformLayout();
            this.DataPanel.ResumeLayout(false);
            this.DataPanel.PerformLayout();
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
        private System.Windows.Forms.Label GyroyLabel;
        private System.Windows.Forms.Label GyrozLabel;
        private System.Windows.Forms.Label GyroxLabel;
        private System.Windows.Forms.Label PressureLabel;
        private System.Windows.Forms.Label TemperatureLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel ConsolePanel;
        private System.Windows.Forms.RichTextBox ConsoleWindow;
        private System.Windows.Forms.TextBox ConsoleInput;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label PortValue;
        private System.Windows.Forms.Label PortTitle;
        private System.Windows.Forms.Label IPValue;
        private System.Windows.Forms.Label IPTitle;
        private System.Windows.Forms.Label GyroyValue;
        private System.Windows.Forms.Label GyrozValue;
        private System.Windows.Forms.Label GyroxValue;
        private System.Windows.Forms.Label PressureValue;
        private System.Windows.Forms.Label TemperatureValue;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.Label connected;
    }
}

