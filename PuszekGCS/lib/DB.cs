using System;
using System.Data.SQLite;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace PuszekGCS.lib
{
    internal class DB
    {
        public SQLiteConnection MDbConnection;

        public DB(string source)
        {
            try
            {
                MDbConnection = new SQLiteConnection("Data Source=" + source + ";Version=3;");
                MDbConnection.Open();
            }
            catch
            {
            }
        }




        public string Query(string sql)
        {
            try
            {
                var wynik = "";
                var i = 0;
                var command = new SQLiteCommand(sql, MDbConnection);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    while (reader.FieldCount > i)
                    {
                        wynik += reader[i].ToString();
                        wynik += " ";
                        i++;
                    }

                    i = 0;
                    wynik += Environment.NewLine;
                }

                return wynik;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return "";
            }
        }

        public int getsize()
        {
            var i = 0;
            var command = new SQLiteCommand("get * from structure", MDbConnection);
            var reader = command.ExecuteReader();
            while (reader.Read()) i++;
            return i;
        }

        public int CountResults(string sql)
        {
            var i = 0;
            var command = new SQLiteCommand(sql, MDbConnection);
            var reader = command.ExecuteReader();
            while (reader.Read()) i++;
            return i;
        }
    }
}