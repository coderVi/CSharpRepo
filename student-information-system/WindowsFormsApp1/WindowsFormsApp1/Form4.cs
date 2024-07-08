using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        double s1, s2, s3, ort;
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            s1 = Convert.ToDouble(textBox1.Text);
            s2 = Convert.ToDouble(textBox2.Text);
            s3 = Convert.ToDouble(textBox3.Text);

            s1 = s1 * 0.10;
            s2 = s2 * 0.30;
            s3 = s3 * 0.60;

            ort = s1 + s2 + s3;

            if(ort >= 90)
            {
                label6.Text = ($"Tebrikler Notunuz :{ort} Geçtiniz");
                label6.BackColor = Color.Green;
            }

            else if(ort >= 80)
            {
                label6.Text = ($"Tebrikler Notunuz :{ort} Geçtiniz");
                label6.BackColor = Color.Green;
            }

            else if (ort >=70)
            {
                label6.Text = ($"Tebrikler Notunuz :{ort} Geçtiniz");
                label6.BackColor = Color.Green;
            }

            else if (ort >=60)
            {
                label6.Text = ($"Tebrikler Notunuz :{ort} Geçtiniz");
                label6.BackColor = Color.Green;
            }

            else if (ort >= 50)
            {
                label6.Text = ($"Tebrikler Notunuz :{ort} Geçtiniz");
                label6.BackColor = Color.Green;
            }

            else
            {
                label6.Text = ($"Notunuz : {ort} Kaldınız");
                label6.BackColor = Color.Red;
            }
        }
    }
}
