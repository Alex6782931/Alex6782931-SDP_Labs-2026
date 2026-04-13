namespace Lab3.Lab4
{
    partial class frmLab4
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
            lbl1 = new Label();
            btnHTTP = new Button();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.BackColor = SystemColors.Info;
            lbl1.BorderStyle = BorderStyle.Fixed3D;
            lbl1.Location = new Point(89, 163);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(478, 103);
            lbl1.TabIndex = 0;
            // 
            // btnHTTP
            // 
            btnHTTP.Location = new Point(89, 58);
            btnHTTP.Name = "btnHTTP";
            btnHTTP.Size = new Size(75, 23);
            btnHTTP.TabIndex = 1;
            btnHTTP.Text = "HTTP Get";
            btnHTTP.UseVisualStyleBackColor = true;
            btnHTTP.Click += btnHTTP_Click;
            // 
            // frmLab4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnHTTP);
            Controls.Add(lbl1);
            Name = "frmLab4";
            Text = "Lab4";
            ResumeLayout(false);
        }

        #endregion

        private Label lbl1;
        private Button btnHTTP;
    }
}