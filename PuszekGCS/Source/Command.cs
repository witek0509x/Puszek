using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PuszekGCS.lib;
using PuszekGCS.Exceptions;

namespace PuszekGCS.Source
{
    
    static class Command
    {
        
        static string command = "";
        
        public static void Create()
        {
            command = "Create " + Mission.name;
            CommandExecute();
        }
        /*static public void SendUpdate(string name, string atribut, List<string> times, List<string> values)
        {
            command = "SendUpdate " + name + " " + atribut;
            for(int i = 0; i < values.Count; i++)
            {
                command += " " + times[i];
                command += " " + values[i];
            }
            CommandExecute();
        }*/
        public static string ReciveUpdate(string Atribut, float MissionTime)
        {
            command = "ReciveUpdate " + Mission.name + " " + Atribut + " " + MissionTime.ToString();
            return CommandExecute();
        }
        /*static public List<string> GetColumns(string name)
        {
            command = "GetColumns " + name;
            string response = CommandExecute();
            List<string> Atributs = new List<string>();
            string[] splited = response.Split(' ');
            foreach (string element in splited) Atributs.Add(element);
            return Atributs;
        }*/
        public static int CheckTopicality(string atribut, float time)
        {
            command = "CheckTopicality " + Mission.name + " " + atribut + " " + time.ToString();
            string respond = CommandExecute();
            if (respond == "No") return 0;
            else return 1;
        }

        public static bool Exist(string name)
        {
            command = "Exist " + name;
            string respond = CommandExecute();
            return (respond == "Yes");

        }
        static string CommandExecute()
        {
            try
            {
                string respond;
                try { respond = TCP.Connect(Mission.IP, command, Mission.port); }
                catch (Exception e) { throw new UnableToConnectToServerException(); }
                clear();
                return respond;
            }
            catch (Exception e)
            {
                return "";
            }
            
        }
        public static string ReciveLastImage()
        {
            command = "GetLastImage " + Mission.name;
            CommandExecute();
            return "";
        }
        static void clear()
        {
            command = "";
        }
    }
}
