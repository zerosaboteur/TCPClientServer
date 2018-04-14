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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Wyslij = new System.Windows.Forms.Button();
            this.ChatBox = new System.Windows.Forms.TextBox();
            this.OknoChat = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PoleWiadomosc
            // 
            this.PoleWiadomosc.Location = new System.Drawing.Point(12, 410);
            this.PoleWiadomosc.Name = "PoleWiadomosc";
            this.PoleWiadomosc.Size = new System.Drawing.Size(503, 20);
            this.PoleWiadomosc.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(544, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 299);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
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
            this.Wyslij.Location = new System.Drawing.Point(535, 410);
            this.Wyslij.Name = "Wyslij";
            this.Wyslij.Size = new System.Drawing.Size(67, 20);
            this.Wyslij.TabIndex = 3;
            this.Wyslij.Text = "Wyslij";
            this.Wyslij.UseVisualStyleBackColor = true;
            this.Wyslij.Click += new System.EventHandler(this.Wyslij_Click);
            // 
            // ChatBox
            // 
            this.ChatBox.Location = new System.Drawing.Point(14, 11);
            this.ChatBox.Name = "ChatBox";
            this.ChatBox.Size = new System.Drawing.Size(500, 20);
            this.ChatBox.TabIndex = 4;
            // 
            // OknoChat
            // 
            this.OknoChat.FormattingEnabled = true;
            this.OknoChat.Location = new System.Drawing.Point(14, 38);
            this.OknoChat.Name = "OknoChat";
            this.OknoChat.Size = new System.Drawing.Size(501, 290);
            this.OknoChat.TabIndex = 5;
            // 
            // Aplikacja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 442);
            this.Controls.Add(this.OknoChat);
            this.Controls.Add(this.ChatBox);
            this.Controls.Add(this.Wyslij);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PoleWiadomosc);
            this.Name = "Aplikacja";
            this.Text = "Aplikacja";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PoleWiadomosc;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Wyslij;
        private System.Windows.Forms.TextBox ChatBox;
        private System.Windows.Forms.ListBox OknoChat;
    }
}