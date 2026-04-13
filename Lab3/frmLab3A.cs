namespace Lab3
{
    public partial class frmLab3A : Form
    {
        public frmLab3A()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"You voted for \n{cboMovies.SelectedItem}");
            DialogResult result = MessageBox.Show(
                $"You voted for \n{cboMovies.SelectedItem}",
                "This is caption1",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question
                );

            if (result == DialogResult.Yes)
            {
                MessageBox.Show($"Yes! You voted for {cboMovies.SelectedItem}");
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show($"No! You cancel the vote.");
            }
            else //DialogResult.Cancel
            {
                //Nothing Happens
            }
        }
    }
}


