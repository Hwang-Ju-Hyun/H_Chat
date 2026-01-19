using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChatHandler;

namespace H_Chat
{
    public partial class Server : Form
    {
        const string addr = "192.168.45.30";
        const int port = 5000;
        TcpListener server;
        NetworkStream stream;        

        List<ChatHandler.Common.ChatHandler> clients;

        private readonly object client_lock= new object();           
        public RichTextBox richbox
        {  get; set; }

        string Input_message;
        public string Input_MSG
        {
            get; set;
        }
            
        public Server()
        {
            InitializeComponent();
        }

        void AllClose()
        {
            foreach(ChatHandler.Common.ChatHandler client in clients)
            {
                client.Exit();                
            }            
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            server = new TcpListener(IPAddress.Any, port);
            server.Start();
            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    textBox1.Text = ip.ToString();
                    break;
                }
            }
            clients = new List<ChatHandler.Common.ChatHandler>();
        }

        private void PrintMessage(IPEndPoint ip,string msg)
        {
            richTextBox1.AppendText(ip.Address.ToString() + " : " + ip.Port.ToString() + " : " + msg);
            richTextBox1.AppendText("\n");
        }

        private void OnClientMessage(ChatHandler.Common.ChatHandler sender,string msg)
        {
            string senderInfo=((IPEndPoint)sender.Client.Client.RemoteEndPoint).ToString();            

            this.Invoke(new Action(() =>
            {
                richTextBox1.AppendText($"{senderInfo} : {msg}\n");
            }));
            string formatMsg = senderInfo +" : "+ msg;
            BroadCast(sender, formatMsg);
        }
        
        private void BroadCast(ChatHandler.Common.ChatHandler sender, string msg)
        {
            lock(client_lock)
            {
                foreach(var client in clients)
                {
                    if(client!= sender)
                    {
                        client.Send(msg);
                    }
                }
            }
        }

        private void AcceptClient()
        {
            while(true)
            {                
                try
                {
                    TcpClient client = server.AcceptTcpClient();
                    ChatHandler.Common.ChatHandler handler = new ChatHandler.Common.ChatHandler(client);
                    
                    lock(client_lock)
                    {
                        clients.Add(handler);
                        IPEndPoint client_ip = (IPEndPoint)handler.Client.Client.RemoteEndPoint;
                        this.Invoke(new Action(() =>
                        {
                            List_ConnectedIP.Items.Add(client_ip.Address + " : " + client_ip.Port);
                        }));
                    }                                                            

                    handler.OnMessageReceived += OnClientMessage;
                    handler.OnDisconnected += OnClientDisconnected;
                    handler.Receive();                    
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show(ex.Message);
                    break;
                }
            }
        }       
        private void BTN_ServerStart_Click(object sender, EventArgs e)
        {
            MessageBox.Show("서버 활성화");
            Task.Run(() => { AcceptClient(); });
        }
        
        private void BTN_Send_Click(object sender, EventArgs e)
        {
            this.Invoke(new Action(() =>
            {
                richTextBox1.AppendText(addr + ":" + port + " : " + Input_MSG);
                richTextBox1.AppendText("\n");
            }));

            foreach (var client in clients)
            {
                client.Send($"{addr} : {port} : {Input_MSG}");
            }

            InputBox.Text = string.Empty;
        }
        private void InputBox_TextChanged(object sender, EventArgs e)
        {
            Input_MSG = InputBox.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void L_ChatWindow_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void List_ConnectedIP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void OnClientDisconnected(ChatHandler.Common.ChatHandler sender)
        {
            lock(client_lock)
            {
                clients.Remove(sender);
            }
            this.Invoke(new Action(() =>
            {
                List_ConnectedIP.Items.Remove(sender);
                sender.Exit();
            }));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}