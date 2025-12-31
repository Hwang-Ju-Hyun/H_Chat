namespace H_Chat
{
    partial class Server
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.L_ServerIP = new System.Windows.Forms.Label();
            this.L_ConnectedIP = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.BTN_ServerStart = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.L_ChatWindow = new System.Windows.Forms.Label();
            this.L_InputMessage = new System.Windows.Forms.Label();
            this.InputBox = new System.Windows.Forms.TextBox();
            this.BTN_Send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // L_ServerIP
            // 
            this.L_ServerIP.AutoSize = true;
            this.L_ServerIP.Location = new System.Drawing.Point(25, 28);
            this.L_ServerIP.Name = "L_ServerIP";
            this.L_ServerIP.Size = new System.Drawing.Size(55, 12);
            this.L_ServerIP.TabIndex = 0;
            this.L_ServerIP.Text = "서버 Ip : ";
            this.L_ServerIP.Click += new System.EventHandler(this.label1_Click);
            // 
            // L_ConnectedIP
            // 
            this.L_ConnectedIP.AutoSize = true;
            this.L_ConnectedIP.Location = new System.Drawing.Point(25, 83);
            this.L_ConnectedIP.Name = "L_ConnectedIP";
            this.L_ConnectedIP.Size = new System.Drawing.Size(132, 12);
            this.L_ConnectedIP.TabIndex = 1;
            this.L_ConnectedIP.Text = "연결되 클라이언트 IP : ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(119, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(242, 21);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(163, 80);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(198, 21);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // BTN_ServerStart
            // 
            this.BTN_ServerStart.Location = new System.Drawing.Point(415, 26);
            this.BTN_ServerStart.Name = "BTN_ServerStart";
            this.BTN_ServerStart.Size = new System.Drawing.Size(200, 23);
            this.BTN_ServerStart.TabIndex = 4;
            this.BTN_ServerStart.Text = "서버 활성";
            this.BTN_ServerStart.UseVisualStyleBackColor = true;
            this.BTN_ServerStart.Click += new System.EventHandler(this.BTN_ServerStart_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(74, 165);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(445, 209);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // L_ChatWindow
            // 
            this.L_ChatWindow.AutoSize = true;
            this.L_ChatWindow.Location = new System.Drawing.Point(72, 141);
            this.L_ChatWindow.Name = "L_ChatWindow";
            this.L_ChatWindow.Size = new System.Drawing.Size(41, 12);
            this.L_ChatWindow.TabIndex = 6;
            this.L_ChatWindow.Text = "채팅창";
            this.L_ChatWindow.Click += new System.EventHandler(this.L_ChatWindow_Click);
            // 
            // L_InputMessage
            // 
            this.L_InputMessage.AutoSize = true;
            this.L_InputMessage.Location = new System.Drawing.Point(27, 398);
            this.L_InputMessage.Name = "L_InputMessage";
            this.L_InputMessage.Size = new System.Drawing.Size(41, 12);
            this.L_InputMessage.TabIndex = 7;
            this.L_InputMessage.Text = "입력 : ";
            // 
            // InputBox
            // 
            this.InputBox.Location = new System.Drawing.Point(74, 395);
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(445, 21);
            this.InputBox.TabIndex = 8;
            this.InputBox.TextChanged += new System.EventHandler(this.InputBox_TextChanged);
            // 
            // BTN_Send
            // 
            this.BTN_Send.Location = new System.Drawing.Point(592, 395);
            this.BTN_Send.Name = "BTN_Send";
            this.BTN_Send.Size = new System.Drawing.Size(128, 23);
            this.BTN_Send.TabIndex = 9;
            this.BTN_Send.Text = "보내기";
            this.BTN_Send.UseVisualStyleBackColor = true;
            this.BTN_Send.Click += new System.EventHandler(this.BTN_Send_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 450);
            this.Controls.Add(this.BTN_Send);
            this.Controls.Add(this.InputBox);
            this.Controls.Add(this.L_InputMessage);
            this.Controls.Add(this.L_ChatWindow);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.BTN_ServerStart);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.L_ConnectedIP);
            this.Controls.Add(this.L_ServerIP);
            this.Name = "Form1";
            this.Text = "H_Chat_Server";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_ServerIP;
        private System.Windows.Forms.Label L_ConnectedIP;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button BTN_ServerStart;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label L_ChatWindow;
        private System.Windows.Forms.Label L_InputMessage;
        private System.Windows.Forms.TextBox InputBox;
        private System.Windows.Forms.Button BTN_Send;
    }
}

