using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Form2 form2 = new Form2();
        Form3 form3 = new Form3();
        Form4 form4 = new Form4();
        Form5 form5 = new Form5();
        Form6 form6 = new Form6();
        Form7 form7 = new Form7();
        Form8 form8 = new Form8();
        
        

        private void button1_Click(object sender, EventArgs e)
        {
            string bolgeler = comboBox1.Text;
             
            /* 
            string olarak tanımladığım " bolgeler " değişkenini combo box ile eşleştiriliyor ve devamında 
            aşağıda ki gibi Switch anahtarının içine bolgeler değişkenini atıyoruz case ile açmış olduğumuz 
            ve combobox a manuel olarak eklediğimiz Bölgeler seçilince form**.Show(); komutu ile açıp this.Hide ile
            önce ki pencereyi gizliyoruz. 
             */
            switch(bolgeler)
            {
                case "Marmara Bölgesi": 
                    form2.Show(); this.Hide();
                        break;
                case "Ege Bölgesi":
                    form3.Show(); this.Hide();
                    break;
                case "İç Anadolu Bölgesi":
                    form4.Show(); this.Hide();
                    break;
                case "Karadeniz Bölgesi":
                    form5.Show(); this.Hide();
                    break;
                case "Doğu Anadolu Bölgesi":
                    form6.Show(); this.Hide();
                    break;
                case "Akdeniz Bölgesi":
                    form7.Show(); this.Hide();
                    break;
                case "Güneydoğu Anadolu Bölgesi":
                    form8.Show(); this.Hide();
                    break;
            }
        }
    }
}
