namespace Uçak_Bileti_Otomasyonu
{
    partial class KullaniciGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciGiris));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDogrulama = new System.Windows.Forms.Label();
            this.lblHata = new System.Windows.Forms.Label();
            this.exHata = new System.Windows.Forms.Label();
            this.txtKullaniciadi = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(115, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(150, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre";
            // 
            // lblDogrulama
            // 
            this.lblDogrulama.AutoSize = true;
            this.lblDogrulama.Location = new System.Drawing.Point(80, 233);
            this.lblDogrulama.Name = "lblDogrulama";
            this.lblDogrulama.Size = new System.Drawing.Size(0, 13);
            this.lblDogrulama.TabIndex = 3;
            // 
            // lblHata
            // 
            this.lblHata.AutoSize = true;
            this.lblHata.Location = new System.Drawing.Point(150, 242);
            this.lblHata.Name = "lblHata";
            this.lblHata.Size = new System.Drawing.Size(0, 13);
            this.lblHata.TabIndex = 4;
            // 
            // exHata
            // 
            this.exHata.AutoSize = true;
            this.exHata.Location = new System.Drawing.Point(105, 233);
            this.exHata.Name = "exHata";
            this.exHata.Size = new System.Drawing.Size(0, 13);
            this.exHata.TabIndex = 5;
            // 
            // txtKullaniciadi
            // 
            this.txtKullaniciadi.Location = new System.Drawing.Point(206, 64);
            this.txtKullaniciadi.Name = "txtKullaniciadi";
            this.txtKullaniciadi.Size = new System.Drawing.Size(133, 20);
            this.txtKullaniciadi.TabIndex = 6;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(206, 109);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(133, 20);
            this.txtSifre.TabIndex = 7;
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.Location = new System.Drawing.Point(264, 159);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(75, 23);
            this.btnGirisYap.TabIndex = 8;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.UseVisualStyleBackColor = true;
            this.btnGirisYap.Click += new System.EventHandler(this.BtnGirisYap_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Location = new System.Drawing.Point(5, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 45);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // KullaniciGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(467, 297);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGirisYap);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullaniciadi);
            this.Controls.Add(this.exHata);
            this.Controls.Add(this.lblHata);
            this.Controls.Add(this.lblDogrulama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KullaniciGiris";
            this.Text = "Kullanıcı Giriş";
            this.Load += new System.EventHandler(this.KullaniciGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDogrulama;
        private System.Windows.Forms.Label lblHata;
        private System.Windows.Forms.Label exHata;
        private System.Windows.Forms.TextBox txtKullaniciadi;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button btnGirisYap;
        private System.Windows.Forms.Button button1;
    }
}