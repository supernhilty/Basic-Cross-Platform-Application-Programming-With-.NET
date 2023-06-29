namespace MyStoreWinApp
{
    partial class frmLogin
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
            lbMemberEmail = new Label();
            lbPassword = new Label();
            btnCancel = new Button();
            txtLogin = new Button();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            SuspendLayout();
            // 
            // lbMemberEmail
            // 
            lbMemberEmail.AutoSize = true;
            lbMemberEmail.Location = new Point(30, 107);
            lbMemberEmail.Name = "lbMemberEmail";
            lbMemberEmail.Size = new Size(54, 25);
            lbMemberEmail.TabIndex = 0;
            lbMemberEmail.Text = "Email";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(30, 206);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(87, 25);
            lbPassword.TabIndex = 1;
            lbPassword.Text = "Password";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(92, 319);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(351, 319);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(112, 34);
            txtLogin.TabIndex = 3;
            txtLogin.Text = "Login";
            txtLogin.UseVisualStyleBackColor = true;
            txtLogin.Click += txtLogin_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(154, 104);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(344, 31);
            txtEmail.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(154, 203);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(344, 31);
            txtPassword.TabIndex = 5;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 450);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtLogin);
            Controls.Add(btnCancel);
            Controls.Add(lbPassword);
            Controls.Add(lbMemberEmail);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbMemberEmail;
        private Label lbPassword;
        private Button btnCancel;
        private Button txtLogin;
        private TextBox txtEmail;
        private TextBox txtPassword;
    }
}