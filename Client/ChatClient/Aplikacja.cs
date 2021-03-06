﻿using System;
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
using System.Runtime.InteropServices;

namespace ChatClient
{
    public partial class Aplikacja : Form
    {
        private TcpClient client;

        public string adres = Form1.adres;
        public string port = Form1.port;

        public string zaptxt;
        public string recieve;
        
        EndPoint IpEnd;
        EndPoint epSender;
        
        byte[] buffer = new byte[4128];

        int rozmiar_zdjecia;
        int time = 1;

        bool czy_mozna_pisac = true;

        public Aplikacja()
        {
            InitializeComponent();
            
            //Proba nawiązania połączenia
            try
            {
                client = new TcpClient();
                IpEnd = new IPEndPoint(IPAddress.Parse(adres), int.Parse(port));

                epSender = (EndPoint)IpEnd;

                client.Connect(IPAddress.Parse(adres), int.Parse(port));
                
                //ustawienie buffera, dla testów :) 
                client.ReceiveBufferSize = 2000000;

                //odpalenie słuchania w tle
                Thread sluchanie = new Thread(receiveCallback);
                sluchanie.Start();

                //Sprawdzenie statusu połączenia, jesli pozytywnie to zmienia kolor
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
            //Sprawdzenie czy kod nie zawiera złowa klucz
            if (PoleWiadomosc.Text.Contains("xrozxplik"))
            {
                MessageBox.Show("Wiadomość nie może zawirać ciągu znaków xrozxplik");
            }
            else
            {
                if (czy_mozna_pisac == true)
                {
                    try
                    {
                        //Zakodowanie wiadomości wysyłanej na serwer
                        System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();
                        byte[] msg = new byte[1500];
                        msg = enc.GetBytes(PoleWiadomosc.Text);

                        //Wysałanie wiadomości
                        client.Client.Send(msg);
                        zaptxt = PoleWiadomosc.Text;
                        MessageBox.Show("" + zaptxt);
                        PoleWiadomosc.Clear();
                        OknoChat.Items.Add("Ty: " + zaptxt);
                    }
                    catch
                    {
                        MessageBox.Show("Nie jesteś połączony z serwerem");
                    }
                }
                else
                {
                    MessageBox.Show("Poczekaj na odbiór/wysłanie obrazka");
                }
            }

        }
        public void receiveCallback()
        {
            try
            {
                //odpowiednie dostosowanie czasu czekania do wielkości wysyłanego pliku
                Thread.Sleep(time * 1000);
                byte[] rec = new byte[client.ReceiveBufferSize];
                client.Client.Receive(rec);
                string temp = Encoding.ASCII.GetString(rec);
                if (temp.Contains("xrozxplik"))
                {
                    czy_mozna_pisac = false;
                    string zdjecie_kb = temp.Replace("xrozxplik", "");
                    time = Convert.ToInt32(zdjecie_kb);
                }
                else
                {
                    //Sprawdzenie czu uzyskiwana wiadomośc nie jest zdjęciem
                    MessageBox.Show("" + temp);
                    if (temp.Contains("PNG"))
                    {
                        File.WriteAllBytes("E:\\Projekty\\img.png", rec);
                        OknoObrazka.SizeMode = PictureBoxSizeMode.Zoom;
                        OknoObrazka.ImageLocation = "E:\\Projekty\\img.png";
                        //odblokowanie możliwości pisania
                        czy_mozna_pisac = true;
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
                    time = 1;
                    Thread.Sleep(100);
                }
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
            if (czy_mozna_pisac == true) {
                DialogResult result = openFileDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string image_to_send = openFileDialog1.FileName;
                    try
                    {
                        if (image_to_send.Contains(".png"))
                        {
                            //wiadomosc z rozmiarem pliku
                            FileInfo fileInfo = new FileInfo(image_to_send);
                            System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();
                            byte[] msg = new byte[1500];
                            double temp_rozm = fileInfo.Length / 1024;
                            rozmiar_zdjecia = Convert.ToInt32(temp_rozm);
                            msg = enc.GetBytes(rozmiar_zdjecia + "xrozxplik");
                            client.Client.Send(msg);

                            Thread.Sleep(100);

                            czy_mozna_pisac = false;
                            

                            client.Client.SendFile(image_to_send);
                            OknoObrazka.SizeMode = PictureBoxSizeMode.Zoom;
                            OknoObrazka.ImageLocation = image_to_send;
                            Thread licznik_czasu_na_wyslanie = new Thread(CzekajPoWyslaniuObrazka);
                            licznik_czasu_na_wyslanie.Start();
                        }
                        else
                        {
                            MessageBox.Show("To nie jest obrazek PNG");
                        }
                    }
                    catch (IOException)
                    {
                        MessageBox.Show("Nie jesteś połączony z serwerem");
                    }
                }
            }
            else
            {
                MessageBox.Show("Poczekaj na wysłanie/odbiór obrazka");
            }
        }
        //Odczenia (blokada) po wyslaniu obrazka, uzytkownik nie może wysłać kolejnego
        private void CzekajPoWyslaniuObrazka()
        {
            MessageBox.Show(""+rozmiar_zdjecia);
            Thread.Sleep(rozmiar_zdjecia * 1000);
            czy_mozna_pisac = true;
        }

        //Pozwalanie na przeciąganie okna

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void Aplikacja_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }
    }
}
