using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using SuperSimpleTcp;

namespace tcp_ip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SimpleTcpServer server;
        private String loginName;


        private void btnStart_Click(object sender, EventArgs e)
        {

            server.Start();

            servertxtStatus.Text += " Server started succesfully ..." + Environment.NewLine;

            btnStart.Enabled = false;
            btnStop.Enabled = true;
            txtHost.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String Ip = txtHost.Text;

            server = new SimpleTcpServer(Ip);
            btnStart.Enabled = true;

            server.Events.ClientConnected += Events_ClientConnected;
            server.Events.ClientDisconnected += Events_ClientDisconnected;
            server.Events.DataReceived += Events_DataReceived;
        }

        private void Events_DataReceived(object? sender, DataReceivedEventArgs e)
        {
            servertxtStatus.Text += e.IpPort + " : " + Encoding.UTF8.GetString(e.Data) + Environment.NewLine;
        }

        private void Events_ClientDisconnected(object? sender, ConnectionEventArgs e)
        {
            servertxtStatus.Text += e.IpPort + " : Disconnected " + Environment.NewLine;
            devices_list.Items.Remove(e.IpPort);
        }

        private void Events_ClientConnected(object? sender, ConnectionEventArgs e)
        {
            servertxtStatus.Text += e.IpPort + " : Connected " + Environment.NewLine;
            devices_list.Items.Add(e.IpPort); 
        }


        private void btnStop_Click(object sender, EventArgs e)
        {
            if (server.IsListening)
            {
                server.Stop();
                servertxtStatus.Text += "server disconnected" + Environment.NewLine;
                btnStart.Enabled = true;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtStatus_TextChanged(object sender, EventArgs e)
        {
        }

        private void serverbtnSend_Click(object sender, EventArgs e)
        {
            if (server.IsListening)
            {
                if (!string.IsNullOrEmpty(servertxtmessage.Text))
                {
                    server.Send(devices_list.SelectedItem.ToString(), servertxtmessage.Text);
                    servertxtStatus.Text += "Server : " + servertxtmessage.Text + Environment.NewLine;
                    servertxtmessage.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show(" message box cannot be empty !");
                }
            }
        }
    }
}