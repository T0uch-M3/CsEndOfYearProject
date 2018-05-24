using SimpleTCP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }
        public SimpleTcpClient client;
        byte[] data = new byte[1024];
        private void btnConnect_Click(object sender, EventArgs e)
        {
            client.Connect(txtIp.Text.ToString(), Int32.Parse(txtPort.Text));
            btnConnect.Enabled = false;
            login_btn.Enabled = true;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            client = new SimpleTcpClient();
            client.StringEncoder = Encoding.UTF8;
            client.DataReceived += Client_DataRecieved;
        }

        private void Client_DataRecieved(object sender, SimpleTCP.Message e)
        {
            if (e.MessageString.Equals("Proceed"))
            {
                ActiveForm.Invoke((MethodInvoker)delegate()
                {
                    this.Hide();
                    //c.deconnecter();//close connection
                    Form1 f = new Form1(client);
                    f.Show();//open second form
                });
            }
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            String s = "/L" + loginCode.Text;
            sendMsg(s, client.TcpClient);
            System.Threading.Thread.Sleep(500);
            String s2 = "/P" + password.Text;
            sendMsg(s2, client.TcpClient);
            //client.WriteLine("/P" + password.Text);
        }
        public void sendMsg(String s, TcpClient target)
        {
            string welcome = s;
            data = Encoding.ASCII.GetBytes(welcome);
            target.GetStream().Write(data, 0, data.Length);
        }
    }
}
