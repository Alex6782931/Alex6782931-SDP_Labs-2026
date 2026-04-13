namespace Lab3
{
    partial class frmLab3D
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
            lblSDP = new Label();
            cboLabs = new ComboBox();
            btnOpen = new Button();
            SuspendLayout();
            // 
            // lblSDP
            // 
            lblSDP.AutoSize = true;
            lblSDP.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSDP.Location = new Point(161, 65);
            lblSDP.Name = "lblSDP";
            lblSDP.Size = new Size(134, 37);
            lblSDP.TabIndex = 0;
            lblSDP.Text = "SDP Labs";
            // 
            // cboLabs
            // 
            cboLabs.FormattingEnabled = true;
            cboLabs.Location = new Point(161, 157);
            cboLabs.Name = "cboLabs";
            cboLabs.Size = new Size(121, 23);
            cboLabs.TabIndex = 1;
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(183, 222);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(75, 23);
            btnOpen.TabIndex = 2;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // frmLab3D
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnOpen);
            Controls.Add(cboLabs);
            Controls.Add(lblSDP);
            Name = "frmLab3D";
            Text = "frmLab3D";
            Load += frmLab3D_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSDP;
        private ComboBox cboLabs;
        private Button btnOpen;
    }
}