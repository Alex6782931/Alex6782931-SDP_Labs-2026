using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class frmLab2B : Form
    {
        public frmLab2B()
        {
            InitializeComponent();
        }

        private void rbnCloudy_CheckedChanged(object sender, EventArgs e)
        {
            ChangePhoto1(pbCloudy, "Cloudy");
        }

        private void rbnRainy_CheckedChanged(object sender, EventArgs e)
        {
            ChangePhoto1(pbRainy, "Rainy");
        }

        private void rbnSnowy_CheckedChanged(object sender, EventArgs e)
        {
            ChangePhoto1(pbSnowy, "Smowy");
        }

        private void rbnSunnny_CheckedChanged(object sender, EventArgs e)
        {
            ChangePhoto1(pbSunnny, "Sunnny");
        }

        private void ChangePhoto1(PictureBox chosePictureBox, String weather)
        {
            pbCloudy.Visible = false;
            pbRainy.Visible = false;
            pbSnowy.Visible = false;
            pbSunnny.Visible = false;
            chosePictureBox.Visible = true;

            lblResult.Text = $"This is going to be a {weather} day, {txt1.Text}!";
        }
    }
}
