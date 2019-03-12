﻿using System;
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
    public partial class Forma3 : Form
    {
        Bitmap m;
        int[] a = new int[156];
        int[] vec = new int[156];
        int j, s;
        Button[] buttons = new Button[156];
        string color;
        Form2 ownerForm = null;

        public Forma3(Form2 ownerForm)
        {
            InitializeComponent();
            this.ownerForm = ownerForm;
            for (int i = 6; i <= 155; i++)
            {
                buttons[i] = Controls[string.Format("button{0}", i)] as Button;



            }
            button1.ForeColor = System.Drawing.Color.FromArgb(0, 176, 240);
            button2.ForeColor = System.Drawing.Color.FromArgb(255, 192, 0);
            button3.ForeColor = System.Drawing.Color.FromArgb(128, 96, 0);
            button4.ForeColor = System.Drawing.Color.FromArgb(0, 153, 0);
            button1.Click += new System.EventHandler(ClickedButton_c);
            button2.Click += new System.EventHandler(ClickedButton_c);
            button3.Click += new System.EventHandler(ClickedButton_c);
            button4.Click += new System.EventHandler(ClickedButton_c);
            button156.Click += new System.EventHandler(ClickedButton_s);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            m = new Bitmap("a5.png");
        }


        private void button2_Click(object sender, EventArgs e)
        {
            m = new Bitmap("auriu.png");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            m = new Bitmap("maro2.png");
        }
        private void button4_Click(object sender, EventArgs e)
        {
            m = new Bitmap("v6.png");
        }
        private void ClickedButton_s(object sender, EventArgs e)
        {
            Button clickedButton_s = (Button)sender;
            clickedButton_s.BackgroundImage = Image.FromFile("wS.png");


        }
        private void button156_Click(object sender, EventArgs e)
        {
            m = new Bitmap("wS.png");
            color = "wS";
        }
        public void ClickedButton(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            clickedButton.BackgroundImage = m;
            clickedButton.Text = color;
            if (color == "a5")
                clickedButton.ForeColor = System.Drawing.Color.FromArgb(0, 176, 240);
            else if (color == "auriu") clickedButton.ForeColor = System.Drawing.Color.FromArgb(255, 192, 0);
            else if (color == "maro2") clickedButton.ForeColor = System.Drawing.Color.FromArgb(128, 96, 0);
            else if (color == "v6") clickedButton.ForeColor = System.Drawing.Color.FromArgb(0, 153, 0);
            else clickedButton.ForeColor = System.Drawing.Color.FromArgb(245, 245, 245);

        }
        public void ClickedButton_c(object sender, EventArgs e)
        {
            Button clickedButton_c = (Button)sender;
            color = clickedButton_c.Text;


        }
        private void button6_Click(object sender, EventArgs e)
        {
            for (j = 6; j <= 155; j++)
            {
                buttons[j].Click += new System.EventHandler(ClickedButton);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int i, k = 0, m = 0, n = 0;
            bool ok = true;
            StreamReader f = new StreamReader("avansat3.txt");
            string s = f.ReadToEnd();
            string[] text = new string[50];
            text = s.Split('/');

            for (i = 6; i <= 155; i++)
            { vec[i] = int.Parse(text[k]); k++; }
            for (i = 6; i <= 155; i++)
                if (buttons[i].Text == "a5") a[i] = 1;
                else if (buttons[i].Text == "auriu") a[i] = 2;
                else if (buttons[i].Text == "maro2") a[i] = 3;
                else if (buttons[i].Text == "v6") a[i] = 4;
                else a[i] = 0;

            for (i = 6; i <= 155; i++)
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
                pictureBox1.BackgroundImage = Image.FromFile("avansat3.png");
                label2.Visible = false;
                button156.Visible = false;

                bool ok1 = true;
                this.ownerForm.passvalue11(ok1);
                button5.Visible = false;
            }
            else
            {
                bool ok2;
                label2.Visible = true;
                for (i = 6; i <= 155; i = i + 10)
                {
                    ok2 = true;
                    for (int j = i; j <= i + 9; j++)
                        if (a[j] != vec[j])
                            ok2 = false;
                    if (ok2 == false)
                        label2.Text = label2.Text + (i / 10 + 1) + ",";
                }
                string str = label2.Text;
                str = str.Remove(str.Length - 1);
                label2.Text = str;
                label2.Text = label2.Text + " sunt gresite.";
            }  




        }



    }
}
