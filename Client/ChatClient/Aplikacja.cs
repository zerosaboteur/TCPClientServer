using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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

       // public Socket sck;
        EndPoint IpEnd;
        EndPoint epSender;
        
        byte[] buffer = new byte[4128];

        public Aplikacja()
        {
            InitializeComponent();

            //sck = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                client = new TcpClient();
                IpEnd = new IPEndPoint(IPAddress.Parse(adres), int.Parse(port));

                epSender = (EndPoint)IpEnd;

                client.Connect(IPAddress.Parse(adres), int.Parse(port));
                //sck.Connect(IpEnd);

                client.ReceiveBufferSize = 2000000;
                //client.Client.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epSender, new AsyncCallback(receiveCallback), buffer);
                Thread sluchanie = new Thread(receiveCallback);
                sluchanie.Start();

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
            client.Client.Send(msg);
            zaptxt = PoleWiadomosc.Text;
            MessageBox.Show("" + zaptxt);
            PoleWiadomosc.Clear();
            OknoChat.Items.Add("Ty: " + zaptxt);

        }
        public void receiveCallback()
        {
            try
            {
                Thread.Sleep(60000);
                byte[] rec = new byte[client.ReceiveBufferSize];
                client.Client.Receive(rec);
                string temp = Encoding.ASCII.GetString(rec);

                MessageBox.Show("" + temp);
                if (temp.Contains("PNG"))
                {
                    File.WriteAllBytes("E:\\Projekty\\img.png", rec);
                    OknoObrazka.SizeMode = PictureBoxSizeMode.Zoom;
                    OknoObrazka.ImageLocation = "E:\\Projekty\\img.png";
                }
                else
                {
                    temp = Encoding.ASCII.GetString(rec);
                    temp = temp.Trim('\0');

                    this.Invoke((MethodInvoker)delegate
                    {
                            OknoChat.Items.Add("Znajomy: " + temp);
                    });
                }
                //client.Client.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epSender, new AsyncCallback(receiveCallback), buffer);
                Thread.Sleep(100);
                receiveCallback();
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
                this.Close();
            }
            catch
            {
                this.Close();
            }
        }

        private void PicSendBut_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string image_to_send = openFileDialog1.FileName;
                try
                {
                    if (image_to_send.Contains(".png"))
                    {
                        client.Client.SendFile(image_to_send);
                        OknoObrazka.SizeMode = PictureBoxSizeMode.Zoom;
                        OknoObrazka.ImageLocation = image_to_send;
                    }
                    else
                    {
                        MessageBox.Show("To nie jest obrazek PNG");
                    }
                }
                catch (IOException)
                {
                }
            }
        }
    }
}
