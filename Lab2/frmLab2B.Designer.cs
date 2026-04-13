namespace Lab2
{
    partial class frmLab2B
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLab2B));
            txt1 = new TextBox();
            grp1 = new GroupBox();
            rbnSunnny = new RadioButton();
            rbnSnowy = new RadioButton();
            rbnRainy = new RadioButton();
            rbnCloudy = new RadioButton();
            lblName = new Label();
            lblResult = new Label();
            pbCloudy = new PictureBox();
            pbSnowy = new PictureBox();
            pbSunnny = new PictureBox();
            pbRainy = new PictureBox();
            grp1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbCloudy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSnowy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSunnny).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbRainy).BeginInit();
            SuspendLayout();
            // 
            // txt1
            // 
            txt1.Location = new Point(194, 56);
            txt1.Name = "txt1";
            txt1.Size = new Size(351, 23);
            txt1.TabIndex = 0;
            // 
            // grp1
            // 
            grp1.Controls.Add(rbnSunnny);
            grp1.Controls.Add(rbnSnowy);
            grp1.Controls.Add(rbnRainy);
            grp1.Controls.Add(rbnCloudy);
            grp1.Location = new Point(48, 109);
            grp1.Name = "grp1";
            grp1.Size = new Size(257, 212);
            grp1.TabIndex = 2;
            grp1.TabStop = false;
            grp1.Text = "Choose";
            // 
            // rbnSunnny
            // 
            rbnSunnny.AutoSize = true;
            rbnSunnny.Location = new Point(12, 166);
            rbnSunnny.Name = "rbnSunnny";
            rbnSunnny.Size = new Size(65, 19);
            rbnSunnny.TabIndex = 3;
            rbnSunnny.TabStop = true;
            rbnSunnny.Text = "&Sunnny";
            rbnSunnny.UseVisualStyleBackColor = true;
            rbnSunnny.CheckedChanged += rbnSunnny_CheckedChanged;
            // 
            // rbnSnowy
            // 
            rbnSnowy.AutoSize = true;
            rbnSnowy.Location = new Point(12, 123);
            rbnSnowy.Name = "rbnSnowy";
            rbnSnowy.Size = new Size(60, 19);
            rbnSnowy.TabIndex = 2;
            rbnSnowy.TabStop = true;
            rbnSnowy.Text = "S&nowy";
            rbnSnowy.UseVisualStyleBackColor = true;
            rbnSnowy.CheckedChanged += rbnSnowy_CheckedChanged;
            // 
            // rbnRainy
            // 
            rbnRainy.AutoSize = true;
            rbnRainy.Location = new Point(12, 81);
            rbnRainy.Name = "rbnRainy";
            rbnRainy.Size = new Size(54, 19);
            rbnRainy.TabIndex = 1;
            rbnRainy.TabStop = true;
            rbnRainy.Text = "&Rainy";
            rbnRainy.UseVisualStyleBackColor = true;
            rbnRainy.CheckedChanged += rbnRainy_CheckedChanged;
            // 
            // rbnCloudy
            // 
            rbnCloudy.AutoSize = true;
            rbnCloudy.Location = new Point(12, 39);
            rbnCloudy.Name = "rbnCloudy";
            rbnCloudy.Size = new Size(63, 19);
            rbnCloudy.TabIndex = 0;
            rbnCloudy.TabStop = true;
            rbnCloudy.Text = "&Cloudy";
            rbnCloudy.UseVisualStyleBackColor = true;
            rbnCloudy.CheckedChanged += rbnCloudy_CheckedChanged;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(48, 59);
            lblName.Name = "lblName";
            lblName.Size = new Size(126, 15);
            lblName.TabIndex = 3;
            lblName.Text = "Enter your name here :";
            // 
            // lblResult
            // 
            lblResult.BorderStyle = BorderStyle.Fixed3D;
            lblResult.Location = new Point(48, 347);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(497, 63);
            lblResult.TabIndex = 8;
            // 
            // pbCloudy
            // 
            pbCloudy.Image = Properties.Resources.cloud316;
            pbCloudy.Location = new Point(366, 122);
            pbCloudy.Name = "pbCloudy";
            pbCloudy.Size = new Size(64, 65);
            pbCloudy.TabIndex = 9;
            pbCloudy.TabStop = false;
            // 
            // pbSnowy
            // 
            pbSnowy.Image = (Image)resources.GetObject("pbSnowy.Image");
            pbSnowy.Location = new Point(366, 209);
            pbSnowy.Name = "pbSnowy";
            pbSnowy.Size = new Size(64, 65);
            pbSnowy.TabIndex = 10;
            pbSnowy.TabStop = false;
            // 
            // pbSunnny
            // 
            pbSunnny.Image = (Image)resources.GetObject("pbSunnny.Image");
            pbSunnny.Location = new Point(462, 209);
            pbSunnny.Name = "pbSunnny";
            pbSunnny.Size = new Size(64, 65);
            pbSunnny.TabIndex = 11;
            pbSunnny.TabStop = false;
            // 
            // pbRainy
            // 
            pbRainy.Image = (Image)resources.GetObject("pbRainy.Image");
            pbRainy.Location = new Point(462, 122);
            pbRainy.Name = "pbRainy";
            pbRainy.Size = new Size(64, 65);
            pbRainy.TabIndex = 12;
            pbRainy.TabStop = false;
            // 
            // frmLab2B
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pbRainy);
            Controls.Add(pbSunnny);
            Controls.Add(pbSnowy);
            Controls.Add(pbCloudy);
            Controls.Add(lblResult);
            Controls.Add(lblName);
            Controls.Add(grp1);
            Controls.Add(txt1);
            Name = "frmLab2B";
            Text = "Weather Report";
            grp1.ResumeLayout(false);
            grp1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbCloudy).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSnowy).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSunnny).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbRainy).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt1;
        private GroupBox grp1;
        private RadioButton rbnSunnny;
        private RadioButton rbnSnowy;
        private RadioButton rbnRainy;
        private RadioButton rbnCloudy;
        private Label lblName;
        private Label lblResult;
        private PictureBox pbCloudy;
        private PictureBox pbSnowy;
        private PictureBox pbSunnny;
        private PictureBox pbRainy;
    }
}