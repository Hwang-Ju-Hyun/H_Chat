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

namespace H_Chat_Client
{    
    public partial class Form1 : Form
    {
        TcpClient client;
        IPEndPoint ip;
        NetworkStream stream;        
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
        private void BTN_Send_Click(object sender, EventArgs e)
        {
            ch.Send();
            this.Invoke(new MethodInvoker(delegate { richTextBox1.AppendText(addr + ":" + port + " : " + Input_MSG); }));
        }
        private void BTN_ConnectServer_Click(object sender, EventArgs e)
        {            
            client = new TcpClient(textBox1.Text, 5000);
            stream = client.GetStream();
            ip = (IPEndPoint)client.Client.LocalEndPoint;
            textBox2.Text = ip.Address.ToString() + ":" + ip.Port.ToString();

            if (client == null)
                return;
            if (client.Connected)
            {
                stream = client.GetStream();
                MessageBox.Show("서버 연동 완료");
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

        }             
    }
}
