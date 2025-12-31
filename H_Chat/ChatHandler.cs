using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H_Chat
{
    public class ChatHandler
    {
        TcpClient refClient=null;
        NetworkStream stream;
        BinaryReader br;
        BinaryWriter bw;
        Server refForm;
        public ChatHandler(Server form ,TcpClient client)
        {
            refForm = form;
            refClient = client;
        }
        public void Receive()
        {
            stream = refClient.GetStream();
            br=new BinaryReader(stream);
            bw = new BinaryWriter(stream);
            try
            {
                while (true)
                {
                    string message = br.ReadString();

                    refForm.Invoke(new MethodInvoker(delegate
                    {
                        refForm.richbox.AppendText(message);
                    }));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        public void Send()
        {
            try
            {
                bw.Write(refForm.Input_MSG);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
