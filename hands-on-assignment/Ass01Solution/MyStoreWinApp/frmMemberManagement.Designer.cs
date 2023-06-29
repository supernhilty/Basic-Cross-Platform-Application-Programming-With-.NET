namespace MyStoreWinApp
{
    partial class frmMemberManagement
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
            dgvMemberList = new DataGridView();
            lbMemberName = new Label();
            lbMemberID = new Label();
            lbEmail = new Label();
            lbCity = new Label();
            lbCountry = new Label();
            lbPassword = new Label();
            txtID = new TextBox();
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtCity = new TextBox();
            txtCountry = new TextBox();
            txtPassword = new TextBox();
            txtSearch = new TextBox();
            btnSearch = new Button();
            lbSearch = new Label();
            cboCountry = new ComboBox();
            lbFilterCountry = new Label();
            lbFilterByCity = new Label();
            cboCity = new ComboBox();
            cboSort = new ComboBox();
            lbSort = new Label();
            btnNew = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnLoad = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMemberList).BeginInit();
            SuspendLayout();
            // 
            // dgvMemberList
            // 
            dgvMemberList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMemberList.Location = new Point(12, 366);
            dgvMemberList.Name = "dgvMemberList";
            dgvMemberList.ReadOnly = true;
            dgvMemberList.RowHeadersWidth = 62;
            dgvMemberList.RowTemplate.Height = 33;
            dgvMemberList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMemberList.Size = new Size(999, 270);
            dgvMemberList.TabIndex = 0;
            dgvMemberList.CellFormatting += dgvMemberList_CellFormatting;
            // 
            // lbMemberName
            // 
            lbMemberName.AutoSize = true;
            lbMemberName.Location = new Point(75, 97);
            lbMemberName.Name = "lbMemberName";
            lbMemberName.Size = new Size(131, 25);
            lbMemberName.TabIndex = 1;
            lbMemberName.Text = "Member Name";
            // 
            // lbMemberID
            // 
            lbMemberID.AutoSize = true;
            lbMemberID.Location = new Point(75, 42);
            lbMemberID.Name = "lbMemberID";
            lbMemberID.Size = new Size(102, 25);
            lbMemberID.TabIndex = 2;
            lbMemberID.Text = "Member ID";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(75, 162);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(54, 25);
            lbEmail.TabIndex = 3;
            lbEmail.Text = "Email";
            // 
            // lbCity
            // 
            lbCity.AutoSize = true;
            lbCity.Location = new Point(586, 39);
            lbCity.Name = "lbCity";
            lbCity.Size = new Size(42, 25);
            lbCity.TabIndex = 4;
            lbCity.Text = "City";
            // 
            // lbCountry
            // 
            lbCountry.AutoSize = true;
            lbCountry.Location = new Point(586, 97);
            lbCountry.Name = "lbCountry";
            lbCountry.Size = new Size(75, 25);
            lbCountry.TabIndex = 5;
            lbCountry.Text = "Country";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(586, 159);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(87, 25);
            lbPassword.TabIndex = 6;
            lbPassword.Text = "Password";
            // 
            // txtID
            // 
            txtID.Location = new Point(227, 36);
            txtID.Name = "txtID";
            txtID.Size = new Size(247, 31);
            txtID.TabIndex = 7;
            // 
            // txtName
            // 
            txtName.Location = new Point(227, 97);
            txtName.Name = "txtName";
            txtName.Size = new Size(247, 31);
            txtName.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(227, 156);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(247, 31);
            txtEmail.TabIndex = 9;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(709, 39);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(247, 31);
            txtCity.TabIndex = 10;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(709, 97);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(247, 31);
            txtCountry.TabIndex = 11;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(709, 156);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(247, 31);
            txtPassword.TabIndex = 12;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(494, 287);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(358, 31);
            txtSearch.TabIndex = 13;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(858, 287);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(112, 34);
            btnSearch.TabIndex = 14;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // lbSearch
            // 
            lbSearch.AutoSize = true;
            lbSearch.Location = new Point(494, 259);
            lbSearch.Name = "lbSearch";
            lbSearch.Size = new Size(64, 25);
            lbSearch.TabIndex = 15;
            lbSearch.Text = "Search";
            // 
            // cboCountry
            // 
            cboCountry.FormattingEnabled = true;
            cboCountry.Location = new Point(57, 287);
            cboCountry.Name = "cboCountry";
            cboCountry.Size = new Size(182, 33);
            cboCountry.TabIndex = 16;
            cboCountry.SelectedIndexChanged += cboCountry_SelectedIndexChanged;
            // 
            // lbFilterCountry
            // 
            lbFilterCountry.AutoSize = true;
            lbFilterCountry.Location = new Point(57, 260);
            lbFilterCountry.Name = "lbFilterCountry";
            lbFilterCountry.Size = new Size(142, 25);
            lbFilterCountry.TabIndex = 17;
            lbFilterCountry.Text = "Filter By Country";
            // 
            // lbFilterByCity
            // 
            lbFilterByCity.AutoSize = true;
            lbFilterByCity.Location = new Point(274, 260);
            lbFilterByCity.Name = "lbFilterByCity";
            lbFilterByCity.Size = new Size(109, 25);
            lbFilterByCity.TabIndex = 19;
            lbFilterByCity.Text = "Filter By City";
            // 
            // cboCity
            // 
            cboCity.FormattingEnabled = true;
            cboCity.Location = new Point(274, 287);
            cboCity.Name = "cboCity";
            cboCity.Size = new Size(182, 33);
            cboCity.TabIndex = 18;
            cboCity.SelectedIndexChanged += cboCity_SelectedIndexChanged;
            // 
            // cboSort
            // 
            cboSort.FormattingEnabled = true;
            cboSort.Items.AddRange(new object[] { "Member Name A - Z", "Member Name Z - A" });
            cboSort.Location = new Point(755, 327);
            cboSort.Name = "cboSort";
            cboSort.Size = new Size(256, 33);
            cboSort.Sorted = true;
            cboSort.TabIndex = 20;
            cboSort.SelectedIndexChanged += cboSort_SelectedIndexChanged;
            // 
            // lbSort
            // 
            lbSort.AutoSize = true;
            lbSort.Location = new Point(680, 330);
            lbSort.Name = "lbSort";
            lbSort.Size = new Size(69, 25);
            lbSort.TabIndex = 21;
            lbSort.Text = "Sort By";
            // 
            // btnNew
            // 
            btnNew.BackColor = SystemColors.GradientInactiveCaption;
            btnNew.Location = new Point(94, 213);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(112, 34);
            btnNew.TabIndex = 22;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.GradientInactiveCaption;
            btnUpdate.Location = new Point(362, 213);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 34);
            btnUpdate.TabIndex = 23;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.GradientInactiveCaption;
            btnDelete.Location = new Point(610, 213);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 24;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnLoad
            // 
            btnLoad.BackColor = SystemColors.ButtonFace;
            btnLoad.Location = new Point(790, 213);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(166, 34);
            btnLoad.TabIndex = 25;
            btnLoad.Text = "Load All Member";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // frmMemberManagement
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1023, 648);
            Controls.Add(btnLoad);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnNew);
            Controls.Add(lbSort);
            Controls.Add(cboSort);
            Controls.Add(lbFilterByCity);
            Controls.Add(cboCity);
            Controls.Add(lbFilterCountry);
            Controls.Add(cboCountry);
            Controls.Add(lbSearch);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(txtPassword);
            Controls.Add(txtCountry);
            Controls.Add(txtCity);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(txtID);
            Controls.Add(lbPassword);
            Controls.Add(lbCountry);
            Controls.Add(lbCity);
            Controls.Add(lbEmail);
            Controls.Add(lbMemberID);
            Controls.Add(lbMemberName);
            Controls.Add(dgvMemberList);
            Name = "frmMemberManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Member Management";
            Load += frmMemberManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMemberList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvMemberList;
        private Label lbMemberName;
        private Label lbMemberID;
        private Label lbEmail;
        private Label lbCity;
        private Label lbCountry;
        private Label lbPassword;
        private TextBox txtID;
        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtCity;
        private TextBox txtCountry;
        private TextBox txtPassword;
        private TextBox txtSearch;
        private Button btnSearch;
        private Label lbSearch;
        private ComboBox cboCountry;
        private Label lbFilterCountry;
        private Label lbFilterByCity;
        private ComboBox cboCity;
        private ComboBox cboSort;
        private Label lbSort;
        private Button btnNew;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnLoad;
    }
}