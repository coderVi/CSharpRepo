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

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        SqlCommand cmd;
        SqlDataReader dr;
        DataTable dt;
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-OH4B9H3\\SQLEXPRESS; Initial Catalog=Kitaplik; Integrated Security=True");
        public Form1()
        {
            InitializeComponent();

        }


        void Liste()
        {
            baglanti.Open();
            cmd = new SqlCommand("SELECT Tbl_Kitaplik.Id, Tbl_Kitaplik.kitapAdi, Tbl_Kitaplik.yazari, Tbl_Kitaplik.fiyati, Tbl_tur.turAdi FROM Tbl_Kitaplik INNER JOIN Tbl_tur ON Tbl_Kitaplik.tur = Tbl_tur.TurId", baglanti);
            dr = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            dr.Close();
            baglanti.Close();
        }
        void Ekleme()
        {
            baglanti.Open();

            string sorgu = "INSERT INTO Tbl_Kitaplik (kitapAdi, yazari, fiyati, tur) VALUES (@kitapAdi, @yazari, @fiyati, @tur)";

            cmd = new SqlCommand(sorgu, baglanti);

            cmd.Parameters.AddWithValue("@kitapAdi", kitapAditb.Text);
            cmd.Parameters.AddWithValue("@yazari", yazaritb.Text);
            cmd.Parameters.AddWithValue("@fiyati", fiyatitb.Text);
            cmd.Parameters.AddWithValue("@tur", turucb.Text);

            int etkilenenSatirSayisi = cmd.ExecuteNonQuery();


            baglanti.Close();

            if (etkilenenSatirSayisi > 0)
            {
                MessageBox.Show("Kitap eklendi.");
                Liste();
            }
            else
            {
                MessageBox.Show("Kitap eklenirken bir hata oluştu.");
            }
            Liste();
        }
        void Silme()
        {
            
            if (dataGridView1.SelectedRows.Count > 0) // Seçili bir satır varsa
            {
                int seciliSatirIndex = dataGridView1.SelectedRows[0].Index; // Seçili satırın index değerini al

                int kitapId = Convert.ToInt32(dataGridView1.Rows[seciliSatirIndex].Cells["ID"].Value); // Seçili satırdaki ID değerini al

                baglanti.Open();

                string sorgu = "DELETE FROM Tbl_Kitaplik WHERE ID = @id"; // Sileceğimiz kaydın ID'sine göre sorguyu oluştur

                cmd = new SqlCommand(sorgu, baglanti);

                cmd.Parameters.AddWithValue("@id", kitapId); // Parametre olarak silinecek kaydın ID'sini ekler

                int etkilenenSatirSayisi = cmd.ExecuteNonQuery(); // Sorguyu çalıştırıp etkilenen satır sayısını alır

                baglanti.Close();

                if (etkilenenSatirSayisi > 0)
                {
                    MessageBox.Show("Kayıt silindi.");
                    Liste();
                }
                else
                {
                    MessageBox.Show("Kayıt silinirken bir hata oluştu.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen silinecek kaydı seçiniz.");
            }


        }
       

        private void button4_Click(object sender, EventArgs e)
        {
            Liste();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ekleme();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Silme();
        }
    }
}
