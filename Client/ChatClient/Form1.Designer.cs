namespace ChatClient
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.AdresIP = new System.Windows.Forms.TextBox();
            this.Portt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userControl12 = new CustomButton.UserControl1();
            this.userControl11 = new CustomButton.UserControl1();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.userControl12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userControl11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AdresIP
            // 
            this.AdresIP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(18)))), ((int)(((byte)(22)))));
            this.AdresIP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AdresIP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.AdresIP.Location = new System.Drawing.Point(70, 187);
            this.AdresIP.MaxLength = 15;
            this.AdresIP.Name = "AdresIP";
            this.AdresIP.Size = new System.Drawing.Size(169, 13);
            this.AdresIP.TabIndex = 2;
            this.AdresIP.Text = "127.0.0.1";
            // 
            // Portt
            // 
            this.Portt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(18)))), ((int)(((byte)(22)))));
            this.Portt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Portt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.Portt.Location = new System.Drawing.Point(70, 221);
            this.Portt.MaxLength = 8;
            this.Portt.Name = "Portt";
            this.Portt.Size = new System.Drawing.Size(169, 13);
            this.Portt.TabIndex = 6;
            this.Portt.Text = "5000";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(27, 178);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "IP:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(10, 212);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 28);
            this.label2.TabIndex = 8;
            this.label2.Text = "Port:";
            // 
            // userControl12
            // 
            this.userControl12.Image = global::ChatClient.Properties.Resources.closebutton;
            this.userControl12.ImageHover = null;
            this.userControl12.ImageNormal = null;
            this.userControl12.Location = new System.Drawing.Point(276, 324);
            this.userControl12.Name = "userControl12";
            this.userControl12.Size = new System.Drawing.Size(24, 23);
            this.userControl12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.userControl12.TabIndex = 11;
            this.userControl12.TabStop = false;
            this.userControl12.Click += new System.EventHandler(this.userControl12_Click);
            // 
            // userControl11
            // 
            this.userControl11.Image = global::ChatClient.Properties.Resources.buttonconnect;
            this.userControl11.ImageHover = null;
            this.userControl11.ImageNormal = null;
            this.userControl11.Location = new System.Drawing.Point(70, 260);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(153, 26);
            this.userControl11.TabIndex = 10;
            this.userControl11.TabStop = false;
            this.userControl11.Click += new System.EventHandler(this.userControl11_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(70, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(310, 359);
            this.Controls.Add(this.userControl12);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Portt);
            this.Controls.Add(this.AdresIP);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start";
            ((System.ComponentModel.ISupportInitialize)(this.userControl12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userControl11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox AdresIP;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Portt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private CustomButton.UserControl1 userControl11;
        private CustomButton.UserControl1 userControl12;
    }
}

