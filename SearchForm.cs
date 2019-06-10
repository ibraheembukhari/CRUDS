using System;
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
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }
        private void SearchForm_Load(object sender, EventArgs e)
        {
            try
            {
                string connstring = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
                SqlConnection conn = new SqlConnection(connstring);
                conn.Open();
                SqlDataAdapter adapt = new SqlDataAdapter("select * from Insert_Product", conn);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            CUDSForm cu = new CUDSForm();
            cu.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string connstring = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
                SqlConnection conn = new SqlConnection(connstring);
                conn.Open();
                SqlDataAdapter adapt = new SqlDataAdapter("select * from Insert_Product where ItemName like'" + textBox1.Text + "%'", conn);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }
    }
}
