using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormDegiskenler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int taban, yukseklik, sonuc;
            taban = Int32.Parse(textBox1.Text);
            yukseklik = Int32.Parse(textBox2.Text);

            sonuc = taban * yukseklik;

            textBox3.Text = sonuc.ToString();

            
        }
    }
}
