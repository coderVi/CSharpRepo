using System;
using System.Collections;
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
    public partial class DuyuruListele : Form
    {
        public DuyuruListele()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        private void DuyuruListele_Load(object sender, EventArgs e)
        {
            ListBox list = new ListBox();
            Point listkonum = new Point(10, 10);
            list.Name = "ListBox1";
            list.Height = 200;
            list.Width = 150;
            list.Location = listkonum;
            this.Controls.Add(list);

            SqlCommand cmd = new SqlCommand("select * from Tbl_Duyurular", bgl.baglanti());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                list.Items.Add(dr[0] + " " + dr[1]);
            }
            bgl.baglanti().Close();

        }
    }
}
