namespace Lab2
{
    public partial class frmLab2A : Form
    {
        private int price;
        private string payment;

        public frmLab2A()
        {
            InitializeComponent();
            rbtRedWine.Checked = true;
            rbtVISA.Checked = true;
        }

        private void rbtRedWine_CheckedChanged(object sender, EventArgs e)
        {
            price = 250;
        }

        private void rgtWhiteWine_CheckedChanged(object sender, EventArgs e)
        {
            price = 180;
        }

        private void rbtBeer_CheckedChanged(object sender, EventArgs e)
        {
            price = 75;
        }

        private void rbtVISA_CheckedChanged(object sender, EventArgs e)
        {
            payment = "VISA";
        }

        private void rbtMasterCard_CheckedChanged(object sender, EventArgs e)
        {
            payment = "MasterCard";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                int total = price * Convert.ToInt32(txtb1.Text);
                //lblResult.Text = "Total Price: $" + total + "\nPayment: " + payment;
                lblResult.Text = $"Total Price: ${total}\nPayment: {payment}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter a valid quantity.");
                lblQty.Text = "";
            }
        }
    }
}
