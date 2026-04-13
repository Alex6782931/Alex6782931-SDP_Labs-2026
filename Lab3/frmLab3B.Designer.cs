namespace Lab3
{
    partial class frmLab3B
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblAmount = new Label();
            txtAmount = new TextBox();
            lblRate = new Label();
            txtRate = new TextBox();
            btnCalculate = new Button();
            lblValue = new Label();
            label4 = new Label();
            lblValue2 = new Label();
            lblYear = new Label();
            SuspendLayout();
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(55, 59);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(51, 15);
            lblAmount.TabIndex = 0;
            lblAmount.Text = "Amount";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(172, 51);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(100, 23);
            txtAmount.TabIndex = 1;
            txtAmount.TextChanged += txtAmount_TextChanged;
            // 
            // lblRate
            // 
            lblRate.AutoSize = true;
            lblRate.Location = new Point(37, 114);
            lblRate.Name = "lblRate";
            lblRate.Size = new Size(118, 15);
            lblRate.TabIndex = 2;
            lblRate.Text = "Interest Rate(Annual)";
            // 
            // txtRate
            // 
            txtRate.Location = new Point(172, 106);
            txtRate.Name = "txtRate";
            txtRate.Size = new Size(100, 23);
            txtRate.TabIndex = 3;
            txtRate.TextChanged += txtRate_TextChanged;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(37, 165);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(235, 41);
            btnCalculate.TabIndex = 4;
            btnCalculate.Text = "Start Calculation";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblValue
            // 
            lblValue.AutoSize = true;
            lblValue.Location = new Point(37, 243);
            lblValue.Name = "lblValue";
            lblValue.Size = new Size(107, 15);
            lblValue.TabIndex = 5;
            lblValue.Text = "Value after 10 years";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 302);
            label4.Name = "label4";
            label4.Size = new Size(101, 15);
            label4.TabIndex = 6;
            label4.Text = "Year to reach $1M";
            // 
            // lblValue2
            // 
            lblValue2.BorderStyle = BorderStyle.Fixed3D;
            lblValue2.Location = new Point(172, 243);
            lblValue2.Name = "lblValue2";
            lblValue2.Size = new Size(100, 23);
            lblValue2.TabIndex = 7;
            // 
            // lblYear
            // 
            lblYear.BorderStyle = BorderStyle.Fixed3D;
            lblYear.Location = new Point(172, 294);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(100, 23);
            lblYear.TabIndex = 8;
            // 
            // frmLab3B
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 384);
            Controls.Add(lblYear);
            Controls.Add(lblValue2);
            Controls.Add(label4);
            Controls.Add(lblValue);
            Controls.Add(btnCalculate);
            Controls.Add(txtRate);
            Controls.Add(lblRate);
            Controls.Add(txtAmount);
            Controls.Add(lblAmount);
            Name = "frmLab3B";
            Text = "Compound Interest";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAmount;
        private TextBox txtAmount;
        private Label lblRate;
        private TextBox txtRate;
        private Button btnCalculate;
        private Label lblValue;
        private Label label4;
        private Label lblValue2;
        private Label lblYear;
    }
}