namespace MyStoreWinApp
{
    partial class frmMemberDetails
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
            txtPassword = new TextBox();
            txtCountry = new TextBox();
            txtCity = new TextBox();
            txtEmail = new TextBox();
            txtName = new TextBox();
            txtID = new TextBox();
            lbPassword = new Label();
            lbCountry = new Label();
            lbCity = new Label();
            lbEmail = new Label();
            lbMemberID = new Label();
            lbMemberName = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(231, 350);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(247, 31);
            txtPassword.TabIndex = 24;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(231, 294);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(247, 31);
            txtCountry.TabIndex = 23;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(231, 236);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(247, 31);
            txtCity.TabIndex = 22;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(231, 168);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(247, 31);
            txtEmail.TabIndex = 21;
            // 
            // txtName
            // 
            txtName.Location = new Point(231, 109);
            txtName.Name = "txtName";
            txtName.Size = new Size(247, 31);
            txtName.TabIndex = 20;
            // 
            // txtID
            // 
            txtID.Location = new Point(231, 48);
            txtID.Name = "txtID";
            txtID.Size = new Size(247, 31);
            txtID.TabIndex = 19;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(79, 356);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(87, 25);
            lbPassword.TabIndex = 18;
            lbPassword.Text = "Password";
            // 
            // lbCountry
            // 
            lbCountry.AutoSize = true;
            lbCountry.Location = new Point(79, 294);
            lbCountry.Name = "lbCountry";
            lbCountry.Size = new Size(75, 25);
            lbCountry.TabIndex = 17;
            lbCountry.Text = "Country";
            // 
            // lbCity
            // 
            lbCity.AutoSize = true;
            lbCity.Location = new Point(79, 236);
            lbCity.Name = "lbCity";
            lbCity.Size = new Size(42, 25);
            lbCity.TabIndex = 16;
            lbCity.Text = "City";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(79, 174);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(54, 25);
            lbEmail.TabIndex = 15;
            lbEmail.Text = "Email";
            // 
            // lbMemberID
            // 
            lbMemberID.AutoSize = true;
            lbMemberID.Location = new Point(79, 54);
            lbMemberID.Name = "lbMemberID";
            lbMemberID.Size = new Size(102, 25);
            lbMemberID.TabIndex = 14;
            lbMemberID.Text = "Member ID";
            // 
            // lbMemberName
            // 
            lbMemberName.AutoSize = true;
            lbMemberName.Location = new Point(79, 109);
            lbMemberName.Name = "lbMemberName";
            lbMemberName.Size = new Size(131, 25);
            lbMemberName.TabIndex = 13;
            lbMemberName.Text = "Member Name";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.ControlLight;
            btnCancel.Location = new Point(98, 424);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 27;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.GradientInactiveCaption;
            btnSave.DialogResult = DialogResult.OK;
            btnSave.Location = new Point(330, 424);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(157, 34);
            btnSave.TabIndex = 26;
            btnSave.Text = "Save And Exit";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // frmMemberDetails
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(573, 492);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
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
            Name = "frmMemberDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Member Details";
            Load += frmMemberDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPassword;
        private TextBox txtCountry;
        private TextBox txtCity;
        private TextBox txtEmail;
        private TextBox txtName;
        private TextBox txtID;
        private Label lbPassword;
        private Label lbCountry;
        private Label lbCity;
        private Label lbEmail;
        private Label lbMemberID;
        private Label lbMemberName;
        private Button btnCancel;
        private Button btnSave;
    }
}