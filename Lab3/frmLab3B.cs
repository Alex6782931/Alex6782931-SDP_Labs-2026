using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class frmLab3B : Form
    {
        public frmLab3B()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Double x = (Convert.ToInt32(txtAmount.Text) * Convert.ToDouble(txtRate.Text)+1)*10;
            lblValue2.Text = x.ToString();
            txtAmount.Text = "";
            txtRate.Text = "";
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRate_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}
