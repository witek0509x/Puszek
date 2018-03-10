using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using PuszekGCS.Source;
using PuszekGCS.lib;
using System.Windows.Forms;
namespace PuszekGCS.threads
{
    class UpdateThread
    {
        List<string> atributs = new List<string>();
        public UpdateThread()
        {
            atributs.Add("tmp1");
            atributs.Add("tmp2");
            atributs.Add("press1");
            atributs.Add("press2");
            atributs.Add("gyrox");
            atributs.Add("gyroy");
            atributs.Add("gyroz");
            atributs.Add("Logs");
        }

        public void Run()
        {
            float actualTime;
            while(true)
            {
                foreach (var atribut in atributs)
                {
                    string tmp = DatabaseConnector.Query("select MAX(time) from " + atribut);
                    actualTime = float.Parse(tmp);
                    //try
                    //{
                        if (Command.CheckTopicality(atribut, actualTime) == 0)
                        {
                            UpdateDB(Command.ReciveUpdate(atribut, actualTime), atribut);
                        }
                    //}
                    /*catch(Exception e)
                    {
                        Mission.connected = false;
                        MessageBox.Show(e.Message);
                        return;
                    }*/
                    Thread.Sleep(1000);
                }
                

            }
        }

        private void UpdateDB(string input, string atribut)
        {
            int size;
            string[] splited = input.Split(' ');
            if (input[input.Length - 1] == ' ') size = splited.Length - 1;
            else size = splited.Length;
                for (int i = 0; i < size; i += 2)
                {
                string query;
                if (atribut != "Logs") query = "insert into " + atribut + "(time, value) values (" + splited[i] + ", " + splited[i + 1] + ")";
                else query = "insert into " + atribut + "(time, value) values (" + splited[i] + ", '" + splited[i + 1] + "')";
                try
                {
                    DatabaseConnector.Query(query);
                }
                catch (Exception e)
                {
                    throw;
                }
                
            }
        }

    }
}