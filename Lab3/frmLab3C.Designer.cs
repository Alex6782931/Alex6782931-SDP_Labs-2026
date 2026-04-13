namespace Lab3
{
    partial class frmLab3C
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
            lstShop = new ListBox();
            lstCart = new ListBox();
            btnRight = new Button();
            btnLeft = new Button();
            lblAdd = new Label();
            txt1 = new TextBox();
            btnAdd = new Button();
            btnCart = new Button();
            btnCount = new Button();
            SuspendLayout();
            // 
            // lstShop
            // 
            lstShop.FormattingEnabled = true;
            lstShop.ItemHeight = 15;
            lstShop.Location = new Point(39, 60);
            lstShop.Name = "lstShop";
            lstShop.Size = new Size(120, 94);
            lstShop.Sorted = true;
            lstShop.TabIndex = 0;
            // 
            // lstCart
            // 
            lstCart.FormattingEnabled = true;
            lstCart.ItemHeight = 15;
            lstCart.Location = new Point(371, 60);
            lstCart.Name = "lstCart";
            lstCart.Size = new Size(120, 94);
            lstCart.Sorted = true;
            lstCart.TabIndex = 1;
            // 
            // btnRight
            // 
            btnRight.Location = new Point(221, 60);
            btnRight.Name = "btnRight";
            btnRight.Size = new Size(75, 23);
            btnRight.TabIndex = 2;
            btnRight.Text = "-->";
            btnRight.UseVisualStyleBackColor = true;
            btnRight.Click += btnRight_Click;
            // 
            // btnLeft
            // 
            btnLeft.Location = new Point(221, 120);
            btnLeft.Name = "btnLeft";
            btnLeft.Size = new Size(75, 23);
            btnLeft.TabIndex = 3;
            btnLeft.Text = "<--";
            btnLeft.UseVisualStyleBackColor = true;
            btnLeft.Click += btnLeft_Click;
            // 
            // lblAdd
            // 
            lblAdd.AutoSize = true;
            lblAdd.Location = new Point(39, 200);
            lblAdd.Name = "lblAdd";
            lblAdd.Size = new Size(53, 15);
            lblAdd.TabIndex = 4;
            lblAdd.Text = "AddFruit";
            // 
            // txt1
            // 
            txt1.Location = new Point(120, 192);
            txt1.Name = "txt1";
            txt1.Size = new Size(100, 23);
            txt1.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(84, 249);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "AddFruit";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnCart
            // 
            btnCart.Location = new Point(416, 249);
            btnCart.Name = "btnCart";
            btnCart.Size = new Size(87, 49);
            btnCart.TabIndex = 7;
            btnCart.Text = "Clear Cart";
            btnCart.UseVisualStyleBackColor = true;
            // 
            // btnCount
            // 
            btnCount.Location = new Point(288, 249);
            btnCount.Name = "btnCount";
            btnCount.Size = new Size(100, 49);
            btnCount.TabIndex = 8;
            btnCount.Text = "Count Shop + Cart";
            btnCount.UseVisualStyleBackColor = true;
            // 
            // frmLab3C
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCount);
            Controls.Add(btnCart);
            Controls.Add(btnAdd);
            Controls.Add(txt1);
            Controls.Add(lblAdd);
            Controls.Add(btnLeft);
            Controls.Add(btnRight);
            Controls.Add(lstCart);
            Controls.Add(lstShop);
            Name = "frmLab3C";
            Text = "Lab3C";
            Load += frmLab3C_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstShop;
        private ListBox lstCart;
        private Button btnRight;
        private Button btnLeft;
        private Label lblAdd;
        private TextBox txt1;
        private Button btnAdd;
        private Button btnCart;
        private Button btnCount;
    }
}