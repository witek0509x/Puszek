using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
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
        }

        public void Run()
        {
            while(true)
            {
                
            }
        }
    }
}