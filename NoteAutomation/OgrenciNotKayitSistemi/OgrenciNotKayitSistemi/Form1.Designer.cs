namespace OgrenciNotKayitSistemi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mskdtxtOgretmen = new System.Windows.Forms.MaskedTextBox();
            this.txtOgretmeSifre = new System.Windows.Forms.TextBox();
            this.btnOgretmenGiris = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mskdtxtOgrenci = new System.Windows.Forms.MaskedTextBox();
            this.txtOgrenciSifre = new System.Windows.Forms.TextBox();
            this.btnOgrenciGiris = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.mskdtxtOgretmen);
            this.groupBox1.Controls.Add(this.txtOgretmeSifre);
            this.groupBox1.Controls.Add(this.btnOgretmenGiris);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 198);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğretmen Giriş Ekranı";
            // 
            // mskdtxtOgretmen
            // 
            this.mskdtxtOgretmen.Location = new System.Drawing.Point(179, 67);
            this.mskdtxtOgretmen.Mask = "0000";
            this.mskdtxtOgretmen.Name = "mskdtxtOgretmen";
            this.mskdtxtOgretmen.Size = new System.Drawing.Size(100, 26);
            this.mskdtxtOgretmen.TabIndex = 7;
            this.mskdtxtOgretmen.Text = "1111";
            this.mskdtxtOgretmen.ValidatingType = typeof(int);
            // 
            // txtOgretmeSifre
            // 
            this.txtOgretmeSifre.Location = new System.Drawing.Point(179, 117);
            this.txtOgretmeSifre.Name = "txtOgretmeSifre";
            this.txtOgretmeSifre.PasswordChar = '*';
            this.txtOgretmeSifre.Size = new System.Drawing.Size(100, 26);
            this.txtOgretmeSifre.TabIndex = 8;
            this.txtOgretmeSifre.Text = "0000";
            // 
            // btnOgretmenGiris
            // 
            this.btnOgretmenGiris.Location = new System.Drawing.Point(196, 157);
            this.btnOgretmenGiris.Name = "btnOgretmenGiris";
            this.btnOgretmenGiris.Size = new System.Drawing.Size(83, 35);
            this.btnOgretmenGiris.TabIndex = 1;
            this.btnOgretmenGiris.Text = "Giriş Yap";
            this.btnOgretmenGiris.UseVisualStyleBackColor = true;
            this.btnOgretmenGiris.Click += new System.EventHandler(this.btnOgretmenGiris_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-1, 46);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(114, 123);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numara:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.mskdtxtOgrenci);
            this.groupBox2.Controls.Add(this.txtOgrenciSifre);
            this.groupBox2.Controls.Add(this.btnOgrenciGiris);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(12, 216);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(314, 198);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Öğrenci Giriş Ekranı";
            // 
            // mskdtxtOgrenci
            // 
            this.mskdtxtOgrenci.Location = new System.Drawing.Point(208, 74);
            this.mskdtxtOgrenci.Mask = "0000";
            this.mskdtxtOgrenci.Name = "mskdtxtOgrenci";
            this.mskdtxtOgrenci.Size = new System.Drawing.Size(100, 26);
            this.mskdtxtOgrenci.TabIndex = 8;
            this.mskdtxtOgrenci.Text = "1111";
            this.mskdtxtOgrenci.ValidatingType = typeof(int);
            // 
            // txtOgrenciSifre
            // 
            this.txtOgrenciSifre.Location = new System.Drawing.Point(208, 117);
            this.txtOgrenciSifre.Name = "txtOgrenciSifre";
            this.txtOgrenciSifre.PasswordChar = '*';
            this.txtOgrenciSifre.Size = new System.Drawing.Size(100, 26);
            this.txtOgrenciSifre.TabIndex = 5;
            this.txtOgrenciSifre.Text = "1212";
            // 
            // btnOgrenciGiris
            // 
            this.btnOgrenciGiris.Location = new System.Drawing.Point(192, 157);
            this.btnOgrenciGiris.Name = "btnOgrenciGiris";
            this.btnOgrenciGiris.Size = new System.Drawing.Size(88, 35);
            this.btnOgrenciGiris.TabIndex = 1;
            this.btnOgrenciGiris.Text = "Giriş Yap";
            this.btnOgrenciGiris.UseVisualStyleBackColor = true;
            this.btnOgrenciGiris.Click += new System.EventHandler(this.btnOgrenciGiris_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(135, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 19);
            this.label7.TabIndex = 2;
            this.label7.Text = "Şifre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(135, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Numara:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(336, 424);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Öğrenci Not Sistemi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtOgretmeSifre;
        private System.Windows.Forms.Button btnOgretmenGiris;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtOgrenciSifre;
        private System.Windows.Forms.Button btnOgrenciGiris;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mskdtxtOgretmen;
        private System.Windows.Forms.MaskedTextBox mskdtxtOgrenci;
    }
}

