namespace tcp_ip
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
            btnStart = new Button();
            btnStop = new Button();
            label1 = new Label();
            txtHost = new TextBox();
            servertxtStatus = new TextBox();
            label3 = new Label();
            servertxtmessage = new TextBox();
            serverbtnSend = new Button();
            label4 = new Label();
            devices_list = new ListBox();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Location = new Point(49, 52);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(94, 29);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(267, 52);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(94, 29);
            btnStop.TabIndex = 1;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 19);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 2;
            label1.Text = "Host : Port";
            // 
            // txtHost
            // 
            txtHost.Location = new Point(220, 19);
            txtHost.Name = "txtHost";
            txtHost.Size = new Size(125, 27);
            txtHost.TabIndex = 4;
            txtHost.Text = "127.0.0.1:9000";
            // 
            // servertxtStatus
            // 
            servertxtStatus.ForeColor = Color.Green;
            servertxtStatus.Location = new Point(49, 99);
            servertxtStatus.Multiline = true;
            servertxtStatus.Name = "servertxtStatus";
            servertxtStatus.ScrollBars = ScrollBars.Vertical;
            servertxtStatus.Size = new Size(336, 310);
            servertxtStatus.TabIndex = 6;
            servertxtStatus.Text = "please start the server...\r\n\r\n..\r\n";
            servertxtStatus.TextChanged += txtStatus_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(606, 52);
            label3.Name = "label3";
            label3.Size = new Size(107, 20);
            label3.TabIndex = 7;
            label3.Text = "type message :\r\n";
            // 
            // servertxtmessage
            // 
            servertxtmessage.Location = new Point(606, 99);
            servertxtmessage.Multiline = true;
            servertxtmessage.Name = "servertxtmessage";
            servertxtmessage.ScrollBars = ScrollBars.Vertical;
            servertxtmessage.Size = new Size(301, 292);
            servertxtmessage.TabIndex = 8;
            // 
            // serverbtnSend
            // 
            serverbtnSend.Location = new Point(813, 409);
            serverbtnSend.Name = "serverbtnSend";
            serverbtnSend.Size = new Size(94, 29);
            serverbtnSend.TabIndex = 9;
            serverbtnSend.Text = "Send";
            serverbtnSend.UseVisualStyleBackColor = true;
            serverbtnSend.Click += serverbtnSend_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(430, 61);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 11;
            label4.Text = "devices";
            // 
            // devices_list
            // 
            devices_list.FormattingEnabled = true;
            devices_list.ItemHeight = 20;
            devices_list.Location = new Point(407, 99);
            devices_list.Name = "devices_list";
            devices_list.ScrollAlwaysVisible = true;
            devices_list.Size = new Size(163, 304);
            devices_list.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 450);
            Controls.Add(devices_list);
            Controls.Add(label4);
            Controls.Add(serverbtnSend);
            Controls.Add(servertxtmessage);
            Controls.Add(label3);
            Controls.Add(servertxtStatus);
            Controls.Add(txtHost);
            Controls.Add(label1);
            Controls.Add(btnStop);
            Controls.Add(btnStart);
            Name = "Form1";
            Text = "Server";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStart;
        private Button btnStop;
        private Label label1;
        private Label label2;
        private TextBox txtPort;
        public TextBox txtHost;
        private TextBox txtStatus;
        private TextBox servertxtStatus;
        private Label label3;
        private TextBox servertxtmessage;
        private Button serverbtnSend;
        private Label label4;
        private ListBox devices_list;
    }
}