using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace WindowsFormsApp4
{
    public partial class Form2 : Form
    {
        OleDbConnection OleDb;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Filter = "Excel Files|*.xls;*.xlsx";
            openfile.ShowDialog();
            textBox1.Text = openfile.FileName;
            if (!string.IsNullOrEmpty(openfile.FileName))
            {
                OleDb = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + openfile.FileName + ";Extended Properties=Excel 12.0;");
                OleDb.Open();
                DataTable dt = OleDb.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                OleDb.Close();
                comboBox1.Items.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string sheetname = dt.Rows[i]["TABLE_NAME"].ToString();
                    sheetname = sheetname.Substring(0, sheetname.Length - 1);
                    comboBox1.Items.Add(sheetname);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            OleDbDataAdapter ole=new OleDbDataAdapter("select * from ["+comboBox1.Text+"$]",OleDb);
            DataTable dt = new DataTable();
            ole.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
