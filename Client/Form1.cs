using SimpleTCP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : MetroFramework.Forms.MetroForm//CCCCCCCCCCCCCCCCCCCCLIENT
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Form1(SimpleTcpClient client1)
        {
            // TODO: Complete member initialization
            this.client = client1;
            InitializeComponent();
        }
        public SimpleTcpClient client;
        byte[] data = new byte[1024];
        
       

        private void Form1_Load(object sender, EventArgs e)
        {
            //client = new SimpleTcpClient();
            client.StringEncoder = Encoding.UTF8;
            client.DataReceived += Client_DataRecieved;
            sendMsg("/S" + "Intered", client.TcpClient);
        }

        private void Client_DataRecieved(object sender, SimpleTCP.Message e)
        {
            txtStatus.Invoke((MethodInvoker)delegate(){
                txtStatus.Clear();
                txtStatus.AppendText(e.MessageString);
                //txtStatus.Text = txtStatus.Text.Insert(0, e.MessageString + "\n");
            });

        }

        private void txtMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                String s = "/M" + txtMessage.Text;
                sendMsg(s, client.TcpClient);
            }
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            String s = "/M" + txtMessage.Text;
            sendMsg(s, client.TcpClient);
            txtMessage.Text = "";
              //client.WriteLineAndGetReply(txtMessage.Text, TimeSpan.FromSeconds(3));
              //client.Write(txtMessage.Text);
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            ipRange(IPAddress.Parse("192.168.1.147"));

            //foreach (var c in IPGlobalProperties.GetIPGlobalProperties().GetActiveTcpConnections())
            //{
            //    Console.WriteLine(c.State);
            //    Console.WriteLine(c.LocalEndPoint);
            //}



            //foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
            //{
            //    foreach (UnicastIPAddressInformation ip in ni.GetIPProperties().UnicastAddresses)
            //    {
            //        if (!ip.IsDnsEligible)
            //        {
            //            if (ip.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
            //            {
            //                Console.WriteLine(ip.Address.ToString());
            //            }
            //        }
            //    }
            //}



            //System.Net.NetworkInformation.Ping p = new System.Net.NetworkInformation.Ping();
            //System.Net.NetworkInformation.PingReply rep = p.Send("192.168.1.2");
            //if (rep.Status == System.Net.NetworkInformation.IPStatus.Success)
            //{
            //    Console.WriteLine("working");
            //}
            //else
            //    Console.WriteLine("not wroking");

            //String strHostName = Dns.GetHostName();
            //IPHostEntry iphostentry = Dns.GetHostEntry(strHostName);
            //IPAddress[] allIp = Dns.GetHostAddresses(strHostName);
            //List<IPAddress> list = allIp.ToList();

            //foreach (IPAddress ipaddress in iphostentry.AddressList)
            //{
            //    Console.WriteLine(ipaddress);
            //}

            //list.ForEach(Console.WriteLine);
           
        }


        public void ipRange(IPAddress ip)
        {
            String newIp = null, newIp2 = null;
            int countDots = 0;

            Ping ping = new Ping();
            PingReply pingReply = ping.Send("192.168.1.147");

            if (pingReply.Status == IPStatus.Success)
            {
                
                System.Console.WriteLine("good");
                
            }
            else
                System.Console.WriteLine("bad");
            Ping sender  = new Ping();
            sender.PingCompleted += new PingCompletedEventHandler(PingCompletedCallback);//method below
            //sender.SendAsync(dest, timeout, buffer, options, textLabel);




            //try
            //{
            //    IAsyncResult ar = (IAsyncResult)client.Connect("192.168.1.148", Int32.Parse(txtPort.Text));
            //    client.TcpClient.Close();

            //}


            //catch (SocketException e)
            //{
            //    System.Console.WriteLine("RIP connectin");
            //}

            //************************************* waiting testing, check if the ip adrs is the other machine adr or no***************
            //IPGlobalProperties ipProperties = IPGlobalProperties.GetIPGlobalProperties();
            //IPEndPoint[] ipEndPoints = ipProperties.GetActiveTcpListeners();


            //foreach (IPEndPoint endPoint in ipEndPoints)
            //{
            //    if (endPoint.Port == Int32.Parse(txtPort.Text))
            //    {

            //        System.Console.WriteLine("ip adr: " + endPoint.Address.ToString());
            //        System.Console.WriteLine("in use");
            //        break;
            //    }
            //}
            //**************************************************************************************************************************





            var host = Dns.GetHostEntry(Dns.GetHostName());
            List<IPAddress> list = host.AddressList.ToList();
            IPAddress currentIp = list[3];
            String stringIp = currentIp.ToString();
            System.Console.WriteLine(stringIp);
            for (int i = 0; i < stringIp.Length; i++)
            {
                if (stringIp[i].Equals('.'))
                    countDots++;
                if (countDots < 2)
                    newIp += stringIp[i];
                System.Console.WriteLine(newIp);
            }
            try { 
                //client.Connect("192.168.1.148", Int32.Parse(txtPort.Text));
                
            }
            catch (SocketException)
            {

            }
        
            //for (int i = 0; i < 255; i++)
            //{
            //    for (int j = 0; j < 255; j++)
            //    {
            //        newIp2 = newIp + "." + i + "." + j;
            //        client.Connect(newIp2, Int32.Parse(txtPort.Text));
                    
            //        //System.Console.WriteLine(newIp2);
            //    }
            //}
        }

        private void PingCompletedCallback(object sender, PingCompletedEventArgs e)
        {
            if (e.Reply.Status == IPStatus.Success)
            {
                System.Console.WriteLine("ok");
            }
            else
            {
                System.Console.WriteLine("not ok");
            }
        }

        private void confirm_btn_Click(object sender, EventArgs e)
        {
            //client.WriteLine("/L"+tbLogin.Text);
            //String s = "/L" + tbLogin.Text;
            //sendMsg(s, client.TcpClient);
            //System.Threading.Thread.Sleep(500);
            //client.WriteLine("/P"+tbPwd.Text);
        }

        public void sendMsg(String s, TcpClient target)
        {
            string welcome = s;
            data = Encoding.ASCII.GetBytes(welcome);
            target.GetStream().Write(data, 0, data.Length);
        }



       
    }
}
