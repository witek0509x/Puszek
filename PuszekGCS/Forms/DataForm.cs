using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using PuszekGCS.Source;
namespace PuszekGCS.Forms
{
    public partial class DataForm : Form
    {
        public DataForm()
        {
            InitializeComponent();
        }

        private void chartControl1_Click(object sender, EventArgs e)
        {

        }

        private void Temperature1Checkbox_CheckedChanged(object sender, EventArgs e)
        {
            
            

        }

        private List<float> GetFromDB(string atributName, string tableName)
        {
            List<float> result = new List<float>();
            string values = DatabaseConnector.Query("select " + atributName + " from " + tableName);
            values = values.Replace('\r', ' ');
            values = values.Replace('\n', ' ');
            string[] splitedvalues = values.Split(' ');
            foreach (var value in splitedvalues)
            {
                if (value != "") result.Add(float.Parse(value));
            }
            return result;
        }

        private void DataForm_Load(object sender, EventArgs e)
        {
            chart.Series.Remove(chart.Series["Series1"]);
            setChart("tmp1", "Temperature 1", this.Temp1);
        }

        private void Temp1_CheckedChanged(object sender, EventArgs e)
        {
            setChart("tmp1", "Temperature 1", this.Temp1);
        }

        private void Temp2_CheckedChanged(object sender, EventArgs e)
        {
            setChart("tmp2", "Temperature 2", this.Temp2);
        }

        private void Press1_CheckedChanged(object sender, EventArgs e)
        {
            setChart("press1", "Pressure 1", this.Press1);
        }

        private void Press2_CheckedChanged(object sender, EventArgs e)
        {
            setChart("press2", "Pressure 2", this.Press2);
        }

        private void Gyrox_CheckedChanged(object sender, EventArgs e)
        {
            setChart("gyrox", "Gyroscope x", this.Gyrox);
        }

        private void gyroy_CheckedChanged(object sender, EventArgs e)
        {
            setChart("gyroy", "Gyroscope y", this.gyroy);
        }

        private void gyroz_CheckedChanged(object sender, EventArgs e)
        {
            setChart("gyroz", "Gyroscope z", this.gyroz);
        }


        private void setChart(string dbName, string seriesName, RadioButton rb)
        {
            try
            {
                if (rb.Checked == true)
                {
                    chart.Series.Add(seriesName);
                    chart.Series[seriesName].ChartType = SeriesChartType.Line;
                    List<float> times = GetFromDB("time", dbName);
                    List<float> values = GetFromDB("value", dbName);
                    for (int i = 1; i < times.Count; i++)
                    {
                        chart.Series[seriesName].Points.AddXY(times[i], values[i]);
                    }
                }
                else
                {
                    chart.Series.Remove(chart.Series[seriesName]);
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("Exception in DataForm.SetChart(): " + e.Message);
                return;
            }
            
        }

        private void chart_Click(object sender, EventArgs e)
        {

        }
    }
}
