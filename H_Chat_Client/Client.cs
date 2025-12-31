using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChatHandler;

namespace H_Chat_Client
{    
    public partial class Form1 : Form
    {
        TcpClient client;
        IPEndPoint ip;
        NetworkStream stream;
        string server_addr;
        int server_port=5000;
        ChatHandler.Common.ChatHandler ch;
        public string Input_MSG
        {
            get; set;
        }
        public Form1()
        {
            InitializeComponent();            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void OnSeverMessage(ChatHandler.Common.ChatHandler sender,string msg)
        {
            Invoke(new Action(() =>
            {
                richTextBox1.AppendText(msg);
                richTextBox1.AppendText("\n");
            }));
        }
        private void BTN_Send_Click(object sender, EventArgs e)
        {            
            this.Invoke(new Action(() =>
            {
                richTextBox1.AppendText(ip.Address.ToString() + ":" + ip.Port.ToString() + " : " + Input_MSG);
                richTextBox1.AppendText("\n");
            }));
            ch.Send(Input_MSG);
            InputBox.Text = string.Empty;
        }
        private void BTN_ConnectServer_Click(object sender, EventArgs e)
        {            
            client = new TcpClient(textBox1.Text, 5000);
            ip = (IPEndPoint)client.Client.LocalEndPoint;
            server_addr = ip.Address.ToString();

            stream = client.GetStream();
            textBox2.Text = ip.Address.ToString() + ":" + ip.Port.ToString();
            
            

            if (client == null)
                return;
            if (client.Connected)
            {
                ch = new ChatHandler.Common.ChatHandler(client);
                stream = client.GetStream();
                MessageBox.Show("서버 연동 완료");


                ch.OnMessageReceived += OnSeverMessage;               

                ch.Receive();
            }
            else
            {
                MessageBox.Show("서버 연동 실패");
            }
        }        

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void InputBox_TextChanged(object sender, EventArgs e)
        {
            Input_MSG = InputBox.Text;
        }             
    }
}
