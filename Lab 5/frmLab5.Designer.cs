namespace Lab_5
{
    partial class frmLab5
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblCustomerDetails = new Label();
            dgvCustomerDetails = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvCustomerDetails).BeginInit();
            SuspendLayout();
            // 
            // lblCustomerDetails
            // 
            lblCustomerDetails.AutoSize = true;
            lblCustomerDetails.Location = new Point(167, 59);
            lblCustomerDetails.Name = "lblCustomerDetails";
            lblCustomerDetails.Size = new Size(97, 15);
            lblCustomerDetails.TabIndex = 0;
            lblCustomerDetails.Text = "Customer Details";
            // 
            // dgvCustomerDetails
            // 
            dgvCustomerDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomerDetails.Location = new Point(148, 106);
            dgvCustomerDetails.Name = "dgvCustomerDetails";
            dgvCustomerDetails.Size = new Size(378, 232);
            dgvCustomerDetails.TabIndex = 1;
            // 
            // frmLab5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvCustomerDetails);
            Controls.Add(lblCustomerDetails);
            Name = "frmLab5";
            Text = "Form1";
            Load += frmLab5_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCustomerDetails).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCustomerDetails;
        private DataGridView dgvCustomerDetails;
    }
}
