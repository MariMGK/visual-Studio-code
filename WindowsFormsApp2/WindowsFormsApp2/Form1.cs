﻿using System;
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
        public static Class1 c;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            c = new Class1("","","","","");
            c.myTexbox(textBox1.Text,textBox2.Text,textBox3.Text, textBox4.Text,textBox5.Text);
          

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(c.print());
            Form2 f2 = new Form2();
                f2.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            c=new Class1(textBox1.Text,textBox2.Text,textBox3.Text, textBox4.Text,textBox5.Text);

        }
    }
}
