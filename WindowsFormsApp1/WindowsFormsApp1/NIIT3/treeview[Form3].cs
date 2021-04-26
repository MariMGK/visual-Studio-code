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
    public partial class Form3 : Form
    {
        
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=LAPTOP-E0NVL0L7\\SQLEXPRESS;Initial Catalog=Craftsman;Integrated Security=True";
            string q1 = "select * from employee1";
            string q2 = "select * from position";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand com = new SqlCommand(q1, con);
            SqlDataAdapter adapter = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            con.Open();
            
            adapter.Fill(ds,"employee1");
            adapter.SelectCommand.CommandText = q2;
            adapter.Fill(ds, "position");
            con.Close();
            DataColumn parentcol = ds.Tables["employee1"].Columns["positionid"];
            DataColumn childcol = ds.Tables["position"].Columns["positionid"];
            DataRelation relation = new DataRelation("child", parentcol, childcol);
            ds.Relations.Add(relation);

            foreach(DataRow parent in ds.Tables["employee1"].Rows)
            {
                TreeNode nodeparent = treeView1.Nodes.Add(parent["name"].ToString());
                foreach(DataRow child in parent.GetChildRows(relation))
                {
                    nodeparent.Nodes.Add(child["positionname"].ToString());
                }
            }


        }
    }
}
