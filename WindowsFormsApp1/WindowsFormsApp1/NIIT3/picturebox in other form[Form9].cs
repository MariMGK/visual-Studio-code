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
using System.Data.SqlClient;


namespace WindowsFormsApp3
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }
        OpenFileDialog f1 = new OpenFileDialog();
        SqlConnection connection;
        private void button1_Click(object sender, EventArgs e)
        {

            
            f1.Filter = "image files|*.jpg;*.png;.*gif;*.icon;.*;";
            DialogResult d2 = f1.ShowDialog();
            if (d2 == DialogResult.Abort)
            {
                return;
            }
            if (d2 == DialogResult.Cancel)
            {
                return;
            }

            textBox4.Text = f1.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            OpenFileDialog f4 = new OpenFileDialog();
            f4.Filter = "image files|*.jpg;*.png;.*gif;*.icon;.*;";
            DialogResult d2 = f4.ShowDialog();
            if (d2 == DialogResult.Abort)
            {
                return;
            }
            if(d2==DialogResult.Cancel)
            {
                return;
            }
           
            textBox5.Text = f4.FileName ;
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            
            Form10 f2 = new Form10();
            this.Hide();
            f2.label6.Text = textBox1.Text.ToString();
            f2.label7.Text = textBox2.Text.ToString();
            f2.label8.Text = textBox3.Text.ToString();

            f2.pictureBox1.Image = Image.FromFile(f1.FileName);
            MemoryStream ms1 = new MemoryStream();
            f2.pictureBox1.Image.Save(ms1, System.Drawing.Imaging.ImageFormat.Jpeg);
            f2.pictureBox2.Image = Image.FromFile(f1.FileName);
            MemoryStream ms2 = new MemoryStream();
            f2.pictureBox2.Image.Save(ms2, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] img_arr1 = new byte[ms1.Length];
            byte[] img_arr2 = new byte[ms2.Length];
            ms1.Read(img_arr1, 0, img_arr1.Length);
            ms2.Read(img_arr1, 0, img_arr2.Length);

            f2.Show();
            connection.Open();
            string query;
            query = "insert into student_record(name,qualifiaction,age,image,signature) values(@a,@b,@c,@d,@e)";
            SqlCommand sqlcommand = new SqlCommand(query, connection);
            //'" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" +f2.pictureBox1.Image+ "','"+f2.pictureBox2.Image+"'
            sqlcommand.Parameters.AddWithValue("@a",textBox1.Text);
            sqlcommand.Parameters.AddWithValue("@b", textBox2.Text);
            sqlcommand.Parameters.AddWithValue("@c", textBox3.Text);
            sqlcommand.Parameters .AddWithValue("@d", img_arr1);
            sqlcommand.Parameters.AddWithValue("@e", img_arr2);



            sqlcommand.ExecuteNonQuery();
            connection.Close(); 


        }

        private void Form9_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection("Data Source=LAPTOP-E0NVL0L7\\SQLEXPRESS;Initial Catalog=Craftsman;Integrated Security=True");

        }
    }
}
