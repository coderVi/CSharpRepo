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
   
    public partial class Form1 : Form
    {
 
        public Form1()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        public string numara;


        private void btnOgrenciGiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from Tbl_Ogrenci where Numara=@p1 and Sifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskdtxtOgrenci.Text);
            komut.Parameters.AddWithValue("@p2", txtOgrenciSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                OgrenciFormu frm = new OgrenciFormu();
                frm.numara = mskdtxtOgrenci.Text;
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Numara ya da Şifre", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            bgl.baglanti().Close();

        }
    

        private void btnOgretmenGiris_Click(object sender, EventArgs e)
        {
            
            SqlCommand komut = new SqlCommand("select * from Tbl_Ogretmenler where Numara=@p1 and Sifre=@p2",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskdtxtOgretmen.Text);
            komut.Parameters.AddWithValue("@p2", txtOgretmeSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmOgretmen frm = new FrmOgretmen();
                frm.numara = mskdtxtOgretmen.Text;
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Numara ya da Şifre", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            bgl.baglanti().Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
    class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=localhost;Initial Catalog=OgrenciNotKayıt;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }

}
