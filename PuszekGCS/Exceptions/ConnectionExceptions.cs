using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace PuszekGCS.Exceptions
{
    class UnableToConnectToServerException : Exception
    {
        public UnableToConnectToServerException()
        {
            MessageBox.Show("Unable to connect to server. Call Wojtek to repair it", "Connection error");
        }
    }
}