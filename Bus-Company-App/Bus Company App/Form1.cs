using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bus_Company_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Passenger Information : ");
            listBox1.Items.Add("Name : " + textBox1.Text + "  Surname : " + textBox2.Text + " ID Number : " + textBox3.Text + " Contact Number : " + maskedTextBox1.Text );
            listBox1.Items.Add("");
            listBox1.Items.Add("Expedition Information");
            listBox1.Items.Add("Where : " + comboBox1.Text + " To Where : " + comboBox2.Text + " History : " + maskedTextBox2.Text + " Hour : " + maskedTextBox3.Text );
            listBox1.Items.Add("");
        }
    }
}
