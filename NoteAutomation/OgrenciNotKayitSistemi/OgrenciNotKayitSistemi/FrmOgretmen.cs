using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace OgrenciNotKayitSistemi
{
    public partial class FrmOgretmen : Form
    {
        
        public FrmOgretmen()
        {
            InitializeComponent();
        }
        public string numara;

        sqlbaglantisi bgl = new sqlbaglantisi();
        string fotograf;
        

        void Listele()
        {
            SqlCommand komut = new SqlCommand("select * from Tbl_Ogrenci", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void Not_Listele()
        {
            SqlCommand komut = new SqlCommand("Execute Ogrenci", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }


        private void FrmOgretmen_Load(object sender, EventArgs e)
        {
            lblNumara.Text = numara;
            SqlCommand komut = new SqlCommand("select * from Tbl_Ogretmenler where Numara=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", Convert.ToInt32(numara));
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lbladsoyad.Text = dr[1] + " " + dr[2];
            }
            bgl.baglanti().Close();
            Listele();
            Not_Listele();
        }

        private void btnFotoEkle_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            fotograf = openFileDialog1.FileName;
            pictureBox1.ImageLocation = fotograf;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komutekle = new SqlCommand("insert into Tbl_Ogrenci (Ad,Soyad,Numara,Sifre,Fotograf) values (@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
            komutekle.Parameters.AddWithValue("@p1", txtogrenciad.Text);
            komutekle.Parameters.AddWithValue("@p2", txtogrencisoyad.Text);
            komutekle.Parameters.AddWithValue("@p3", maskedTxtOgrenci.Text);
            komutekle.Parameters.AddWithValue("@p4", txtogrencisifre.Text);
            komutekle.Parameters.AddWithValue("@p5", fotograf);
            komutekle.ExecuteNonQuery();
            MessageBox.Show("Öğrenci Sisteme Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bgl.baglanti().Close();
            Listele();
            Not_Listele();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double sinav1, sinav2, sinav3, proje, ortalama;
            sinav1 = Convert.ToDouble(txtsinav1.Text);
            sinav2 = Convert.ToDouble(txtsinav2.Text);
            sinav3 = Convert.ToDouble(txtsinav3.Text);
            proje = Convert.ToDouble(txtproje.Text);
            ortalama = (sinav1 + sinav2 + sinav3 + proje) / 4;
            txtortama.Text = ortalama.ToString();
            if (ortalama >= 50) txtdurum.Text = "True";
            else txtdurum.Text = "false";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtogrenciad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtogrencisoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            maskedTxtOgrenci.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtogrencisifre.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            pictureBox1.ImageLocation = dataGridView1.Rows[secilen].Cells[5].Value.ToString();

            SqlCommand komut2 = new SqlCommand("select * from Tbl_Notlar where ID=(select ID from Tbl_Ogrenci where Numara=@p1)", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", maskedTxtOgrenci.Text);
            SqlDataReader dr = komut2.ExecuteReader();
            while (dr.Read())
            {
                txtsinav1.Text = dr[1].ToString();
                txtsinav2.Text = dr[2].ToString();
                txtsinav3.Text = dr[3].ToString();
                txtproje.Text = dr[4].ToString();
                txtortama.Text = dr[5].ToString();
                txtdurum.Text = dr[6].ToString();

            }
            bgl.baglanti().Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            // Öğrenci Bilgileri Güncelleme
            
            SqlCommand komutguncelle = new SqlCommand("update Tbl_Ogrenci set Ad=@p1,Soyad=@p2,Sifre=@p3,Fotograf=@p4 where Numara=@p5", bgl.baglanti());
            komutguncelle.Parameters.AddWithValue("@p1", txtogrenciad.Text);
            komutguncelle.Parameters.AddWithValue("@p2", txtogrencisoyad.Text);
            komutguncelle.Parameters.AddWithValue("@p3", txtogrencisifre.Text);
            komutguncelle.Parameters.AddWithValue("@p4", fotograf);
            komutguncelle.Parameters.AddWithValue("@p5", maskedTxtOgrenci.Text);
            komutguncelle.ExecuteNonQuery();

            MessageBox.Show("Öğrenci Bilgileri Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bgl.baglanti().Close();
            Listele();
            Not_Listele();


            //Not Bilgileri Güncelleme
            SqlCommand komut3 = new SqlCommand("update Tbl_Notlar set Sinav1=@p1,Sinav2=@p2,Sinav3=@p3,Proje=@p4,Ortalama=@p5,Durum=@p6 where ID=(select ID from Tbl_Ogrenci where Numara=@p7)",bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", txtsinav1.Text);
            komut3.Parameters.AddWithValue("@p2", txtsinav2.Text);
            komut3.Parameters.AddWithValue("@p3", txtsinav3.Text);
            komut3.Parameters.AddWithValue("@p4", txtproje.Text);
            komut3.Parameters.AddWithValue("@p5", Convert.ToDecimal(txtortama.Text));
            komut3.Parameters.AddWithValue("@p6", txtdurum.Text);
            komut3.Parameters.AddWithValue("@p7", maskedTxtOgrenci.Text);
            komut3.ExecuteNonQuery();

            MessageBox.Show("Öğrenci Sınav Bilgileri Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bgl.baglanti().Close();
            Listele();
            Not_Listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DuyuruOlustur frm = new DuyuruOlustur();
            frm.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DuyuruListele frm = new DuyuruListele();
            frm.Show();
        }
       
        private void button3_Click(object sender, EventArgs e)
        {
            Mesajlar frm = new Mesajlar();
            frm.numara = lblNumara.Text;
            frm.Show();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
