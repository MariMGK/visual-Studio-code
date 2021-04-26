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

namespace WindowsFormsApp3
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            Panel aa = new Panel();
            aa.Location = new System.Drawing.Point(26,12);
            aa.Name = "Test Panel";
            aa.Size = new System.Drawing.Size(228, 200);
            aa.BackColor = Color.LightBlue;
            TextBox t = new TextBox();
            t.Text = "NIIT";
            aa.Controls.Add(t);
            Button b = new Button();
            b.Text = "save";
            b.Location = new Point(50, 50);

            
            aa.Controls.Add(b);
            this.Controls.Add(aa);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=LAPTOP-E0NVL0L7\\SQLEXPRESS;Initial Catalog=Craftsman;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            SqlCommand cmd=new SqlCommand("insert into e(doj) values ('"+textBox1.Text+"')",con);
            cmd.ExecuteNonQuery();
            textBox1.Text = "";

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Text);
            textBox1.Text = dateTimePicker1.Text;
        }
    }
}
