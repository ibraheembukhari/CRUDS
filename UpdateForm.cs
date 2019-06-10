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

namespace ApnaMart
{
    public partial class UpdateForm : Form
    {
        public UpdateForm()
        {
            InitializeComponent();
        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                string connstring = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
                SqlConnection conn = new SqlConnection(connstring);

                SqlCommand cmd = new SqlCommand("UpdateProduct", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Id", SqlDbType.NVarChar, 50).Value = textBox1ID.Text;
                cmd.Parameters.Add("@ItemName", SqlDbType.NVarChar, 50).Value = textBox2ItemName.Text;
                cmd.Parameters.Add("@SIze", SqlDbType.NVarChar, 50).Value = textBox3Size.Text;
                cmd.Parameters.Add("@Color", SqlDbType.NVarChar, 50).Value = textBox4Color.Text;
                cmd.Parameters.Add("@Price", SqlDbType.NVarChar, 50).Value = textBox5Price.Text;

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Product is Updated Successfully!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CUDSForm cu = new CUDSForm();
            cu.Show();
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {

        }
    }
}
