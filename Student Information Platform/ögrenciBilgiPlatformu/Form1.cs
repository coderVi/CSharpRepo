using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ögrenciBilgiPlatformu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("İsim : " + textBox1.Text);
            listBox1.Items.Add("Soyisim : " + textBox2.Text);
            listBox1.Items.Add("Cinsiyet : " + comboBox1.Text);
            listBox1.Items.Add("Durum : " + comboBox2.Text);
            listBox1.Items.Add("Telefon Numarası : "+maskedTextBox1.Text);
            listBox1.Items.Add("Doğum Tarihi : " + maskedTextBox2.Text);
        }
    }
}
