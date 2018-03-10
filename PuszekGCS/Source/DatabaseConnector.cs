using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using PuszekGCS.lib;
using System.Threading;
namespace PuszekGCS.Source
{
    static class DatabaseConnector
    {
        static DB db;
        static Object _lock = new object();
        public static void InitDatabase(string source)
        {
            db = new DB(source);
        }
        public static string Query(string query)
        {
            lock(_lock)
            {
                return db.Query(query);
            }
        }

    }
}