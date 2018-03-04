using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PuszekGCS.lib;
using PuszekGCS.Source;
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
            DB db = new DB(@"\data\" + Mission.name);
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

        
    }
}
