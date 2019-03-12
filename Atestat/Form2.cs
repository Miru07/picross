using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Atestat
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public void passvalue1(bool var)
        {
            if (var == true)
                pictureBox1.BackgroundImage = Image.FromFile("u1.png");

        }
        public void passvalue2(bool var)
        {
            if (var == true)
                pictureBox2.BackgroundImage = Image.FromFile("u2.png");

        }
        public void passvalue3(bool var)
        {
            if (var == true)
                pictureBox3.BackgroundImage = Image.FromFile("u3.png");

        }
        public void passvalue4(bool var)
        {
            if (var == true)
                pictureBox4.BackgroundImage = Image.FromFile("u4.png");

        }
        public void passvalue5(bool var)
        {
            if (var == true)
                pictureBox5.BackgroundImage = Image.FromFile("m1.png");

        }
        public void passvalue6(bool var)
        {
            if (var == true)
                pictureBox7.BackgroundImage = Image.FromFile("m2.png");

        }
        public void passvalue7(bool var)
        {
            if (var == true)
                pictureBox9.BackgroundImage = Image.FromFile("m3.png");

        }
        public void passvalue8(bool var)
        {
            if (var == true)
                pictureBox11.BackgroundImage = Image.FromFile("m4.png");

        }
        
         public void passvalue9(bool var)
        {
            if (var == true)
                pictureBox6.BackgroundImage = Image.FromFile("avansat1.png");

        }
         public void passvalue10(bool var)
        {
            if (var == true)
                pictureBox8.BackgroundImage = Image.FromFile("avansat2.png");

        }
         public void passvalue11(bool var)
        {
            if (var == true)
                pictureBox10.BackgroundImage = Image.FromFile("avansat3.png");

        }
         public void passvalue12(bool var)
         {
             if (var == true)
                 pictureBox12.BackgroundImage = Image.FromFile("avansat4.png");

         }
        private void button1_Click(object sender, EventArgs e)
        {
            Form3 g = new Form3();
            g.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = true;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = true;
            pictureBox5.Visible = true;
            pictureBox7.Visible = true;
            pictureBox9.Visible = true;
            pictureBox11.Visible = true;
            pictureBox12.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox6.Visible = false;
            pictureBox8.Visible = false;
            pictureBox10.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = true;
            pictureBox6.Visible = true;
            pictureBox8.Visible = true;
            pictureBox10.Visible = true;
            pictureBox12.Visible = true;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox7.Visible = false;
            pictureBox9.Visible = false;
            pictureBox11.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;

        }

        public void pictureBox1_Click(object sender, EventArgs e)
        {
            Form4 h = new Form4(this);
            h.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Formu2 h1 = new Formu2(this);
            h1.Show();
        }
        public void pictureBox3_Click(object sender, EventArgs e)
        {
            Formu3 h = new Formu3(this);
            h.Show();
        }


        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Formu4 h = new Formu4(this);
            h.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Formm1 h = new Formm1(this);
            h.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Formm2 h = new Formm2(this);
            h.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Formm3 h = new Formm3(this);
            h.Show();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Formm4 h = new Formm4(this);
            h.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Forma2 h = new Forma2(this);
            h.Show();

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Forma1 h = new Forma1(this);
            h.Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Forma3 h = new Forma3(this);
            h.Show();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            Forma4 h = new Forma4(this);
            h.Show();
        }



  
    }
}
