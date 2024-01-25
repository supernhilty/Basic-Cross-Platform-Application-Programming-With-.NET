namespace SalesWinApp
{
    partial class frmAddOrUpdateOrderDetails
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
            txtOrderId = new TextBox();
            txtUnitPrice = new TextBox();
            txtQuantity = new TextBox();
            txtDiscount = new TextBox();
            txtProductId = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnSave = new Button();
            SuspendLayout();
            // 
            // txtOrderId
            // 
            txtOrderId.Location = new Point(173, 61);
            txtOrderId.Name = "txtOrderId";
            txtOrderId.Size = new Size(277, 31);
            txtOrderId.TabIndex = 0;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(173, 255);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(277, 31);
            txtUnitPrice.TabIndex = 1;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(173, 193);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(277, 31);
            txtQuantity.TabIndex = 2;
            // 
            // txtDiscount
            // 
            txtDiscount.Location = new Point(173, 313);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(277, 31);
            txtDiscount.TabIndex = 3;
            // 
            // txtProductId
            // 
            txtProductId.Location = new Point(173, 127);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(277, 31);
            txtProductId.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 61);
            label1.Name = "label1";
            label1.Size = new Size(79, 25);
            label1.TabIndex = 5;
            label1.Text = "Order Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 255);
            label2.Name = "label2";
            label2.Size = new Size(86, 25);
            label2.TabIndex = 6;
            label2.Text = "Unit Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 193);
            label3.Name = "label3";
            label3.Size = new Size(80, 25);
            label3.TabIndex = 7;
            label3.Text = "Quantity";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(60, 133);
            label4.Name = "label4";
            label4.Size = new Size(90, 25);
            label4.TabIndex = 8;
            label4.Text = "ProductId";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(60, 313);
            label5.Name = "label5";
            label5.Size = new Size(82, 25);
            label5.TabIndex = 9;
            label5.Text = "Discount";
            // 
            // btnSave
            // 
            btnSave.DialogResult = DialogResult.OK;
            btnSave.Location = new Point(338, 380);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // frmAddOrUpdateOrderDetails
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(558, 450);
            Controls.Add(btnSave);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtProductId);
            Controls.Add(txtDiscount);
            Controls.Add(txtQuantity);
            Controls.Add(txtUnitPrice);
            Controls.Add(txtOrderId);
            Name = "frmAddOrUpdateOrderDetails";
            Text = "frmAddOrUpdateOrderDetails";
            Load += frmAddOrUpdateOrderDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtOrderId;
        private TextBox txtUnitPrice;
        private TextBox txtQuantity;
        private TextBox txtDiscount;
        private TextBox txtProductId;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnSave;
    }
}