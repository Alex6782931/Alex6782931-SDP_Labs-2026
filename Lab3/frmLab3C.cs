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
    public partial class frmLab3C : Form
    {
        public frmLab3C()
        {
            InitializeComponent();
        }

        private void frmLab3C_Load(object sender, EventArgs e)
        {
            lstShop.Items.Add("Apple");
            lstShop.Items.Add("Banana");
            lstShop.Items.Add("Grape");
            lstShop.Items.Add("Orange");
            lstShop.Items.Add("Peach");
            lstShop.Items.Add("Pear");
            lstShop.Items.Add("Pineapple");
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            if (lstShop.SelectedItems != null)
            {
                lstCart.Items.Add(lstShop.SelectedItem);
                lstShop.Items.Remove(lstShop.SelectedItem);
            }
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (lstCart.SelectedItems != null) 
            {
                lstShop.Items.Add(lstCart.SelectedItem);
                lstCart.Items.Remove(lstCart.SelectedItem);
            }
        }
    }
}
