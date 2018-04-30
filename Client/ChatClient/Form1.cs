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
    public partial class Form1 : Form
    {
        public static string adres ;
        public static string port ;
        public void PokazaniePonowne()
        {
            this.Show();
        }

        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(5, 25, 30);
            this.ForeColor = Color.FromArgb(255, 125, 0);
        }

        private void Aplikacja_Closing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }

        private void userControl11_Click(object sender, EventArgs e)
        {
            adres = AdresIP.Text;
            port = Portt.Text;
            if (String.IsNullOrWhiteSpace(AdresIP.Text) || String.IsNullOrWhiteSpace(Portt.Text))
            {

            }
            else
            {
                this.Hide();
                HackerMan h = new HackerMan();
                h.Show();
                System.Windows.Forms.Application.DoEvents();
                System.Threading.Thread.Sleep(5000);
                h.Hide();
                Aplikacja a = new Aplikacja();
                a.Show();
                a.FormClosing += Aplikacja_Closing;
            }
        }

        private void userControl12_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
