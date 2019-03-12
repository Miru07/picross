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
    public partial class Form4 : Form
    {
        bool ok1 = false;
        Bitmap m;
        int[] a = new int[32];
        int []vec=new int [32];
        int j,s;
        Button[] buttons = new Button[31];
        string color;
        Form2 ownerForm = null; 
        public Form4(Form2 ownerForm)
        {
            InitializeComponent();
            this.ownerForm = ownerForm;

            for (int i = 6; i <= 30; i++)
            {
                buttons[i] = Controls[string.Format("button{0}", i)] as Button;
                
                
                  
            }
            button1.Click += new System.EventHandler(ClickedButton_c);
            button2.Click += new System.EventHandler(ClickedButton_c);
            button3.Click += new System.EventHandler(ClickedButton_c);
            button4.Click += new System.EventHandler(ClickedButton_c);
            button31.Click += new System.EventHandler(ClickedButton_s);
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            m = new Bitmap("r.png");
        }
       

        private void button2_Click(object sender, EventArgs e)
        {
            m = new Bitmap("g.png");
        }

         private void button3_Click(object sender, EventArgs e)
         {
             m = new Bitmap("a.png");
         }
         private void button4_Click(object sender, EventArgs e)
         {
             m = new Bitmap("m.png");
         }

         public void ClickedButton(object sender, EventArgs e)
         {
             Button clickedButton = (Button)sender;
             //MessageBox.Show("Click");
             clickedButton.BackgroundImage = m;
             clickedButton.Text = color;
             if (color == "r")
                 clickedButton.ForeColor = System.Drawing.Color.FromArgb(255, 0, 0);
             else if (color == "g")
                 clickedButton.ForeColor = System.Drawing.Color.FromArgb(255, 255, 0);
             else if (color == "a")
                 clickedButton.ForeColor = System.Drawing.Color.FromArgb(0,176,240);
             else if(color=="m")clickedButton.ForeColor = System.Drawing.Color.FromArgb(131,60,11);
             else clickedButton.ForeColor = System.Drawing.Color.FromArgb(245, 245, 245);
                 

             
             
         }
        private void ClickedButton_s(object sender, EventArgs e)
         {
             Button clickedButton_s = (Button)sender;
             clickedButton_s.BackgroundImage = Image.FromFile("wS.png");
             
            
         }
         public void ClickedButton_c(object sender, EventArgs e)
         {
             Button clickedButton_c = (Button)sender;
             color = clickedButton_c.Text;
             //label2.Text = label2.Text + color;
            
         }
         private void button6_Click(object sender, EventArgs e)
         {
             for (j = 6; j <= 30; j++)
             {
                 buttons[j].Click += new System.EventHandler(ClickedButton);
             }   
         }
         private void button31_Click(object sender, EventArgs e)
         {
             m = new Bitmap("wS.png");
             color = "wS";
         }
         private void button5_Click(object sender, EventArgs e)
         {
             int i,k=0,m=0,n=0;
             bool ok=true;
             StreamReader f = new StreamReader("u1.txt");
             string s = f.ReadToEnd();
             string[] text = new string[50];
             text = s.Split('/');
             
             for (i = 6; i <= 30; i++)
                 { vec[i] = int.Parse(text[k]); k++;}
             for (i = 6; i <= 30; i++)
                 if (buttons[i].Text == "r") a[i] = 1;
                 else if (buttons[i].Text == "g") a[i] = 2;
                 else if (buttons[i].Text == "a") a[i] = 3;
                 else if (buttons[i].Text == "m") a[i] = 4;
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
                 pictureBox2.Visible = false;
                 pictureBox3.Visible = false;
                 
                 
                 label1.Visible = true;
                 pictureBox4.Visible = true;
                 pictureBox4.SendToBack();
                 pictureBox1.Visible = true;
                 pictureBox1.BackgroundImage = Image.FromFile("u1.png");
                 label2.Visible = false;
                 button31.Visible = false;
                 
                 ok1 = true;
                 this.ownerForm.passvalue1(ok1);
                 button5.Visible = false;
                 

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
                     if(ok2==false)                             
                     label2.Text = label2.Text + i / 5 + ",";
                 }
                 string str = label2.Text;
                 str = str.Remove(str.Length - 1);
                 label2.Text = str;
                 label2.Text=label2.Text+" sunt gresite.";
                     }  
             
              

         }     
        
    }
}

    

