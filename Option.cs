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
    public partial class Option : Form
    {
        public Option()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CUDSForm form = new CUDSForm();
            form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreateInvoice form = new CreateInvoice();
            form.Show();
            this.Hide();
        }
    }
}
