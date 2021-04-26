using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp3
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string root = "D:\\NIIT\\temp";

            //string root = @"D:\NIIT";
            //string root = "D:/NIIT";
            if ( !Directory.Exists(root))
            {
                Directory.CreateDirectory(root);
            }
            else
            {
                MessageBox.Show("Exist");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string root = "D:\\NIIT3\\temp";
            if(Directory.Exists(root))
            {
                Directory.Delete(root);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string source = @"D:\temp";
            string dest = @"D:\NIIT4";
            try
            {
                Directory.Move(source, dest);
            }
            catch(IOException exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string filename = @"C:\Users\ajith kumar\Desktop\w4.docx";
            //File.SetCreationTime(filename, DateTime.Now);
            
            DateTime dt = File.GetCreationTime(filename); 
            MessageBox.Show("file created time:", dt.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string filename = @"C:\Users\ajith kumar\Desktop\w4.docx";
            DateTime dt=File.GetLastAccessTime(filename);

            MessageBox.Show("last accesed", dt.ToString());

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string root = @"D:\NIIT4";
            var files = from file in Directory. EnumerateFiles(root) select file;
            MessageBox.Show(files.Count<string>().ToString());
            string s1 = "";
            foreach ( var file in files )
            {
                s1 = s1 + file + "\n";
            }
            MessageBox.Show(s1);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string[] drives = System.IO.Directory.GetLogicalDrives();
            string s2 = "";
            foreach (var drive in drives)
            {
                s2 = s2 + drive + "\n";
            }
            MessageBox.Show(s2);

        }
    }
}
