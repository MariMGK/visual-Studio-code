﻿using System;
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
    
    public partial class Form1 : Form
    {
        mysqlconnection con = new mysqlconnection();
        public Form1()
        {
            InitializeComponent();
        }
        
        

        private void Form1_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void loaddata()
        {
            DataSet ds = new DataSet();
            
            ds= con.LoadData("SELECT * FROM position");
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty && textBox2.Text != string.Empty) //check if all fields are filled
            {
                con.Executing("INSERT INTO position(positionid,positionname ) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "'); ");
                loaddata();
                MessageBox.Show("Record saved");
            }
            else
            {
                MessageBox.Show("Please fill all the fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
