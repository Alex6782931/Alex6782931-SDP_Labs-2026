namespace Lab2
{
    partial class frmLab2A
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
            grpWineList = new GroupBox();
            rbtBeer = new RadioButton();
            rgtWhiteWine = new RadioButton();
            rbtRedWine = new RadioButton();
            grpPaymentMethod = new GroupBox();
            rbtMasterCard = new RadioButton();
            rbtVISA = new RadioButton();
            txtb1 = new TextBox();
            lblQty = new Label();
            btnCalculate = new Button();
            lblResult = new Label();
            grpWineList.SuspendLayout();
            grpPaymentMethod.SuspendLayout();
            SuspendLayout();
            // 
            // grpWineList
            // 
            grpWineList.Controls.Add(rbtBeer);
            grpWineList.Controls.Add(rgtWhiteWine);
            grpWineList.Controls.Add(rbtRedWine);
            grpWineList.Location = new Point(28, 37);
            grpWineList.Name = "grpWineList";
            grpWineList.Size = new Size(200, 208);
            grpWineList.TabIndex = 0;
            grpWineList.TabStop = false;
            grpWineList.Text = "Wine List";
            // 
            // rbtBeer
            // 
            rbtBeer.AutoSize = true;
            rbtBeer.Location = new Point(16, 117);
            rbtBeer.Name = "rbtBeer";
            rbtBeer.Size = new Size(129, 19);
            rbtBeer.TabIndex = 3;
            rbtBeer.TabStop = true;
            rbtBeer.Text = "Beer (1 dozen) ($75)";
            rbtBeer.UseVisualStyleBackColor = true;
            rbtBeer.CheckedChanged += rbtBeer_CheckedChanged;
            // 
            // rgtWhiteWine
            // 
            rgtWhiteWine.AutoSize = true;
            rgtWhiteWine.Location = new Point(16, 74);
            rgtWhiteWine.Name = "rgtWhiteWine";
            rgtWhiteWine.Size = new Size(121, 19);
            rgtWhiteWine.TabIndex = 2;
            rgtWhiteWine.TabStop = true;
            rgtWhiteWine.Text = "White Wine ($180)";
            rgtWhiteWine.UseVisualStyleBackColor = true;
            rgtWhiteWine.CheckedChanged += rgtWhiteWine_CheckedChanged;
            // 
            // rbtRedWine
            // 
            rbtRedWine.AutoSize = true;
            rbtRedWine.Location = new Point(16, 33);
            rbtRedWine.Name = "rbtRedWine";
            rbtRedWine.Size = new Size(110, 19);
            rbtRedWine.TabIndex = 1;
            rbtRedWine.TabStop = true;
            rbtRedWine.Text = "Red Wine ($250)";
            rbtRedWine.UseVisualStyleBackColor = true;
            rbtRedWine.CheckedChanged += rbtRedWine_CheckedChanged;
            // 
            // grpPaymentMethod
            // 
            grpPaymentMethod.Controls.Add(rbtMasterCard);
            grpPaymentMethod.Controls.Add(rbtVISA);
            grpPaymentMethod.Location = new Point(307, 47);
            grpPaymentMethod.Name = "grpPaymentMethod";
            grpPaymentMethod.Size = new Size(200, 115);
            grpPaymentMethod.TabIndex = 1;
            grpPaymentMethod.TabStop = false;
            grpPaymentMethod.Text = "Payment Method";
            // 
            // rbtMasterCard
            // 
            rbtMasterCard.AutoSize = true;
            rbtMasterCard.Location = new Point(6, 64);
            rbtMasterCard.Name = "rbtMasterCard";
            rbtMasterCard.Size = new Size(86, 19);
            rbtMasterCard.TabIndex = 5;
            rbtMasterCard.TabStop = true;
            rbtMasterCard.Text = "MasterCard";
            rbtMasterCard.UseVisualStyleBackColor = true;
            rbtMasterCard.CheckedChanged += rbtMasterCard_CheckedChanged;
            // 
            // rbtVISA
            // 
            rbtVISA.AutoSize = true;
            rbtVISA.Location = new Point(6, 23);
            rbtVISA.Name = "rbtVISA";
            rbtVISA.Size = new Size(49, 19);
            rbtVISA.TabIndex = 4;
            rbtVISA.TabStop = true;
            rbtVISA.Text = "VISA";
            rbtVISA.UseVisualStyleBackColor = true;
            rbtVISA.CheckedChanged += rbtVISA_CheckedChanged;
            // 
            // txtb1
            // 
            txtb1.Location = new Point(360, 219);
            txtb1.Name = "txtb1";
            txtb1.Size = new Size(54, 23);
            txtb1.TabIndex = 2;
            // 
            // lblQty
            // 
            lblQty.AutoSize = true;
            lblQty.Location = new Point(307, 222);
            lblQty.Name = "lblQty";
            lblQty.Size = new Size(26, 15);
            lblQty.TabIndex = 3;
            lblQty.Text = "Qty";
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(432, 218);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(75, 23);
            btnCalculate.TabIndex = 4;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblResult
            // 
            lblResult.BorderStyle = BorderStyle.Fixed3D;
            lblResult.Location = new Point(28, 304);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(479, 42);
            lblResult.TabIndex = 5;
            // 
            // frmLab2A
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult);
            Controls.Add(btnCalculate);
            Controls.Add(lblQty);
            Controls.Add(txtb1);
            Controls.Add(grpPaymentMethod);
            Controls.Add(grpWineList);
            Name = "frmLab2A";
            Text = "Lab 2A";
            grpWineList.ResumeLayout(false);
            grpWineList.PerformLayout();
            grpPaymentMethod.ResumeLayout(false);
            grpPaymentMethod.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpWineList;
        private RadioButton rbtRedWine;
        private RadioButton rbtBeer;
        private RadioButton rgtWhiteWine;
        private GroupBox grpPaymentMethod;
        private RadioButton rbtMasterCard;
        private RadioButton rbtVISA;
        private TextBox txtb1;
        private Label lblQty;
        private Button btnCalculate;
        private Label lblResult;
    }
}
