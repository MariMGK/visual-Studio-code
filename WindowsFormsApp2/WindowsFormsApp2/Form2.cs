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

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Form1.c.print());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            test t = new test();
             t.info();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            //MessageBox.Show(Form1.c.metho.ToString());
            label1.Show();
            label1.SetBounds(10, 0, 50, 60); 
            label1.Text = Form1.c.OrderItem;
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = " ";
            label1.Hide();
        }
    }
}


class test {

public void info()
    {
        MessageBox.Show("This is MGK");
    }

}
