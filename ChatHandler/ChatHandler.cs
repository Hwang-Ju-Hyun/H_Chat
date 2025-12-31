using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ChatHandler.Common
{
    public class ChatHandler
    {
        TcpClient refClient = null;
        NetworkStream stream;
        BinaryReader br;
        BinaryWriter bw;

        public event Action<string> OnMessageReceived;
        public ChatHandler(TcpClient client)
        {
            refClient = client;
            stream = refClient.GetStream();
            br = new BinaryReader(stream);
            bw = new BinaryWriter(stream);
        }

        public void Receive()
        {
            Task.Run(() => { ReceiveLoop(); });
        }
        public void ReceiveLoop()
        {            
            try
            {
                while (true)
                {
                    string message = br.ReadString();
                    OnMessageReceived?.Invoke(message);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }

        }
        public void Send(string message)
        {
            bw.Write(message);
            //bw.Flush();
        }
    }
}
