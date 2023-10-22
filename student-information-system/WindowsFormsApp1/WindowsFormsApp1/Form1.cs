using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vıttırı vızzık koşullar.", "Kurallar", MessageBoxButtons.OK, MessageBoxIcon.Information);

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kadi, passwd;

            kadi = textBox1.Text;
            passwd = textBox2.Text;

            if (kadi == "admin" && passwd == "123456")
            {
                MessageBox.Show("Giriş Başarılı", "Durum", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı","Durum",MessageBoxButtons.OK,MessageBoxIcon.Error);
                textBox1.Clear();
                textBox2.Clear();
            }

        }
    }
}
