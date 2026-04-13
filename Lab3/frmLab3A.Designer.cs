namespace Lab3
{
    partial class frmLab3A
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
            lbl1 = new Label();
            cboMovies = new ComboBox();
            btn1 = new Button();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(84, 31);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(169, 15);
            lbl1.TabIndex = 0;
            lbl1.Text = "My choice of best movie series";
            // 
            // cboMovies
            // 
            cboMovies.DropDownStyle = ComboBoxStyle.Simple;
            cboMovies.FormattingEnabled = true;
            cboMovies.Items.AddRange(new object[] { "The God Father", "Teminator", "Back to the Future", "Matrix" });
            cboMovies.Location = new Point(56, 69);
            cboMovies.Name = "cboMovies";
            cboMovies.Size = new Size(236, 135);
            cboMovies.TabIndex = 1;
            // 
            // btn1
            // 
            btn1.Location = new Point(111, 227);
            btn1.Name = "btn1";
            btn1.Size = new Size(113, 28);
            btn1.TabIndex = 2;
            btn1.Text = "Cast Your Vote";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // frmLab3A
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(405, 347);
            Controls.Add(btn1);
            Controls.Add(cboMovies);
            Controls.Add(lbl1);
            Name = "frmLab3A";
            Text = "Lab3A";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private ComboBox cboMovies;
        private Button btn1;
    }
}
