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
            this.BTN_ServerStart = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.L_ChatWindow = new System.Windows.Forms.Label();
            this.L_InputMessage = new System.Windows.Forms.Label();
            this.InputBox = new System.Windows.Forms.TextBox();
            this.BTN_Send = new System.Windows.Forms.Button();
            this.List_ConnectedIP = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // L_ServerIP
            // 
            this.L_ServerIP.AutoSize = true;
            this.L_ServerIP.Location = new System.Drawing.Point(29, 35);
            this.L_ServerIP.Name = "L_ServerIP";
            this.L_ServerIP.Size = new System.Drawing.Size(68, 15);
            this.L_ServerIP.TabIndex = 0;
            this.L_ServerIP.Text = "서버 Ip : ";
            this.L_ServerIP.Click += new System.EventHandler(this.label1_Click);
            // 
            // L_ConnectedIP
            // 
            this.L_ConnectedIP.AutoSize = true;
            this.L_ConnectedIP.Location = new System.Drawing.Point(29, 104);
            this.L_ConnectedIP.Name = "L_ConnectedIP";
            this.L_ConnectedIP.Size = new System.Drawing.Size(165, 15);
            this.L_ConnectedIP.TabIndex = 1;
            this.L_ConnectedIP.Text = "연결되 클라이언트 IP : ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(136, 35);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(276, 25);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BTN_ServerStart
            // 
            this.BTN_ServerStart.Location = new System.Drawing.Point(474, 32);
            this.BTN_ServerStart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BTN_ServerStart.Name = "BTN_ServerStart";
            this.BTN_ServerStart.Size = new System.Drawing.Size(229, 29);
            this.BTN_ServerStart.TabIndex = 4;
            this.BTN_ServerStart.Text = "서버 활성";
            this.BTN_ServerStart.UseVisualStyleBackColor = true;
            this.BTN_ServerStart.Click += new System.EventHandler(this.BTN_ServerStart_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(85, 206);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(508, 260);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // L_ChatWindow
            // 
            this.L_ChatWindow.AutoSize = true;
            this.L_ChatWindow.Location = new System.Drawing.Point(82, 176);
            this.L_ChatWindow.Name = "L_ChatWindow";
            this.L_ChatWindow.Size = new System.Drawing.Size(52, 15);
            this.L_ChatWindow.TabIndex = 6;
            this.L_ChatWindow.Text = "채팅창";
            this.L_ChatWindow.Click += new System.EventHandler(this.L_ChatWindow_Click);
            // 
            // L_InputMessage
            // 
            this.L_InputMessage.AutoSize = true;
            this.L_InputMessage.Location = new System.Drawing.Point(31, 498);
            this.L_InputMessage.Name = "L_InputMessage";
            this.L_InputMessage.Size = new System.Drawing.Size(52, 15);
            this.L_InputMessage.TabIndex = 7;
            this.L_InputMessage.Text = "입력 : ";
            // 
            // InputBox
            // 
            this.InputBox.Location = new System.Drawing.Point(85, 494);
            this.InputBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(508, 25);
            this.InputBox.TabIndex = 8;
            this.InputBox.TextChanged += new System.EventHandler(this.InputBox_TextChanged);
            // 
            // BTN_Send
            // 
            this.BTN_Send.Location = new System.Drawing.Point(677, 494);
            this.BTN_Send.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BTN_Send.Name = "BTN_Send";
            this.BTN_Send.Size = new System.Drawing.Size(146, 29);
            this.BTN_Send.TabIndex = 9;
            this.BTN_Send.Text = "보내기";
            this.BTN_Send.UseVisualStyleBackColor = true;
            this.BTN_Send.Click += new System.EventHandler(this.BTN_Send_Click);
            // 
            // List_ConnectedIP
            // 
            this.List_ConnectedIP.FormattingEnabled = true;
            this.List_ConnectedIP.ItemHeight = 15;
            this.List_ConnectedIP.Location = new System.Drawing.Point(186, 104);
            this.List_ConnectedIP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.List_ConnectedIP.Name = "List_ConnectedIP";
            this.List_ConnectedIP.Size = new System.Drawing.Size(313, 79);
            this.List_ConnectedIP.TabIndex = 10;
            this.List_ConnectedIP.SelectedIndexChanged += new System.EventHandler(this.List_ConnectedIP_SelectedIndexChanged);
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 562);
            this.Controls.Add(this.List_ConnectedIP);
            this.Controls.Add(this.BTN_Send);
            this.Controls.Add(this.InputBox);
            this.Controls.Add(this.L_InputMessage);
            this.Controls.Add(this.L_ChatWindow);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.BTN_ServerStart);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.L_ConnectedIP);
            this.Controls.Add(this.L_ServerIP);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Server";
            this.Text = "H_Chat_Server";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_ServerIP;
        private System.Windows.Forms.Label L_ConnectedIP;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BTN_ServerStart;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label L_ChatWindow;
        private System.Windows.Forms.Label L_InputMessage;
        private System.Windows.Forms.TextBox InputBox;
        private System.Windows.Forms.Button BTN_Send;
        private System.Windows.Forms.ListBox List_ConnectedIP;
    }
}

