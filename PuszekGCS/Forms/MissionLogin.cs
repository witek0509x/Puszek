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
            try { exist = TCP.Connect(IP.Text, "Exist " + name.Text, Int32.Parse(port.Text)); }
            catch
            {
                MessageBox.Show("Wrong data error");
                return;
            }
            if (exist == "no")
            {
                var result = MessageBox.Show("Mission with given name doesn't exist. Do you want to create it", "Creating new mission", MessageBoxButtons.YesNo);
                if(result == DialogResult.No) return;
            }
            Mission.IP = IP.Text;
            Mission.name = name.Text;
            Mission.port = Int32.Parse(port.Text);
            if (exist == "no")
            {
                try
                {
                    Command.Create();
                }
                catch
                {
                    return;
                }
                
            }
            this.Close();
        }

       
    }
}
