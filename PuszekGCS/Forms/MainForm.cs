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
        int seconds = 0;
        float altitude;
        float temperature;
        float higroscopy;
        float pressure;
        Log lg;
        Communication cm;
        MissionLogin ml;
        UpdateThread updateThread;
        DB db;
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

            string value = db.Query("select value from tmp1 where time = (select max(tmie) from tmp1");
            string[] splited = value.Split(' ');
            TemperatureValue.Text = splited[splited.Length - 1];
            value = db.Query("select value from press1 where time = (select max(tmie) from press1");
            splited = value.Split(' ');
            PressureValue.Text = splited[splited.Length - 1];
            value = db.Query("select value from gyrox where time = (select max(tmie) from gyrox");
            splited = value.Split(' ');
            GyroxValue.Text = splited[splited.Length - 1];
            value = db.Query("select value from gyroy where time = (select max(tmie) from gyroy");
            splited = value.Split(' ');
            GyroyValue.Text = splited[splited.Length - 1];
            value = db.Query("select value from gyroz where time = (select max(tmie) from gyroz");
            splited = value.Split(' ');
            GyrozValue.Text = splited[splited.Length - 1];
            seconds++;
            ClockLabel.Text = GenerateTimer(seconds);
            connected.Text = Mission.connected == true ? "connected" : "disconnected";
            connect.Visible = !Mission.connected;

        }
        private void cammunicationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            PortValue.Text = Mission.port.ToString();
            IPValue.Text = Mission.IP;
            db = new DB(@"data\" + Mission.name + ".db");
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


        private string GenerateTimer(int seconds)
        {
            int hours = (seconds - (seconds % 3600)) / 3600;
            seconds = seconds % 3600;
            int minutes = (seconds - (seconds % 60)) / 60;
            seconds = seconds % 60;
            return addZero(hours) + ":" + addZero(minutes) + ":" + addZero(seconds);
        }

        private string addZero(int number)
        {
            return number < 10 ? "0" + number.ToString() : number.ToString();

        }

        private void connect_Click(object sender, EventArgs e)
        {
            thread.Start();
        }
    }
}
