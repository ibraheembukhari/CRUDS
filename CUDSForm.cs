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
    public partial class CUDSForm : Form
    {
        public CUDSForm()
        {
            InitializeComponent();
        }

        private void CUDSForm_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            InsertForm add = new InsertForm();
            add.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateForm up = new UpdateForm();
            up.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteForm del = new DeleteForm();
            del.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchForm sea = new SearchForm();
            sea.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Option op = new Option();
            op.Show();
            this.Hide();

        }
    }
}
