using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApnaMart
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "ib") && (textBox2.Text == "0000"))
            {
                    this.Hide();
                    Option cf = new Option();
                    cf.Show();
            }
            else
            {
                MessageBox.Show("Password is not Correct");
            }

        }
    }
}
