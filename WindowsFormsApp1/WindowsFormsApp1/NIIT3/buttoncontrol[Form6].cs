using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            button1.Click += button1_Click;
            button2.Click += button1_Click;
            button3.Click += button1_Click;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = ((Button)sender).Text;
            MessageBox.Show(s);
        }
    }
}
