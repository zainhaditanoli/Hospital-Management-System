﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System
{
    public partial class cardiac : Form
    {
        public static int doctor_id = 0;
        public cardiac()
        {
            InitializeComponent();
            string cs = ConfigurationManager.ConnectionStrings["AAZ"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string querry = "select * from Doctors where dept_id=2";
            SqlDataAdapter adapter = new SqlDataAdapter(querry, con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            select_dept select_Dept = new select_dept();
            this.Hide();
            select_Dept.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            doctor_id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            available_docCardiac available_DocCardiac = new available_docCardiac();
            this.Hide();
            available_DocCardiac.Show();
        }
    }
}
