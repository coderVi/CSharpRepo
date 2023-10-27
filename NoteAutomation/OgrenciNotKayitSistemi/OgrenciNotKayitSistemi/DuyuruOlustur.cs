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
    public partial class DuyuruOlustur : Form
    {
        public DuyuruOlustur()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        void listele()
        {
            SqlCommand komut = new SqlCommand("select * from Tbl_Duyurular", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DuyuruOlustur_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komutekle = new SqlCommand("insert into Tbl_Duyurular (Duyuruicerik) values (@p1)", bgl.baglanti());
            komutekle.Parameters.AddWithValue("@p1", richTextBox1.Text);
            komutekle.ExecuteNonQuery();
            MessageBox.Show("Duyuru Sisteme Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bgl.baglanti().Close();
            listele();
            richTextBox1.Clear();
        }

        string id;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            richTextBox1.Text= dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            this.Text = id;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komutsil = new SqlCommand("Delete from Tbl_Duyurular where ID=@p1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@p1",id);
            komutsil.ExecuteNonQuery();
            MessageBox.Show("Duyuru Sistemden Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            bgl.baglanti().Close();
            listele();
            richTextBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand komutguncelle = new SqlCommand("update Tbl_Duyurular set Duyuruicerik=@p1 where ID=@p2", bgl.baglanti());
            komutguncelle.Parameters.AddWithValue("@p1", richTextBox1.Text);
            komutguncelle.Parameters.AddWithValue("@p2", id);
            komutguncelle.ExecuteNonQuery();
            MessageBox.Show("Duyuru Sistemde Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            bgl.baglanti().Close();
            listele();
            richTextBox1.Clear();
        }
    }
}
