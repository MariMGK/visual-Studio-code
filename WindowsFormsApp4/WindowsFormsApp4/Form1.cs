using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog s = new SaveFileDialog();
            s.Filter = "JPEG Image|*.jpg|PNG Image |*.png |Gif Image|*.gif";
            s.ShowDialog();

            System.IO.FileStream fs = (System.IO.FileStream)s.OpenFile();

            switch (s.FilterIndex)
            {

                case 1:
                    pictureBox1.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                    break;
                case 2:
                    pictureBox1.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Png);
                    break;
                case 3:
                    pictureBox1.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Gif);
                    break;
            }

            fs.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FontDialog fn = new FontDialog();
            fn.ShowDialog();
            
            textBox1.Font = fn.Font;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ColorDialog cl = new ColorDialog();
            cl.ShowDialog();
            //textBox2.ForeColor = cl.Color;
            textBox2.BackColor = System.Drawing.ColorTranslator.FromHtml("#3FEF2C");
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "JPEG Image|*.jpg|PNG Image |*.png";
            op.ShowDialog();

            System.IO.FileStream fs = (System.IO.FileStream)op.OpenFile();
            pictureBox2.Image = System.Drawing.Image.FromStream(fs);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;



        }
    }
}
 