using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace At_Yarısı
{
    public partial class basla : Form
    {
        public basla()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
      

            Form1 fr = new Form1();

            string secim;


            fr.secim = textBox1.Text;


            fr.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void basla_Load(object sender, EventArgs e)
        {

        }
    }
}
