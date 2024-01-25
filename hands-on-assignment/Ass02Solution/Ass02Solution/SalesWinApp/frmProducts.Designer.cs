namespace SalesWinApp
{
    partial class frmProducts
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
            dgvProduct = new DataGridView();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnSearchByIdName = new Button();
            txtProduct = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtUnit = new TextBox();
            btnSearchByUnit = new Button();
            btnLoad = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            SuspendLayout();
            // 
            // dgvProduct
            // 
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduct.Location = new Point(12, 151);
            dgvProduct.Name = "dgvProduct";
            dgvProduct.RowHeadersWidth = 62;
            dgvProduct.RowTemplate.Height = 33;
            dgvProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProduct.Size = new Size(937, 405);
            dgvProduct.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(58, 111);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add New";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(294, 111);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 34);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(552, 111);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Detete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSearchByIdName
            // 
            btnSearchByIdName.Location = new Point(324, 42);
            btnSearchByIdName.Name = "btnSearchByIdName";
            btnSearchByIdName.Size = new Size(112, 34);
            btnSearchByIdName.TabIndex = 6;
            btnSearchByIdName.Text = "Search";
            btnSearchByIdName.UseVisualStyleBackColor = true;
            btnSearchByIdName.Click += btnSearchByIdName_Click;
            // 
            // txtProduct
            // 
            txtProduct.Location = new Point(43, 42);
            txtProduct.Name = "txtProduct";
            txtProduct.Size = new Size(256, 31);
            txtProduct.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 9);
            label1.Name = "label1";
            label1.Size = new Size(235, 25);
            label1.TabIndex = 8;
            label1.Text = "Search by Product Name/Id:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(532, 9);
            label2.Name = "label2";
            label2.Size = new Size(194, 25);
            label2.TabIndex = 11;
            label2.Text = "Search by unit in stock:";
            // 
            // txtUnit
            // 
            txtUnit.Location = new Point(532, 42);
            txtUnit.Name = "txtUnit";
            txtUnit.Size = new Size(256, 31);
            txtUnit.TabIndex = 10;
            // 
            // btnSearchByUnit
            // 
            btnSearchByUnit.Location = new Point(801, 42);
            btnSearchByUnit.Name = "btnSearchByUnit";
            btnSearchByUnit.Size = new Size(112, 34);
            btnSearchByUnit.TabIndex = 9;
            btnSearchByUnit.Text = "Search";
            btnSearchByUnit.UseVisualStyleBackColor = true;
            btnSearchByUnit.Click += btnSearchByUnit_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(799, 111);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(112, 34);
            btnLoad.TabIndex = 12;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // frmProducts
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(961, 568);
            Controls.Add(btnLoad);
            Controls.Add(label2);
            Controls.Add(txtUnit);
            Controls.Add(btnSearchByUnit);
            Controls.Add(label1);
            Controls.Add(txtProduct);
            Controls.Add(btnSearchByIdName);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dgvProduct);
            Name = "frmProducts";
            Text = "frmProducts";
            Load += frmProducts_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProduct;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnSearchByIdName;
        private TextBox txtProduct;
        private Label label1;
        private Label label2;
        private TextBox txtUnit;
        private Button btnSearchByUnit;
        private Button btnLoad;
    }
}