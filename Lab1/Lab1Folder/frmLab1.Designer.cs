namespace Lab1.Lab1Folder
{
    partial class frmLab1
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
            lblNum1 = new Label();
            txtNum1 = new TextBox();
            txtNum2 = new TextBox();
            txtSum = new TextBox();
            lblSum = new Label();
            lblNum2 = new Label();
            btnadd = new Button();
            SuspendLayout();
            // 
            // lblNum1
            // 
            lblNum1.AutoSize = true;
            lblNum1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNum1.Location = new Point(107, 78);
            lblNum1.Name = "lblNum1";
            lblNum1.Size = new Size(63, 25);
            lblNum1.TabIndex = 0;
            lblNum1.Text = "Num1";
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(114, 109);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(100, 23);
            txtNum1.TabIndex = 1;
            txtNum1.TextChanged += txtNum1_TextChanged;
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(299, 109);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(100, 23);
            txtNum2.TabIndex = 3;
            // 
            // txtSum
            // 
            txtSum.Location = new Point(215, 279);
            txtSum.Name = "txtSum";
            txtSum.Size = new Size(100, 23);
            txtSum.TabIndex = 5;
            // 
            // lblSum
            // 
            lblSum.AutoSize = true;
            lblSum.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSum.Location = new Point(215, 251);
            lblSum.Name = "lblSum";
            lblSum.Size = new Size(49, 25);
            lblSum.TabIndex = 6;
            lblSum.Text = "Sum";
            // 
            // lblNum2
            // 
            lblNum2.AutoSize = true;
            lblNum2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNum2.Location = new Point(299, 78);
            lblNum2.Name = "lblNum2";
            lblNum2.Size = new Size(63, 25);
            lblNum2.TabIndex = 7;
            lblNum2.Text = "Num2";
            // 
            // btnadd
            // 
            btnadd.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnadd.Location = new Point(226, 177);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(75, 42);
            btnadd.TabIndex = 8;
            btnadd.Text = "Add";
            btnadd.UseVisualStyleBackColor = true;
            btnadd.Click += btnadd_Click_1;
            // 
            // frmLab1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(518, 389);
            Controls.Add(btnadd);
            Controls.Add(lblNum2);
            Controls.Add(lblSum);
            Controls.Add(txtSum);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            Controls.Add(lblNum1);
            Name = "frmLab1";
            Text = "Lab1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNum1;
        private TextBox txtNum1;
        private TextBox txtNum2;
        private TextBox txtSum;
        private Label lblSum;
        private Label lblNum2;
        private Button btnadd;
    }
}
