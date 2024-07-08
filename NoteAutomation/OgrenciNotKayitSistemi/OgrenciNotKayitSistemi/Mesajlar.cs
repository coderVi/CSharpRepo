using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciNotKayitSistemi
{
    public partial class Mesajlar : Form
    {
        sqlbaglantisi bgl = new sqlbaglantisi();
        public string numara;
        public Mesajlar()
        {
            InitializeComponent();
        }

        private void Mesajlar_Load(object sender, EventArgs e)
        {
            maskedTextBox1.Text = numara;
            GelenMesajlar();
            GidenMEsajlar();
        }
        void GelenMesajlar()
        {
            SqlCommand cmd = new SqlCommand("select * from Tbl_Mesajlar where Alici=@p1", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", numara);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void GidenMEsajlar()
        {
            SqlCommand cmd = new SqlCommand("select * from Tbl_Mesajlar where Gonderen=@p1", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", numara);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmdekle = new SqlCommand("insert into Tbl_Mesajlar(Gonderen,Alici,Baslik,İcerik) values (@p1,@p2,@p3,@p4)", bgl.baglanti());
            cmdekle.Parameters.AddWithValue("@p1", maskedTextBox1.Text);
            cmdekle.Parameters.AddWithValue("@p2", maskedTextBox2.Text);
            cmdekle.Parameters.AddWithValue("@p3", textBox4.Text);
            cmdekle.Parameters.AddWithValue("@p4", textBox1.Text);
            cmdekle.ExecuteNonQuery();
            MessageBox.Show("Mesajınız iletildi...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bgl.baglanti().Close();
            GelenMesajlar();
            GidenMEsajlar();
            temizle();
        }
        void temizle()
        {
            maskedTextBox2.Clear();
            textBox1.Clear();
            textBox4.Clear();
        }
    }
}
