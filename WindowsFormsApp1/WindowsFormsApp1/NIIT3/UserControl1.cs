using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        public string userid;
        public string USERID
        {
            get
            {
                return userid;
            }
            set
            {
                userid =value;            }
        }
        public string password;
        
        public string PASSWORD
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Admin" && textBox2.Text == "Admin" || textBox1.Text == USERID && textBox2.Text == PASSWORD)
            {
                MessageBox.Show("Login Successful");
            }
            else
                MessageBox.Show("Login Failed");
        }
        
    }
}
