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
    public partial class DeleteForm : Form
    {
        public DeleteForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string connstring = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
                SqlConnection conn = new SqlConnection(connstring);

                SqlCommand cmd = new SqlCommand("DeleteProduct", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Id", SqlDbType.NVarChar, 50).Value = textBox1.Text;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Product is Deleted Successfully!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            CUDSForm cu = new CUDSForm();
            cu.Show();
        }
    }
}
