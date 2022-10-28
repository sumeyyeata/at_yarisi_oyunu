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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int birinciatsolauzaklık, ikinciatsolauzaklık, ucuncuatsolauzaklık;
        Random rastgele = new Random();

        public void yenidenbaslat()
        {
            pictureBox1.Left = 0; //ilkat
            pictureBox2.Left = 0;//ikinciat
            pictureBox3.Left = 0;//üçüncüat
            label6.Text = ""; //mesaj yazısı
            label7.Text = "0";//zaman


        }
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            yenidenbaslat();
            timer2.Enabled = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int derece = Convert.ToInt32(label7.Text);
            derece++;
            label7.Text = derece.ToString();

            int birinciatingenisligi = pictureBox1.Width;
            int ikinciatingenisligi = pictureBox2.Width;
            int ucuncuatingenisligi = pictureBox3.Width;

            int bitisuzaklıgı = label5.Left;

            pictureBox1.Left = pictureBox1.Left + rastgele.Next(5, 20);
            pictureBox2.Left = pictureBox2.Left + rastgele.Next(5, 20);
            pictureBox3.Left = pictureBox3.Left + rastgele.Next(5, 20);

            if (pictureBox1.Left > pictureBox2.Left + 5 && pictureBox1.Left > pictureBox3.Left + 5)
            {
                label6.Text = "Karayel önde gidiyor.";
            }

            if (pictureBox2.Left > pictureBox1.Left + 5 && pictureBox2.Left > pictureBox3.Left + 5)
            {
                label6.Text = "Nadas iyi bir atakla öne geçti.";
            }

            if (pictureBox3.Left > pictureBox1.Left + 5 && pictureBox3.Left > pictureBox2.Left + 5)
            {
                label6.Text = "Cartegena liderliği ele geçirdi.";
            }

            if (birinciatingenisligi + pictureBox1.Left >= bitisuzaklıgı)
            {
                timer2.Enabled = false;
                label6.Text = ("karayel yarışı kazandı!!!!");
                button1.Visible = false;
                button2.Visible = true;
                if (label11.Text == "karayel")
                {
                    label13.Visible = true;
                    label13.Text = "Tebrikler :)";

                }

                else
                {
                    label13.Visible = true;
                    label13.Text = "Kaybettiniz :(";

                }

                

            }

            if (ikinciatingenisligi + pictureBox2.Left >= bitisuzaklıgı)
            {
                timer2.Enabled = false;
                label6.Text = ("Nadas yarışı kazandı!!!!");
                button1.Visible = false;
                button2.Visible = true;
                if (label11.Text == "nadas")
                {
                    label13.Visible = true;
                    label13.Text = "Tebrikler :)";
                }

                else
                {
                    label13.Visible = true;
                    label13.Text = "Kaybettiniz :(";

                }

            }

            if (ucuncuatingenisligi + pictureBox3.Left >= bitisuzaklıgı)
            {
                timer2.Enabled = false;
                label6.Text = ("Cartegena yarışı kazandı!!!!");
                button1.Visible = false;
                button2.Visible = true;
                if (label11.Text == "cartegena")
                {
                    label13.Visible = true;
                    label13.Text = "Tebrikler :)";

                }

                else
                {
                    label13.Visible = true;
                    label13.Text = "Kaybettiniz :(";

                }

                
            }
        }
        public string secim;
        private void Form1_Load(object sender, EventArgs e)
        {
            birinciatsolauzaklık = pictureBox1.Left;
            ikinciatsolauzaklık = pictureBox2.Left;
            ucuncuatsolauzaklık = pictureBox3.Left;
            button2.Visible = false;

            label11.Text = secim;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int derece = Convert.ToInt32(label7.Text);
            derece++;
            label7.Text = derece.ToString();

            int birinciatingenisligi = pictureBox1.Width;
            int ikinciatingenisligi = pictureBox2.Width;
            int ucuncuatingenisligi = pictureBox3.Width;

            int bitisuzaklıgı = label5.Left;

            pictureBox1.Left = pictureBox1.Left + rastgele.Next(5, 20);
            pictureBox2.Left = pictureBox2.Left + rastgele.Next(5, 20);
            pictureBox3.Left = pictureBox3.Left + rastgele.Next(5, 20);

            if (pictureBox1.Left > pictureBox2.Left + 5 && pictureBox1.Left > pictureBox3.Left + 5)
            {
                label6.Text = "Karayel yarışı önde götürüyor.";
            }

            if (pictureBox2.Left > pictureBox1.Left + 5 && pictureBox2.Left > pictureBox3.Left + 5)
            {
                label6.Text = "Nadas iyi bir atakla öne geçti.";
            }

            if (pictureBox3.Left > pictureBox1.Left + 5 && pictureBox3.Left > pictureBox2.Left + 5)
            {
                label6.Text = "Cartegena liderliği ele geçirdi.";
            }

            if (birinciatingenisligi + pictureBox1.Left >= bitisuzaklıgı)
            {
                timer1.Enabled = false;
                label6.Text = ("Karayel yarışı kazandı!!!!");
                button1.Visible = false;
                button2.Visible = true;

                if(label11.Text=="karayel")
                {
                    label13.Visible = true;
                    label13.Text = "Tebrikler :)";
                }

                else
                {
                    label13.Visible = true;
                    label13.Text = "Kaybettiniz :(";

                }
                
            }

            if (ikinciatingenisligi + pictureBox2.Left >= bitisuzaklıgı)
            {
                timer1.Enabled = false;
                label6.Text = ("Nadas yarışı kazandı!!!!");
                button1.Visible = false;
                button2.Visible = true;

                if (label11.Text == "nadas")
                {
                    label13.Visible = true;
                    label13.Text = "Tebrikler :)";
                }

                else
                {
                    label13.Visible = true;
                    label13.Text = "Kaybettiniz :(";

                }

            }

            if (ucuncuatingenisligi + pictureBox3.Left >= bitisuzaklıgı)
            {
                timer1.Enabled = false;
                label6.Text = ("Cartegena yarışı kazandı!!!!");
                button1.Visible = false;
                button2.Visible = true;

                if (label11.Text == "cartegena")
                {
                    label13.Visible = true;
                    label13.Text = "Tebrikler :)";
                }

                else
                {
                    label13.Visible = true;
                    label13.Text = "Kaybettiniz :(";

                }
            }



        }
    }       
}

       
 