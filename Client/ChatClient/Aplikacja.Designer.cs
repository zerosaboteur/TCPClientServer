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
            this.PoleWiadomosc = new System.Windows.Forms.TextBox();
            this.OknoObrazka = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Wyslij = new System.Windows.Forms.Button();
            this.OknoChat = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.PicSendBut = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.OknoObrazka)).BeginInit();
            this.SuspendLayout();
            // 
            // PoleWiadomosc
            // 
            this.PoleWiadomosc.Location = new System.Drawing.Point(12, 339);
            this.PoleWiadomosc.Name = "PoleWiadomosc";
            this.PoleWiadomosc.Size = new System.Drawing.Size(503, 20);
            this.PoleWiadomosc.TabIndex = 0;
            // 
            // OknoObrazka
            // 
            this.OknoObrazka.Location = new System.Drawing.Point(544, 29);
            this.OknoObrazka.Name = "OknoObrazka";
            this.OknoObrazka.Size = new System.Drawing.Size(198, 299);
            this.OknoObrazka.TabIndex = 1;
            this.OknoObrazka.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(547, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ostatni obrazek:";
            // 
            // Wyslij
            // 
            this.Wyslij.Location = new System.Drawing.Point(521, 336);
            this.Wyslij.Name = "Wyslij";
            this.Wyslij.Size = new System.Drawing.Size(67, 26);
            this.Wyslij.TabIndex = 3;
            this.Wyslij.Text = "Wyslij";
            this.Wyslij.UseVisualStyleBackColor = true;
            this.Wyslij.Click += new System.EventHandler(this.Wyslij_Click);
            // 
            // OknoChat
            // 
            this.OknoChat.FormattingEnabled = true;
            this.OknoChat.Location = new System.Drawing.Point(14, 25);
            this.OknoChat.Name = "OknoChat";
            this.OknoChat.Size = new System.Drawing.Size(501, 303);
            this.OknoChat.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(14, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Rozłączony";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(718, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "⛔";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // PicSendBut
            // 
            this.PicSendBut.Location = new System.Drawing.Point(594, 336);
            this.PicSendBut.Name = "PicSendBut";
            this.PicSendBut.Size = new System.Drawing.Size(85, 26);
            this.PicSendBut.TabIndex = 8;
            this.PicSendBut.Text = "Wyślij zdjęcie";
            this.PicSendBut.UseVisualStyleBackColor = true;
            this.PicSendBut.Click += new System.EventHandler(this.PicSendBut_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Aplikacja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 377);
            this.Controls.Add(this.PicSendBut);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OknoChat);
            this.Controls.Add(this.Wyslij);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OknoObrazka);
            this.Controls.Add(this.PoleWiadomosc);
            this.Name = "Aplikacja";
            this.Text = "Aplikacja";
            ((System.ComponentModel.ISupportInitialize)(this.OknoObrazka)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PoleWiadomosc;
        private System.Windows.Forms.PictureBox OknoObrazka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Wyslij;
        private System.Windows.Forms.ListBox OknoChat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button PicSendBut;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}