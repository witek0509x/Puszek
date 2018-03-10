using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PuszekGCS.Source;
namespace PuszekGCS
{
    public partial class Log : Form
    {
        
        public Log()
        {
            InitializeComponent();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            ListOfLog.DataSource = null;
            ListOfLog.DataSource = GenerateListOfLogs();
        }

        private void Log_Load(object sender, EventArgs e)
        {
            ListOfLog.DataSource = GenerateListOfLogs();
            timer1.Enabled = true;
        }

        private List<string> GenerateListOfLogs()
        {
            try
            {
                List<string> logs = new List<string>();
                List<string> times = new List<string>();
                List<string> outer = new List<string>();


                string values = DatabaseConnector.Query("select value from Logs");
                values = values.Replace('\r', ' ');
                values = values.Replace('\n', ' ');
                string[] splitedvalues = values.Split(' ');
                foreach (var value in splitedvalues)
                {
                    if (value != "") logs.Add(value);
                }


                string time = DatabaseConnector.Query("select time from Logs");
                time = time.Replace('\r', ' ');
                time = time.Replace('\n', ' ');
                string[] splitedtime = time.Split(' ');
                foreach (var value in splitedtime)
                {
                    if (value != "") times.Add(value);
                }


                for (int i = 1; i < times.Count; i++)
                {
                    outer.Add(times[i] + " " + logs[i]);
                }
                return outer;
            }
            catch(Exception e)
            {
                MessageBox.Show("Exception in Log.GenerateListOfString(): " + e.Message);
                return null;
            }
            
        }

        private void ListOfLog_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
