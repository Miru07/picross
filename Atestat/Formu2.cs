using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Atestat
{
    public partial class Formu2 : Form
    {
         Bitmap m;
        int[] a = new int[32];
        int []vec=new int [32];
        int j,s;
        Button[] buttons = new Button[31];
        string color;
        Form2 ownerForm = null;
        bool ok1 = false;
        public Formu2(Form2 ownerForm)
        {
            InitializeComponent();
            this.ownerForm = ownerForm;
            for (int i = 6; i <= 30; i++)
            {
                buttons[i] = Controls[string.Format("button{0}", i)] as Button;
                
                
                  
            }
            button2.ForeColor = System.Drawing.Color.FromArgb(0, 176, 240);
            button3.ForeColor = System.Drawing.Color.FromArgb(131, 60, 11);
            button1.Click += new System.EventHandler(ClickedButton_c);
            button2.Click += new System.EventHandler(ClickedButton_c);
            button3.Click += new System.EventHandler(ClickedButton_c);
            button4.Click += new System.EventHandler(ClickedButton_c);
            button31.Click += new System.EventHandler(ClickedButton_s);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            m = new Bitmap("n.png");
        }
       

        private void button2_Click(object sender, EventArgs e)
        {
            m = new Bitmap("a.png");
        }

         private void button3_Click(object sender, EventArgs e)
         {
             m = new Bitmap("m.png");
         }
          private void button4_Click(object sender, EventArgs e)
         {
             m = new Bitmap("alb.png");
         }
         public void ClickedButton(object sender, EventArgs e)
         {
             Button clickedButton = (Button)sender;
             clickedButton.BackgroundImage = m;
             clickedButton.Text = color;
             if (color == "a")
                 clickedButton.ForeColor = System.Drawing.Color.FromArgb(0, 176, 240);
             else if (color == "m") clickedButton.ForeColor = System.Drawing.Color.FromArgb(131, 60, 11);
             else if (color == "alb") clickedButton.ForeColor = Color.White;
             else if(color=="n")clickedButton.ForeColor = Color.Black;
             else clickedButton.ForeColor = System.Drawing.Color.FromArgb(128, 128, 128); 
             
             
         }
         public void ClickedButton_c(object sender, EventArgs e)
         {
             Button clickedButton_c = (Button)sender;
             color = clickedButton_c.Text;
             //label2.Text = label2.Text + color;
            
         }
         private void ClickedButton_s(object sender, EventArgs e)
         {
             Button clickedButton_s = (Button)sender;
             clickedButton_s.BackgroundImage = Image.FromFile("wS2.png");


         }
         private void button31_Click(object sender, EventArgs e)
         {
             m = new Bitmap("wS2.png");
             color = "wS2";
         }
         private void button6_Click(object sender, EventArgs e)
         {
             for (j = 6; j <= 30; j++)
             {
                 buttons[j].Click += new System.EventHandler(ClickedButton);
             }   
         }

         private void button5_Click(object sender, EventArgs e)
         {
             int i,k=0,m=0,n=0;
             bool ok=true;
             StreamReader f = new StreamReader("u2.txt");
             string s = f.ReadToEnd();
             string[] text = new string[50];
             text = s.Split('/');
             
             for (i = 6; i <= 30; i++)
                 { vec[i] = int.Parse(text[k]); k++;}
             for (i = 6; i <= 30; i++)
                 if (buttons[i].Text == "n") a[i] = 1;
                 else if (buttons[i].Text == "a") a[i] = 2;
                 else if (buttons[i].Text == "m") a[i] = 3;
                 else if (buttons[i].Text == "alb") a[i] = 4;
                 else a[i] = 0;
             /*for (i = 5; i <= 10; i++)
                 label1.Text = label1.Text + a[i];*/
             for (i = 6; i <= 30; i++)
                     if (a[i] != vec[i])
                         ok = false;
             if (ok == true)
             {
                 button1.Visible = false;
                 button2.Visible = false;
                 button3.Visible = false;
                 button4.Visible = false;
                 button31.Visible = false;
                 pictureBox2.Visible = false;
                 pictureBox3.Visible = false;

                 pictureBox4.Visible = true;
                 pictureBox4.SendToBack();
                 pictureBox1.Visible = true;
                 pictureBox1.BackgroundImage = Image.FromFile("u2.png");
                 label2.Visible = false;
                 button5.Visible = false;
                
                 ok1 = true;
                 this.ownerForm.passvalue2(ok1);
                 label1.Visible = true;
                 

             }
             else
             {
                 bool ok2;
                 label2.Visible = true;
                 for (i = 6; i <= 30; i = i + 5)
                 {
                     ok2 = true;
                     for (int j = i; j <= i + 4; j++)
                         if (a[j] != vec[j])
                             ok2 = false;
                     if (ok2 == false)
                         label2.Text = label2.Text + i / 5 + ",";
                 }
                 string str = label2.Text;
                 str = str.Remove(str.Length - 1);
                 label2.Text = str;
                 label2.Text = label2.Text + " sunt gresite.";
             }  
                              

         }
         
        
    }
}
