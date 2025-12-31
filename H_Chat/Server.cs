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
        const string addr = "192.168.45.195";
        const int port = 5000;
        TcpListener server;
        NetworkStream stream;
        TcpClient client;
        ChatHandler.Common.ChatHandler ch;        
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
        }
        private void AcceptClient()
        {
            while(true)
            {                
                try
                {
                    client = server.AcceptTcpClient();
                    if(client!=null&&client.Connected)
                    {
                        string clientInfo = ((IPEndPoint)client.Client.RemoteEndPoint).ToString();                        
                        this.Invoke(new Action(() =>
                        {
                            textBox2.Text = clientInfo;
                        }));
                        ch = new ChatHandler.Common.ChatHandler(client);
                        ch.OnMessageReceived += (msg) =>
                        {
                            Invoke(new Action(() =>
                            {
                                richTextBox1.AppendText(clientInfo+ " : " + msg);
                                richTextBox1.AppendText("\n");
                            }));
                        };
                        ch.Receive();
                    }
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
            ch.Send(Input_MSG);
            this.Invoke(new MethodInvoker(delegate { richTextBox1.AppendText(addr+":"+port+" : "+Input_MSG); richTextBox1.AppendText("\n"); }));            
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
    }
}