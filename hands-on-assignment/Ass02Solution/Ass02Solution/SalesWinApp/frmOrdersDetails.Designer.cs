namespace SalesWinApp
{
    partial class frmOrdersDetails
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
            dgvOrderDetail = new DataGridView();
            label1 = new Label();
            btnAddOrderDetails = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetail).BeginInit();
            SuspendLayout();
            // 
            // dgvOrderDetail
            // 
            dgvOrderDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderDetail.Location = new Point(12, 124);
            dgvOrderDetail.Name = "dgvOrderDetail";
            dgvOrderDetail.RowHeadersWidth = 62;
            dgvOrderDetail.RowTemplate.Height = 33;
            dgvOrderDetail.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrderDetail.Size = new Size(776, 381);
            dgvOrderDetail.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(33, 25);
            label1.Name = "label1";
            label1.Size = new Size(151, 30);
            label1.TabIndex = 1;
            label1.Text = "Order Details";
            // 
            // btnAddOrderDetails
            // 
            btnAddOrderDetails.Location = new Point(340, 73);
            btnAddOrderDetails.Name = "btnAddOrderDetails";
            btnAddOrderDetails.Size = new Size(175, 34);
            btnAddOrderDetails.TabIndex = 2;
            btnAddOrderDetails.Text = "Add Order Details";
            btnAddOrderDetails.UseVisualStyleBackColor = true;
            btnAddOrderDetails.Click += btnAddOrderDetails_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(96, 73);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(190, 34);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update Order Details";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(574, 73);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(107, 34);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // frmOrdersDetails
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 517);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAddOrderDetails);
            Controls.Add(label1);
            Controls.Add(dgvOrderDetail);
            Name = "frmOrdersDetails";
            Text = "frmOrdersDetails";
            Load += frmOrdersDetails_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetail).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvOrderDetail;
        private Label label1;
        private Button btnAddOrderDetails;
        private Button btnUpdate;
        private Button btnDelete;
    }
}