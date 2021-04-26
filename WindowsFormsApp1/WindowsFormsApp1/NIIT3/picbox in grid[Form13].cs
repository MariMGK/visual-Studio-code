using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace WindowsFormsApp3
{
    
    public partial class Form13 : Form
    {
        SqlConnection connection;
        public Form13()
        {
            InitializeComponent();
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            connection =new SqlConnection( "Data Source=LAPTOP-E0NVL0L7\\SQLEXPRESS;Initial Catalog=Craftsman;Integrated Security=True");
            populategridview();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(connection.State!=ConnectionState.Open)
            {
                connection.Open();
            }
            SqlCommand sqlcmd = new SqlCommand("select image,signature from student_record where name= '"+textBox1.Text+"'", connection);
            SqlDataReader dr = sqlcmd.ExecuteReader();
            if (dr.Read())
            {
                byte[] img_arr1 = (byte[])dr["image"];
                byte[] sign_arr1 = (byte[])dr["signature"];
                MemoryStream ms1 = new MemoryStream(img_arr1);
                MemoryStream ms2 = new MemoryStream(sign_arr1);
                ms1.Seek(0, SeekOrigin.Begin);
                ms2.Seek(0, SeekOrigin.Begin);
                pictureBox1.Image = Image.FromStream(ms1);
                pictureBox2.Image = Image.FromStream(ms2);
                connection.Close();
            }
            else
            {
                MessageBox.Show("your data is not stored in database try again");
            }





            }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        void populategridview()
        {
            connection.Open();
            SqlDataAdapter sqlda = new SqlDataAdapter("select * from student_record",connection);
            DataSet ds = new DataSet();
            sqlda.Fill(ds);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = ds.Tables[0];

        }
    }
    }

