namespace Client
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtHost = new TextBox();
            label1 = new Label();
            btnConnect = new Button();
            txtStatus = new TextBox();
            txtMessage = new TextBox();
            btnSend = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtHost
            // 
            txtHost.Location = new Point(168, 47);
            txtHost.Name = "txtHost";
            txtHost.Size = new Size(125, 27);
            txtHost.TabIndex = 9;
            txtHost.Text = "127.0.0.1:9000";
            txtHost.TextChanged += txtHost_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 47);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 7;
            label1.Text = "Host ip : port";
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(617, 50);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(94, 29);
            btnConnect.TabIndex = 6;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // txtStatus
            // 
            txtStatus.ForeColor = Color.Navy;
            txtStatus.Location = new Point(59, 80);
            txtStatus.Multiline = true;
            txtStatus.Name = "txtStatus";
            txtStatus.ScrollBars = ScrollBars.Vertical;
            txtStatus.Size = new Size(652, 140);
            txtStatus.TabIndex = 11;
            txtStatus.Text = "please click on connect botton to connect to server\r\n\r\n..\r\n";
            txtStatus.TextChanged += txtStatus_TextChanged;
            // 
            // txtMessage
            // 
            txtMessage.BackColor = Color.Moccasin;
            txtMessage.ForeColor = Color.Green;
            txtMessage.Location = new Point(59, 266);
            txtMessage.Multiline = true;
            txtMessage.Name = "txtMessage";
            txtMessage.ScrollBars = ScrollBars.Vertical;
            txtMessage.Size = new Size(652, 134);
            txtMessage.TabIndex = 12;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(617, 409);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(94, 29);
            btnSend.TabIndex = 13;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 243);
            label3.Name = "label3";
            label3.Size = new Size(153, 20);
            label3.TabIndex = 14;
            label3.Text = "enter your message :  ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(btnSend);
            Controls.Add(txtMessage);
            Controls.Add(txtStatus);
            Controls.Add(txtHost);
            Controls.Add(label1);
            Controls.Add(btnConnect);
            Name = "Form1";
            Text = "Client";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPort;
        private TextBox txtHost;
        private Label label2;
        private Label label1;
        private Button btnConnect;
        private TextBox txtStatus;
        private TextBox txtMessage;
        private Button btnSend;
        private Label label3;
    }
}