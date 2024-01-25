namespace SalesWinApp
{
    partial class frmOrder
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
            btnUpdate = new Button();
            btView = new Button();
            btnSearch = new Button();
            dgvOrder = new DataGridView();
            dtFrom = new DateTimePicker();
            dtTo = new DateTimePicker();
            label1 = new Label();
            label4 = new Label();
            btnLoad = new Button();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).BeginInit();
            SuspendLayout();
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(544, 112);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 34);
            btnUpdate.TabIndex = 0;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btView
            // 
            btView.Location = new Point(46, 112);
            btView.Name = "btView";
            btView.Size = new Size(175, 34);
            btView.TabIndex = 1;
            btView.Text = "View Order Details";
            btView.UseVisualStyleBackColor = true;
            btView.Click += btView_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(732, 60);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(112, 34);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvOrder
            // 
            dgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrder.Location = new Point(12, 177);
            dgvOrder.Name = "dgvOrder";
            dgvOrder.ReadOnly = true;
            dgvOrder.RowHeadersWidth = 62;
            dgvOrder.RowTemplate.Height = 33;
            dgvOrder.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrder.Size = new Size(893, 307);
            dgvOrder.TabIndex = 3;
            // 
            // dtFrom
            // 
            dtFrom.Location = new Point(129, 23);
            dtFrom.Name = "dtFrom";
            dtFrom.Size = new Size(300, 31);
            dtFrom.TabIndex = 4;
            // 
            // dtTo
            // 
            dtTo.Location = new Point(544, 23);
            dtTo.Name = "dtTo";
            dtTo.Size = new Size(300, 31);
            dtTo.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 23);
            label1.Name = "label1";
            label1.Size = new Size(54, 25);
            label1.TabIndex = 6;
            label1.Text = "From";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(479, 23);
            label4.Name = "label4";
            label4.Size = new Size(30, 25);
            label4.TabIndex = 9;
            label4.Text = "To";
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(742, 112);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(112, 34);
            btnLoad.TabIndex = 10;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(303, 112);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Add Order";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // frmOrder
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(917, 530);
            Controls.Add(btnAdd);
            Controls.Add(btnLoad);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(dtTo);
            Controls.Add(dtFrom);
            Controls.Add(dgvOrder);
            Controls.Add(btnSearch);
            Controls.Add(btView);
            Controls.Add(btnUpdate);
            Name = "frmOrder";
            Text = "frmOrder";
            Load += frmOrder_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUpdate;
        private Button btView;
        private Button btnSearch;
        private DataGridView dgvOrder;
        private DateTimePicker dtFrom;
        private DateTimePicker dtTo;
        private Label label1;
        private Label label4;
        private Button btnLoad;
        private Button btnAdd;
        private Button btnDelete;
    }
}