namespace AutomobileWinApp
{
    partial class frmCarManagement
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
            lbCarID = new Label();
            lbCarName = new Label();
            lbManufacturer = new Label();
            lbPrice = new Label();
            lbReleaseYear = new Label();
            txtCarID = new TextBox();
            txtCarName = new TextBox();
            txtManufacturer = new TextBox();
            txtPrice = new TextBox();
            txtReleaseYear = new TextBox();
            btnLoad = new Button();
            btnNew = new Button();
            btnDelete = new Button();
            btnClose = new Button();
            dgvCarList = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvCarList).BeginInit();
            SuspendLayout();
            // 
            // lbCarID
            // 
            lbCarID.AutoSize = true;
            lbCarID.Location = new Point(18, 11);
            lbCarID.Name = "lbCarID";
            lbCarID.Size = new Size(61, 25);
            lbCarID.TabIndex = 0;
            lbCarID.Text = "Car ID";
            // 
            // lbCarName
            // 
            lbCarName.AutoSize = true;
            lbCarName.Location = new Point(18, 64);
            lbCarName.Name = "lbCarName";
            lbCarName.Size = new Size(90, 25);
            lbCarName.TabIndex = 1;
            lbCarName.Text = "Car Name";
            // 
            // lbManufacturer
            // 
            lbManufacturer.AutoSize = true;
            lbManufacturer.Location = new Point(18, 115);
            lbManufacturer.Name = "lbManufacturer";
            lbManufacturer.Size = new Size(117, 25);
            lbManufacturer.TabIndex = 2;
            lbManufacturer.Text = "Manufacturer";
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Location = new Point(419, 11);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(49, 25);
            lbPrice.TabIndex = 3;
            lbPrice.Text = "Price";
            // 
            // lbReleaseYear
            // 
            lbReleaseYear.AutoSize = true;
            lbReleaseYear.Location = new Point(415, 64);
            lbReleaseYear.Name = "lbReleaseYear";
            lbReleaseYear.Size = new Size(107, 25);
            lbReleaseYear.TabIndex = 4;
            lbReleaseYear.Text = "Release Year";
            // 
            // txtCarID
            // 
            txtCarID.Location = new Point(147, 8);
            txtCarID.Name = "txtCarID";
            txtCarID.Size = new Size(251, 31);
            txtCarID.TabIndex = 5;
            // 
            // txtCarName
            // 
            txtCarName.Location = new Point(147, 58);
            txtCarName.Name = "txtCarName";
            txtCarName.Size = new Size(251, 31);
            txtCarName.TabIndex = 6;
            // 
            // txtManufacturer
            // 
            txtManufacturer.Location = new Point(147, 109);
            txtManufacturer.Name = "txtManufacturer";
            txtManufacturer.Size = new Size(251, 31);
            txtManufacturer.TabIndex = 7;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(528, 11);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(251, 31);
            txtPrice.TabIndex = 8;
            // 
            // txtReleaseYear
            // 
            txtReleaseYear.Location = new Point(528, 61);
            txtReleaseYear.Name = "txtReleaseYear";
            txtReleaseYear.Size = new Size(251, 31);
            txtReleaseYear.TabIndex = 9;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(145, 155);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(112, 34);
            btnLoad.TabIndex = 10;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(356, 155);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(112, 34);
            btnNew.TabIndex = 11;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(559, 155);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(356, 404);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(112, 34);
            btnClose.TabIndex = 13;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // dgvCarList
            // 
            dgvCarList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarList.Location = new Point(18, 195);
            dgvCarList.Name = "dgvCarList";
            dgvCarList.ReadOnly = true;
            dgvCarList.RowHeadersWidth = 62;
            dgvCarList.RowTemplate.Height = 33;
            dgvCarList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCarList.Size = new Size(761, 199);
            dgvCarList.TabIndex = 14;
            // 
            // frmCarManagement
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvCarList);
            Controls.Add(btnClose);
            Controls.Add(btnDelete);
            Controls.Add(btnNew);
            Controls.Add(btnLoad);
            Controls.Add(txtReleaseYear);
            Controls.Add(txtPrice);
            Controls.Add(txtManufacturer);
            Controls.Add(txtCarName);
            Controls.Add(txtCarID);
            Controls.Add(lbReleaseYear);
            Controls.Add(lbPrice);
            Controls.Add(lbManufacturer);
            Controls.Add(lbCarName);
            Controls.Add(lbCarID);
            Name = "frmCarManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Car Management";
            Load += frmCarManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCarList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbCarID;
        private Label lbCarName;
        private Label lbManufacturer;
        private Label lbPrice;
        private Label lbReleaseYear;
        private TextBox txtCarID;
        private TextBox txtCarName;
        private TextBox txtManufacturer;
        private TextBox txtPrice;
        private TextBox txtReleaseYear;
        private Button btnLoad;
        private Button btnNew;
        private Button btnDelete;
        private Button btnClose;
        private DataGridView dgvCarList;
    }
}