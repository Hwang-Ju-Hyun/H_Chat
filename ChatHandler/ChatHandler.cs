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
        TcpClient client = null;
        NetworkStream stream;
        BinaryReader br;
        BinaryWriter bw;

        public TcpClient Client
        {
            get { return client; }
            set { client = value; }
        }

        public delegate void MessageDelegate(ChatHandler sender, string message);        
        public event MessageDelegate OnMessageReceived;        

        public ChatHandler(TcpClient client)
        {
            this.client = client;
            stream = this.client.GetStream();
            br = new BinaryReader(stream);
            bw = new BinaryWriter(stream);
        }

        public void Receive()
        {
            Task.Run(() => { ReceiveLoop(); });
        }
        private void ReceiveLoop()
        {            
            try
            {
                while (true)
                {
                    string message = br.ReadString();
                    if(OnMessageReceived!=null)
                    {
                        OnMessageReceived(this, message);
                    }
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
            bw.Flush();
        }
    }
}
