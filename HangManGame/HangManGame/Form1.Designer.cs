namespace HangManGame
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.lblKelime = new System.Windows.Forms.Label();
            this.btnBaslat = new System.Windows.Forms.Button();
            this.txtGirilenHarf = new System.Windows.Forms.TextBox();
            this.lblHarfGiriniz = new System.Windows.Forms.Label();
            this.btnKontrol = new System.Windows.Forms.Button();
            this.lblIpucu = new System.Windows.Forms.Label();
            this.lblHak = new System.Windows.Forms.Label();
            this.lblTamTahmin = new System.Windows.Forms.Label();
            this.txtTamTahmin = new System.Windows.Forms.TextBox();
            this.btnTamKontrol = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(11, 12);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(445, 554);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // lblKelime
            // 
            this.lblKelime.AutoSize = true;
            this.lblKelime.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKelime.Location = new System.Drawing.Point(552, 72);
            this.lblKelime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKelime.Name = "lblKelime";
            this.lblKelime.Size = new System.Drawing.Size(317, 40);
            this.lblKelime.TabIndex = 0;
            this.lblKelime.Text = "0yuna Hoş Geldiniz!";
            this.lblKelime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblKelime.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnBaslat
            // 
            this.btnBaslat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnBaslat.Location = new System.Drawing.Point(615, 486);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(189, 54);
            this.btnBaslat.TabIndex = 3;
            this.btnBaslat.Text = "Oyunu Başlat";
            this.btnBaslat.UseVisualStyleBackColor = false;
            this.btnBaslat.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtGirilenHarf
            // 
            this.txtGirilenHarf.Location = new System.Drawing.Point(764, 202);
            this.txtGirilenHarf.Name = "txtGirilenHarf";
            this.txtGirilenHarf.Size = new System.Drawing.Size(58, 39);
            this.txtGirilenHarf.TabIndex = 4;
            this.txtGirilenHarf.Visible = false;
            // 
            // lblHarfGiriniz
            // 
            this.lblHarfGiriniz.AutoSize = true;
            this.lblHarfGiriniz.Location = new System.Drawing.Point(591, 205);
            this.lblHarfGiriniz.Name = "lblHarfGiriniz";
            this.lblHarfGiriniz.Size = new System.Drawing.Size(167, 35);
            this.lblHarfGiriniz.TabIndex = 5;
            this.lblHarfGiriniz.Text = "Harf Giriniz:";
            this.lblHarfGiriniz.Visible = false;
            // 
            // btnKontrol
            // 
            this.btnKontrol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnKontrol.Location = new System.Drawing.Point(597, 257);
            this.btnKontrol.Name = "btnKontrol";
            this.btnKontrol.Size = new System.Drawing.Size(225, 49);
            this.btnKontrol.TabIndex = 6;
            this.btnKontrol.Text = "Kontrol";
            this.btnKontrol.UseVisualStyleBackColor = false;
            this.btnKontrol.Visible = false;
            this.btnKontrol.Click += new System.EventHandler(this.bntKontrol_Click);
            // 
            // lblIpucu
            // 
            this.lblIpucu.AutoSize = true;
            this.lblIpucu.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIpucu.Location = new System.Drawing.Point(581, 134);
            this.lblIpucu.Name = "lblIpucu";
            this.lblIpucu.Size = new System.Drawing.Size(72, 27);
            this.lblIpucu.TabIndex = 7;
            this.lblIpucu.Text = "İpucu:";
            this.lblIpucu.Visible = false;
            // 
            // lblHak
            // 
            this.lblHak.AutoSize = true;
            this.lblHak.Location = new System.Drawing.Point(626, 438);
            this.lblHak.Name = "lblHak";
            this.lblHak.Size = new System.Drawing.Size(168, 35);
            this.lblHak.TabIndex = 8;
            this.lblHak.Text = "Kalan Hak: 7";
            this.lblHak.Visible = false;
            // 
            // lblTamTahmin
            // 
            this.lblTamTahmin.AutoSize = true;
            this.lblTamTahmin.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTamTahmin.Location = new System.Drawing.Point(532, 352);
            this.lblTamTahmin.Name = "lblTamTahmin";
            this.lblTamTahmin.Size = new System.Drawing.Size(347, 23);
            this.lblTamTahmin.TabIndex = 9;
            this.lblTamTahmin.Text = "(Kelimeyi tahmin etmek istiyorsan aşağı yazabiliirsin!)";
            this.lblTamTahmin.Visible = false;
            // 
            // txtTamTahmin
            // 
            this.txtTamTahmin.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTamTahmin.Location = new System.Drawing.Point(597, 389);
            this.txtTamTahmin.Name = "txtTamTahmin";
            this.txtTamTahmin.Size = new System.Drawing.Size(178, 35);
            this.txtTamTahmin.TabIndex = 10;
            this.txtTamTahmin.Visible = false;
            this.txtTamTahmin.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnTamKontrol
            // 
            this.btnTamKontrol.BackColor = System.Drawing.Color.Lime;
            this.btnTamKontrol.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTamKontrol.Location = new System.Drawing.Point(781, 389);
            this.btnTamKontrol.Name = "btnTamKontrol";
            this.btnTamKontrol.Size = new System.Drawing.Size(41, 35);
            this.btnTamKontrol.TabIndex = 11;
            this.btnTamKontrol.Text = "✓";
            this.btnTamKontrol.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTamKontrol.UseVisualStyleBackColor = false;
            this.btnTamKontrol.Visible = false;
            this.btnTamKontrol.Click += new System.EventHandler(this.btnTamKontrol_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(951, 578);
            this.Controls.Add(this.btnTamKontrol);
            this.Controls.Add(this.txtTamTahmin);
            this.Controls.Add(this.lblTamTahmin);
            this.Controls.Add(this.lblHak);
            this.Controls.Add(this.lblIpucu);
            this.Controls.Add(this.btnKontrol);
            this.Controls.Add(this.lblHarfGiriniz);
            this.Controls.Add(this.txtGirilenHarf);
            this.Controls.Add(this.btnBaslat);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.lblKelime);
            this.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HangMan Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label lblKelime;
        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.TextBox txtGirilenHarf;
        private System.Windows.Forms.Label lblHarfGiriniz;
        private System.Windows.Forms.Button btnKontrol;
        private System.Windows.Forms.Label lblIpucu;
        private System.Windows.Forms.Label lblHak;
        private System.Windows.Forms.Label lblTamTahmin;
        private System.Windows.Forms.TextBox txtTamTahmin;
        private System.Windows.Forms.Button btnTamKontrol;
    }
}

