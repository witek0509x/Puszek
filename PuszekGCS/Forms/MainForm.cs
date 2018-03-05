using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using PuszekGCS.lib;
using PuszekGCS.Source;
using PuszekGCS.threads;
namespace PuszekGCS
{
    public partial class MainForm : Form
    {
        int seconds;
        float altitude;
        float temperature;
        float higroscopy;
        float pressure;
        Log lg;
        Communication cm;
        MissionLogin ml;
        
        public MainForm()
        {
            InitializeComponent();
            lg = new Log();
            cm = new Communication();
            ml = new MissionLogin();
            ml.ShowDialog(this);
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {

        }
        private void cammunicationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DB db = new DB(@"\data\" + Mission.name);
            db.Query("create table temp1 (time real, value real)");
            db.Query("create table temp1 (time real, value real)");
            db.Query("create table temp2 (time real, value real)");
            db.Query("create table press1 (time real, value real)");
            db.Query("create table press2 (time real, value real)");
            db.Query("create table gyrox (time real, value real)");
            db.Query("create table gyroy (time real, value real)");
            db.Query("create table gyroz (time real, value real)");
            UpdateThread updateThread = new UpdateThread(db);
            Thread thread = new Thread(new ThreadStart(updateThread.Run));
            thread.Start();
        }
    }
}
