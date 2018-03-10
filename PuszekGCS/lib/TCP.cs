using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using PuszekGCS.Exceptions;
namespace PuszekGCS.lib
{
    class TCP
    {
        public static string Connect(String server, String message, Int32 port)
        {
            try
            {
                message = message.Replace(',', '.');
                TcpClient client = new TcpClient(server, port);
                Byte[] data = System.Text.Encoding.ASCII.GetBytes(message);
                NetworkStream stream = client.GetStream();
                stream.Write(data, 0, data.Length);
                data = new Byte[256];
                String responseData = String.Empty;
                Int32 bytes = stream.Read(data, 0, data.Length);
                responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
                stream.Close();
                client.Close();
                if (responseData[0] == '!') throw new ServerException(responseData);
                responseData = responseData.Replace(',', '.');
                return responseData;
            }
            catch(Exception e)
            {
                throw e;
            }
        }
    }
}
