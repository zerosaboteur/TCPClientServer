namespace ChatClient
{
    partial class Aplikacja
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Aplikacja));
            this.PoleWiadomosc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OknoChat = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new CustomButton.UserControl1();
            this.Wyslij = new CustomButton.UserControl1();
            this.PicSendBut = new CustomButton.UserControl1();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.OknoObrazka = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.button1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wyslij)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSendBut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OknoObrazka)).BeginInit();
            this.SuspendLayout();
            // 
            // PoleWiadomosc
            // 
            this.PoleWiadomosc.Location = new System.Drawing.Point(126, 343);
            this.PoleWiadomosc.Name = "PoleWiadomosc";
            this.PoleWiadomosc.Size = new System.Drawing.Size(503, 20);
            this.PoleWiadomosc.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(78)))), ((int)(((byte)(92)))));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(637, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ostatni obrazek:";
            // 
            // OknoChat
            // 
            this.OknoChat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(78)))), ((int)(((byte)(92)))));
            this.OknoChat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OknoChat.ForeColor = System.Drawing.Color.White;
            this.OknoChat.FormattingEnabled = true;
            this.OknoChat.Location = new System.Drawing.Point(126, 24);
            this.OknoChat.Name = "OknoChat";
            this.OknoChat.Size = new System.Drawing.Size(503, 299);
            this.OknoChat.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(9, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Rozłączony";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(78)))), ((int)(((byte)(92)))));
            this.panel1.Location = new System.Drawing.Point(123, -29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(761, 413);
            this.panel1.TabIndex = 10;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Aplikacja_MouseDown);
            // 
            // button1
            // 
            this.button1.Image = global::ChatClient.Properties.Resources.closebutton;
            this.button1.ImageHover = null;
            this.button1.ImageNormal = null;
            this.button1.Location = new System.Drawing.Point(92, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 23);
            this.button1.TabIndex = 13;
            this.button1.TabStop = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Wyslij
            // 
            this.Wyslij.Image = global::ChatClient.Properties.Resources.sendmessage;
            this.Wyslij.ImageHover = null;
            this.Wyslij.ImageNormal = null;
            this.Wyslij.Location = new System.Drawing.Point(12, 339);
            this.Wyslij.Name = "Wyslij";
            this.Wyslij.Size = new System.Drawing.Size(104, 25);
            this.Wyslij.TabIndex = 12;
            this.Wyslij.TabStop = false;
            this.Wyslij.Click += new System.EventHandler(this.Wyslij_Click);
            // 
            // PicSendBut
            // 
            this.PicSendBut.Image = global::ChatClient.Properties.Resources.sendimage1;
            this.PicSendBut.ImageHover = null;
            this.PicSendBut.ImageNormal = null;
            this.PicSendBut.Location = new System.Drawing.Point(12, 308);
            this.PicSendBut.Name = "PicSendBut";
            this.PicSendBut.Size = new System.Drawing.Size(104, 25);
            this.PicSendBut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicSendBut.TabIndex = 11;
            this.PicSendBut.TabStop = false;
            this.PicSendBut.Click += new System.EventHandler(this.PicSendBut_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // OknoObrazka
            // 
            this.OknoObrazka.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(78)))), ((int)(((byte)(92)))));
            this.OknoObrazka.Location = new System.Drawing.Point(640, 24);
            this.OknoObrazka.Name = "OknoObrazka";
            this.OknoObrazka.Size = new System.Drawing.Size(226, 339);
            this.OknoObrazka.TabIndex = 1;
            this.OknoObrazka.TabStop = false;
            // 
            // Aplikacja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(878, 377);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Wyslij);
            this.Controls.Add(this.PicSendBut);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OknoChat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OknoObrazka);
            this.Controls.Add(this.PoleWiadomosc);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Aplikacja";
            this.Text = "Aplikacja";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Aplikacja_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.button1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wyslij)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSendBut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OknoObrazka)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PoleWiadomosc;
        private System.Windows.Forms.PictureBox OknoObrazka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox OknoChat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private CustomButton.UserControl1 PicSendBut;
        private CustomButton.UserControl1 Wyslij;
        private CustomButton.UserControl1 button1;
    }
}