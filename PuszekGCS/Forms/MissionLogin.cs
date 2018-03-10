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
    public partial class MissionLogin : Form
    {
        public MissionLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string exist = "";
            
            Mission.IP = IP.Text;
            Mission.name = name.Text;
            Mission.port = Int32.Parse(port.Text);
            try
            {
                if (!Command.Exist(name.Text))
                {
                    var result = MessageBox.Show("Mission with given name doesn't exist. Do you want to create it","Creating new mission", MessageBoxButtons.YesNo);
                    if (result == DialogResult.No) return;
                    Command.Create();
                }

            }
            catch
            {
                return;
            }

            MessageBox.Show("Connected");
            Mission.connected = true;
            this.Close();
        }

       
    }
}
