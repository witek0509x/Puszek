using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using PuszekGCS.Source;
using PuszekGCS.lib;

namespace PuszekGCS.threads
{
    class UpdateThread
    {
        DB db;
        List<string> atributs = new List<string>();
        public UpdateThread(DB db)
        {
            this.db = db;
            atributs.Add("tmp1");
            atributs.Add("tmp2");
            atributs.Add("press1");
            atributs.Add("press2");
            atributs.Add("gyrox");
            atributs.Add("gyroy");
            atributs.Add("gyroz");
        }

        public void Run()
        {
            float actualTime;
            while(true)
            {
                foreach (var atribut in atributs)
                {
                    string tmp = db.Query("select MAX(time) from " + atribut);
                    actualTime = float.Parse(tmp);
                    if (Command.CheckTopicality(atribut, actualTime) == 0)
                    {
                        UpdateDB(Command.ReciveUpdate(atribut, actualTime),atribut);
                    }
                }
                Thread.Sleep(1000);

            }
        }

        private void UpdateDB(string input, string atribut)
        {
            string[] splited = input.Split(' ');
            for (int i = 0; i < splited.Length; i += 2)
            {
                string query = "insert into " + atribut + "(time, value) values (" + splited[i] + ", " + splited [i+1] + ")";
                try
                {
                    db.Query(query);
                }
                catch (Exception e)
                {
                    throw;
                }
                
            }
        }

    }
}