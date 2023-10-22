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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Multiline özelliği box ın şeklini farklı şekilde büyükmemizi sağlıyor.
            textBox1.Multiline = true;
            //Scroll Bars komutu ise kaydırma çubuğu aktif etmek için kullanılıyor.
            textBox1.ScrollBars = ScrollBars.Vertical;

        }
    }
}
