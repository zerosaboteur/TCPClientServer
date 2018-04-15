using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace ChatClient
{
    public partial class Aplikacja : Form
    {
        private TcpClient client;

        public string adres = Form1.adres;
        public string port = Form1.port;

        public string zaptxt;
        public string recieve;
        public String TextToSend;

        public Socket sck;
        EndPoint IpEnd;
        EndPoint epSender;

        byte[] bytes = new byte[256];
        byte[] buffer = new byte[1500];

        public Aplikacja()
        {
            InitializeComponent();

            sck = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                client = new TcpClient();
                IpEnd = new IPEndPoint(IPAddress.Parse(adres), int.Parse(port));

                epSender = (EndPoint)IpEnd;

                client.Connect(IPAddress.Parse(adres), int.Parse(port));
                sck.Connect(IpEnd);

                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epSender, new AsyncCallback(receiveCallback), buffer);

                if (client.Connected)
                {
                    label2.Text = "Połączony";
                    label2.ForeColor = System.Drawing.Color.Green;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void Wyslij_Click(object sender, EventArgs e)
        {
            System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();
            byte[] msg = new byte[1500];
            msg = enc.GetBytes(PoleWiadomosc.Text);
            sck.Send(msg);
            zaptxt = PoleWiadomosc.Text;
            MessageBox.Show("" + zaptxt);
            PoleWiadomosc.Clear();
        }
        public void receiveCallback(IAsyncResult asyncReceive)
        {
            try
            {
                byte[] rec = new byte[client.ReceiveBufferSize];
                client.Client.Receive(rec);
                string temp = Encoding.ASCII.GetString(rec); ;
                
                temp = temp.Trim('\0');

                MessageBox.Show("" + temp);
                this.Invoke((MethodInvoker)delegate
                {
                    if (zaptxt != temp)
                    {
                        OknoChat.Items.Add("Znajomy: " + temp);
                    }
                    else
                        OknoChat.Items.Add("Ty: " + temp);
                });
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epSender, new AsyncCallback(receiveCallback), buffer);
            }
            catch
            {

            }
         }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                client.GetStream().Close();
                client.Close();
                sck.Shutdown(SocketShutdown.Both);
                sck.Disconnect(true);
                this.Close();
            }
            catch
            {
                this.Close();
            }
        }
    }
}
