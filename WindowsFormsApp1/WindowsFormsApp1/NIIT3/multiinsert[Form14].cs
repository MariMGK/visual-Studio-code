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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addGrid(textBox1.Text, textBox2.Text);
        }
        private void addGrid(string id, string name)
        {
            try
            {

                DataGridViewRow newrow = new DataGridViewRow();
                newrow.CreateCells(dataGridView1);
                newrow.Cells[0].Value = id;
                newrow.Cells[1].Value = name;
                dataGridView1.Rows.Add(newrow);

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=LAPTOP-E0NVL0L7\\SQLEXPRESS;Initial Catalog=Craftsman;Integrated Security=True");
            connection.Open();
            int result = 0;
            foreach (DataGridViewRow dr in dataGridView1.Rows)
            {
                if (dr.Cells["Column1"].Value == null || dr.Cells["Column1"].Value == DBNull.Value)
                {
                    break;

                }
                else
                {
                    string query = "insert into position(positionid,positionname)values(" + Convert.ToInt32(dr.Cells["Column1"].Value.ToString()) + ",'" + dr.Cells["Column2"].Value.ToString() + "')";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    result = cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show((dataGridView1.Rows.Count-1) + "inserted successfully");

        }
    }
}

