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
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s1 = encode(textBox1.Text);
            MessageBox.Show(s1);
            string s2 = decode(s1);
            MessageBox.Show(s2);
           
        }
        public static string encode(string plaintext)
        {
            var plaintextbytes = System.Text.Encoding.UTF8.GetBytes(plaintext);
            return System.Convert.ToBase64String(plaintextbytes);
        }
        public static string decode(string encryptedtext)
        {
            var encryptedtextbytes = System.Convert.FromBase64String(encryptedtext);
            return System.Text.Encoding.UTF8.GetString(encryptedtextbytes);
        }
    }
}
