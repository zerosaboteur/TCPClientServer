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

        public string adres = Form1.adres;
        public string port = Form1.port;

        private TcpClient client;
        public StreamReader STR;
        public StreamWriter STW;
        public string recieve;
        public String TextToSend;

        public Socket sck;
        EndPoint IpEnd;

        public Aplikacja()
        {
            MessageBox.Show("" + adres);
            MessageBox.Show("" + port);
            InitializeComponent();

            sck = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            try
            {
                client = new TcpClient();
                EndPoint IpEnd = new IPEndPoint(IPAddress.Parse(adres), int.Parse(port));

                sck.Connect(IpEnd);
                byte[] buffer = new byte[1500]; sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref IpEnd, new AsyncCallback(MessageCallBack), buffer);
            
                if (client.Connected)
                    {
                    ChatBox.AppendText("Connected to server" + "\n");
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        
        private void Wyslij_Click(object sender, EventArgs e)
        {
            try {
                System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();
                byte[] msg = new byte[1500];
                msg = enc.GetBytes(PoleWiadomosc.Text); sck.Send(msg);
                OknoChat.Items.Add("You: " + PoleWiadomosc.Text);
                PoleWiadomosc.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void MessageCallBack(IAsyncResult aResult)
        {
            try
            {
                int size = sck.EndReceiveFrom(aResult, ref IpEnd);
                if (size > 0)
                {
                    byte[] receivedData = new byte[1464];
                    receivedData = (byte[])aResult.AsyncState;
                    ASCIIEncoding eEncoding = new ASCIIEncoding();
                    string receivedMessage = eEncoding.GetString(receivedData);
                    OknoChat.Items.Add("Friend: " + receivedMessage);
                }
                byte[] buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref IpEnd, new AsyncCallback(MessageCallBack), buffer);
            }
            catch (Exception exp)
            { MessageBox.Show(exp.ToString());
            }
        }
    }
}
