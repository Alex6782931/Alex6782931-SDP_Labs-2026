namespace Lab2
{
    partial class frmLab2C
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
            btnAdd = new Button();
            txtName = new TextBox();
            lblDelete = new Label();
            lstStudents = new ListBox();
            lblMessage = new Label();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.Control;
            btnAdd.Location = new Point(309, 58);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(114, 23);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add an Item";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(309, 12);
            txtName.Name = "txtName";
            txtName.Size = new Size(292, 23);
            txtName.TabIndex = 1;
            // 
            // lblDelete
            // 
            lblDelete.AutoSize = true;
            lblDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDelete.Location = new Point(309, 133);
            lblDelete.Name = "lblDelete";
            lblDelete.Size = new Size(137, 15);
            lblDelete.TabIndex = 2;
            lblDelete.Text = "[Double click to delete]";
            lblDelete.Click += lblDelete_Click;
            // 
            // lstStudents
            // 
            lstStudents.FormattingEnabled = true;
            lstStudents.ItemHeight = 15;
            lstStudents.Location = new Point(12, 12);
            lstStudents.Name = "lstStudents";
            lstStudents.Size = new Size(241, 199);
            lstStudents.Sorted = true;
            lstStudents.TabIndex = 3;
            lstStudents.DoubleClick += lstStudents_DoubleClick;
            // 
            // lblMessage
            // 
            lblMessage.BackColor = SystemColors.ActiveCaption;
            lblMessage.BorderStyle = BorderStyle.Fixed3D;
            lblMessage.Location = new Point(12, 244);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(643, 42);
            lblMessage.TabIndex = 4;
            // 
            // frmLab2C
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(800, 450);
            Controls.Add(lblMessage);
            Controls.Add(lstStudents);
            Controls.Add(lblDelete);
            Controls.Add(txtName);
            Controls.Add(btnAdd);
            Name = "frmLab2C";
            Text = "Students";
            Load += frmLab2C_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private TextBox txtName;
        private Label lblDelete;
        private ListBox lstStudents;
        private Label lblMessage;
    }
}