namespace PuszekGCS
{
    partial class Log
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
            this.ListOfLog = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // ListOfLog
            // 
            this.ListOfLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListOfLog.FormattingEnabled = true;
            this.ListOfLog.Location = new System.Drawing.Point(0, 0);
            this.ListOfLog.Name = "ListOfLog";
            this.ListOfLog.Size = new System.Drawing.Size(724, 577);
            this.ListOfLog.TabIndex = 0;
            this.ListOfLog.SelectedIndexChanged += new System.EventHandler(this.ListOfLog_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 577);
            this.Controls.Add(this.ListOfLog);
            this.Name = "Log";
            this.Text = "Log";
            this.Load += new System.EventHandler(this.Log_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ListOfLog;
        private System.Windows.Forms.Timer timer1;
    }
}