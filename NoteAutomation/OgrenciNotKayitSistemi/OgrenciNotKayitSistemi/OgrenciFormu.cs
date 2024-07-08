using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciNotKayitSistemi
{
    public partial class OgrenciFormu : Form
    {
        public OgrenciFormu()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        public string numara;
        private void btnListele_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Gerçekten Kapatmak İstiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DuyuruListele frm = new DuyuruListele();
            frm.Show();
        }

        private void OgrenciFormu_Load(object sender, EventArgs e)
        {
            lblNumara.Text = numara;
            SqlCommand komut = new SqlCommand("select * from Tbl_Ogrenci where Numara=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", Convert.ToInt32(numara));
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lbladsoyad.Text = dr[1] + " " + dr[2];
                pictureBox1.ImageLocation = dr[5].ToString();
            }
            bgl.baglanti().Close();
            Not_listele();
        }
        void Not_listele()
        {
            SqlCommand komut2 = new SqlCommand("select * from Tbl_Notlar where ID=(select ID from Tbl_Ogrenci where Numara=@p1)", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", numara);
            SqlDataReader dr = komut2.ExecuteReader();
            while (dr.Read())
            {
                label3.Text = dr[1].ToString();
                label4.Text = dr[2].ToString();
                label5.Text = dr[3].ToString();
                label6.Text = dr[4].ToString();
                label7.Text = dr[5].ToString();


            }
            bgl.baglanti().Close();

            if (Convert.ToDouble(label7.Text) >= 50)
            {
                label8.Text = "Geçti";
            }
            else label8.Text = "Kaldı";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Mesajlar frm = new Mesajlar();
            frm.numara = lblNumara.Text;
            frm.Show();
        }
    }
}
