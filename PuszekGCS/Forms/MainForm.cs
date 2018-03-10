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
using PuszekGCS.Forms;
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
        List<DataForm> df = new List<DataForm>();
        int numberOfNewDataForm = 0;
        int iterator = 0;
        List<Thread> threads = new List<Thread>();
        List<string> ConsoleOutputList = new List<string>();
        string ConsoleOutput = "";
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

            string value = DatabaseConnector.Query("select value from tmp1 where time = (select max(time) from tmp1)");
            value = clear(value);
            string[] splited = value.Split(' ');
            TemperatureValue.Text = splited[splited.Length - 2];
            value = DatabaseConnector.Query("select value from press1 where time = (select max(time) from press1)");
            value = clear(value);
            splited = value.Split(' ');
            PressureValue.Text = splited[splited.Length - 2];
            value = DatabaseConnector.Query("select value from gyrox where time = (select max(time) from gyrox)");
            value = clear(value);
            splited = value.Split(' ');
            GyroxValue.Text = splited[splited.Length - 2];
            value = DatabaseConnector.Query("select value from gyroy where time = (select max(time) from gyroy)");
            value = clear(value);
            splited = value.Split(' ');
            GyroyValue.Text = splited[splited.Length - 2];
            value = DatabaseConnector.Query("select value from gyroz where time = (select max(time) from gyroz)");
            value = clear(value);
            splited = value.Split(' ');
            GyrozValue.Text = splited[splited.Length - 2];
            seconds++;
            ClockLabel.Text = GenerateTimer(seconds);
            connected.Text = Mission.connected == true ? "connected" : "disconnected";
            connect.Visible = !Mission.connected;

        }

        private string clear(string text)
        {
            text = text.Replace('\r', ' ');
            text = text.Replace('\n', ' ');
            string[] splitedvalues = text.Split(' ');
            List<string> list = new List<string>();
            foreach (var value in splitedvalues)
            {
                if (value != "") list.Add(value);
            }
            string result = "";
            foreach(var value in list)
            {
                result += value + " ";
            }
            return result;
        }
        private void cammunicationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            PortValue.Text = Mission.port.ToString();
            IPValue.Text = Mission.IP;
            bool existed = MissionLocalyExist(Mission.name);
            DatabaseConnector.InitDatabase(@"data\" + Mission.name + ".db");
            timer1.Enabled = true;
            updateThread =  new UpdateThread();
            MissionNameLabel.Text = Mission.name;
            remebered = 0;
            if (!existed)
            {
                DatabaseConnector.Query("create table tmp1 (time real, value real)");
                DatabaseConnector.Query("INSERT INTO tmp1 (time, value) VALUES(0,0)");
                DatabaseConnector.Query("create table tmp2 (time real, value real)");
                DatabaseConnector.Query("INSERT INTO tmp2 (time, value) VALUES(0,0)");
                DatabaseConnector.Query("create table press1 (time real, value real)");
                DatabaseConnector.Query("INSERT INTO press1 (time, value) VALUES(0,0)");
                DatabaseConnector.Query("create table press2 (time real, value real)");
                DatabaseConnector.Query("INSERT INTO press2 (time, value) VALUES(0,0)");
                DatabaseConnector.Query("create table gyrox (time real, value real)");
                DatabaseConnector.Query("INSERT INTO gyrox (time, value) VALUES(0,0)");
                DatabaseConnector.Query("create table gyroy (time real, value real)");
                DatabaseConnector.Query("INSERT INTO gyroy (time, value) VALUES(0,0)");
                DatabaseConnector.Query("create table gyroz (time real, value real)");
                DatabaseConnector.Query("INSERT INTO gyroz (time, value) VALUES(0,0)");
                DatabaseConnector.Query("create table Logs (time real, value text)");
                DatabaseConnector.Query("INSERT INTO Logs (time, value) VALUES(0,'0')");
            }
            threads.Add(new Thread(new ThreadStart(updateThread.Run)));
            threads[iterator].Start();
        }

        private bool MissionLocalyExist(string name)
        {
            return File.Exists(@"data\" + name + ".db");
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            threads[iterator].Abort();
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
            iterator++;
            threads.Add(new Thread(new ThreadStart(updateThread.Run)));
            threads[iterator].Start();
            Mission.connected = true;
        }

        private void logToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lg = null;
            lg = new Log();
            lg.Show();
        }

        private void dataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            df.Add(new DataForm());
            df[numberOfNewDataForm].Show();
            numberOfNewDataForm++;
        }

        private void PressureLabel_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        int remebered;
        private void ConsoleInput_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == 13)
            {
                ConsoleOutputList.Add(ConsoleInput.Text);
                ConsoleOutputList.Add(TCP.Connect(Mission.IP, ConsoleInput.Text, Mission.port));
                ConsoleInput.Text = "";
                GenerateText();
                ConsoleWindow.Text = ConsoleOutput;
                remebered = ConsoleOutputList.Count;
            }
            if(e.KeyValue == 38)
            {
                if (remebered - 2 > 0)
                {
                    remebered -= 2;
                    ConsoleInput.Text = ConsoleOutputList[remebered];
                }
            }
            if(e.KeyValue == 40)
            {
                if (remebered + 2 < ConsoleOutputList.Count)
                {
                    remebered += 2;
                    ConsoleInput.Text = ConsoleOutputList[remebered];
                }
                else ConsoleInput.Text = "";
            }
        }

        private void ConsoleInput_TextChanged(object sender, EventArgs e)
        {
            ConsoleWindow.Text = ConsoleOutput;
        }

        private void GenerateText()
        {
            ConsoleOutput = "";
            for(int i = ConsoleOutputList.Count -1; i >= 0; i--)
            {
                ConsoleOutput += ConsoleOutputList[i] + "\n";
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
