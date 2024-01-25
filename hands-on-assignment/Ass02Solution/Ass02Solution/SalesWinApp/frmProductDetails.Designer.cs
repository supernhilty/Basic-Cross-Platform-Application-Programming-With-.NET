namespace SalesWinApp
{
    partial class frmProductDetails
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtCategory = new TextBox();
            txtUnitPrice = new TextBox();
            txtUnitStock = new TextBox();
            txtWeight = new TextBox();
            txtName = new TextBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 70);
            label1.Name = "label1";
            label1.Size = new Size(105, 25);
            label1.TabIndex = 0;
            label1.Text = "Category Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(77, 123);
            label2.Name = "label2";
            label2.Size = new Size(126, 25);
            label2.TabIndex = 1;
            label2.Text = "Product Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(77, 277);
            label3.Name = "label3";
            label3.Size = new Size(112, 25);
            label3.TabIndex = 2;
            label3.Text = "Unit In Stock";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(77, 174);
            label4.Name = "label4";
            label4.Size = new Size(68, 25);
            label4.TabIndex = 3;
            label4.Text = "Weight";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(77, 224);
            label5.Name = "label5";
            label5.Size = new Size(86, 25);
            label5.TabIndex = 4;
            label5.Text = "Unit Price";
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(220, 69);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(203, 31);
            txtCategory.TabIndex = 5;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(220, 218);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(203, 31);
            txtUnitPrice.TabIndex = 6;
            // 
            // txtUnitStock
            // 
            txtUnitStock.Location = new Point(220, 274);
            txtUnitStock.Name = "txtUnitStock";
            txtUnitStock.Size = new Size(203, 31);
            txtUnitStock.TabIndex = 7;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(220, 171);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(203, 31);
            txtWeight.TabIndex = 8;
            // 
            // txtName
            // 
            txtName.Location = new Point(220, 120);
            txtName.Name = "txtName";
            txtName.Size = new Size(203, 31);
            txtName.TabIndex = 9;
            // 
            // btnSave
            // 
            btnSave.DialogResult = DialogResult.OK;
            btnSave.Location = new Point(311, 361);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // frmProductDetails
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 450);
            Controls.Add(btnSave);
            Controls.Add(txtName);
            Controls.Add(txtWeight);
            Controls.Add(txtUnitStock);
            Controls.Add(txtUnitPrice);
            Controls.Add(txtCategory);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmProductDetails";
            Text = "frmProductDetails";
            Load += frmProductDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtCategory;
        private TextBox txtUnitPrice;
        private TextBox txtUnitStock;
        private TextBox txtWeight;
        private TextBox txtName;
        private Button btnSave;
    }
}