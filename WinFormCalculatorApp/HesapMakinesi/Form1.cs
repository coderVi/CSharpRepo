using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        int s1, s2, s3;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            s1 = Convert.ToInt32(textBox1.Text);
            s2 = Convert.ToInt32(textBox2.Text);
            s3 = s1 + s2;
            label4.Text = s3.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            s1 = Convert.ToInt32(textBox1.Text);
            s2 = Convert.ToInt32(textBox2.Text);
            s3 = s1 - s2;
            label4.Text = s3.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            s1 = Convert.ToInt32(textBox1.Text);
            s2 = Convert.ToInt32(textBox2.Text);
            s3 = s1 * s2;
            label4.Text = s3.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            s1 = Convert.ToInt32(textBox1.Text);
            s2 = Convert.ToInt32(textBox2.Text);
            s3 = s1 / s2;
            label4.Text = s3.ToString();
        }
    }
}
