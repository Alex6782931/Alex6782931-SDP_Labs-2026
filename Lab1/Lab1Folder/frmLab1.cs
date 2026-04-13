namespace Lab1.Lab1Folder
{
    public partial class frmLab1 : Form
    {
        public frmLab1()
        {
            InitializeComponent();
        }

        private void btnadd_Click_1(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtNum1.Text) + Convert.ToInt32(txtNum2.Text);
            txtSum.Text = x.ToString();
            txtNum1.Text = "";
            txtNum2.Text = "";
        }

        private void txtNum1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
