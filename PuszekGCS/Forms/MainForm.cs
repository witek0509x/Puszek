using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        UpdateThread updateThread;
        private Thread thread;
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
            PortValue.Text = Mission.port.ToString();
            IPValue.Text = Mission.IP;
            DB db = new DB(@"data\" + Mission.name + ".db");
            updateThread =  new UpdateThread(db);
            if (!MissionLocalyExist(Mission.name))
            {
                db.Query("create table tmp1 (time real, value real)");
                db.Query("INSERT INTO tmp1 (time, value) VALUES(0,0)");
                db.Query("create table tmp2 (time real, value real)");
                db.Query("INSERT INTO tmp2 (time, value) VALUES(0,0)");
                db.Query("create table press1 (time real, value real)");
                db.Query("INSERT INTO press1 (time, value) VALUES(0,0)");
                db.Query("create table press2 (time real, value real)");
                db.Query("INSERT INTO press2 (time, value) VALUES(0,0)");
                db.Query("create table gyrox (time real, value real)");
                db.Query("INSERT INTO gyrox (time, value) VALUES(0,0)");
                db.Query("create table gyroy (time real, value real)");
                db.Query("INSERT INTO gyroy (time, value) VALUES(0,0)");
                db.Query("create table gyroz (time real, value real)");
                db.Query("INSERT INTO gyroz (time, value) VALUES(0,0)");
            }
            thread = new Thread(new ThreadStart(updateThread.Run));
            thread.Start();
        }

        private bool MissionLocalyExist(string name)
        {
            return File.Exists(@"data\" + name);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            thread.Abort();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
