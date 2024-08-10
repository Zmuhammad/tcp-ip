// this is test for SKI comapni

using System.Collections.Generic;
using System.Text;
using SuperSimpleTcp;

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SimpleTcpClient client;
        private void txtStatus_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConnect_Click(object sender, EventArgs e)

        {
            try
            {
                client.Connect();
                txtStatus.Text += "connection succesful" + Environment.NewLine;
                btnConnect.Enabled = false;
                btnSend.Enabled = true;

            }
            catch (Exception)
            {
                MessageBox.Show("Server is Inactive");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new SimpleTcpClient(txtHost.Text);

            client.Events.Connected += Events_Connected;
            client.Events.Disconnected += Events_Disconnected;
            client.Events.DataReceived += Events_DataReceived;
        }

        private void Events_Connected(object? sender, ConnectionEventArgs e)
        {
            txtStatus.Text += " you're Connected " + Environment.NewLine;
        }

        private void Events_Disconnected(object? sender, ConnectionEventArgs e)
        {
            txtStatus.Text += " you're disconnected!" + Environment.NewLine;
        }

        private void Events_DataReceived(object sender, DataReceivedEventArgs e)
        {
            txtStatus.Text += Encoding.UTF8.GetString(e.Data) + Environment.NewLine;

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (client.IsConnected)
            {
                if (!string.IsNullOrEmpty(txtMessage.Text))
                {
                    client.Send(txtMessage.Text);
                    txtStatus.Text = " me : " + txtMessage + Environment.NewLine;
                    txtMessage.Text = string.Empty;
                }
            }
            else
            {
                MessageBox.Show("Ure not connected ! ");
            }

        }

        private void txtHost_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPort_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
