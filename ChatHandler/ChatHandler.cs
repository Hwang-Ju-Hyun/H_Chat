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
        private readonly object send_lock = new object();
        public TcpClient Client
        {
            get { return client; }
            set { client = value; }
        }

        public delegate void MessageDelegate(ChatHandler sender, string message);        
        public event MessageDelegate OnMessageReceived;

        public delegate void DisconnectDelegate(ChatHandler sender);
        public event DisconnectDelegate OnDisconnected;
        public ChatHandler(TcpClient client)
        {
            this.client = client;
            stream = this.client.GetStream();
            br = new BinaryReader(stream);
            bw = new BinaryWriter(stream);
        }

        public void Exit()
        {
            if (client != null)
            {
                this.client.Close();
                this.client = null;
            }
            if(stream!=null)
            {
                this.stream.Close();
                this.stream = null;
            }
            if(br!=null)
            {
                this.br.Close();
                this.br = null;
            }         
            if(bw!=null)
            {
                this.bw.Close();
                this.bw= null;
            }
            
            
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
                if(OnDisconnected!=null)
                {
                    OnDisconnected(this);
                }
                Debug.WriteLine(ex);
            }
        }
        public void Send(string message)
        {
            lock(send_lock)
            {
                bw.Write(message);
                bw.Flush();
            }                
        }
    }
}
