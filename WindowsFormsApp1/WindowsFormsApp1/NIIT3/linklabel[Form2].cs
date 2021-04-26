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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            linkLabel1.Links.Add( 14,28, "http://www.amazon.com");
            linkLabel1.LinkClicked +=new LinkLabelLinkClickedEventHandler( LinkLabel1_LinkClicked);
            //this.Controls.Add(linkLabel2);

        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string s = ((LinkLabel)sender).Name;
            MessageBox.Show(((LinkLabel)sender).Name);
            if (s=="linkLabel1")
            {
                linkLabel1.LinkVisited = true;
                System.Diagnostics.Process.Start("https://www.amazon.com");
            }
        }
    }
}
