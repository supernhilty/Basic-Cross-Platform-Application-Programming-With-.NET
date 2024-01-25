namespace SalesWinApp
{
    partial class frmProfile
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
            label6 = new Label();
            txtId = new TextBox();
            txtPassword = new TextBox();
            txtCompany = new TextBox();
            txtCountry = new TextBox();
            txtEmail = new TextBox();
            txtCity = new TextBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 81);
            label1.Name = "label1";
            label1.Size = new Size(100, 25);
            label1.TabIndex = 0;
            label1.Text = "Member Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 140);
            label2.Name = "label2";
            label2.Size = new Size(54, 25);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(78, 202);
            label3.Name = "label3";
            label3.Size = new Size(89, 25);
            label3.TabIndex = 2;
            label3.Text = "Company";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(78, 321);
            label4.Name = "label4";
            label4.Size = new Size(75, 25);
            label4.TabIndex = 3;
            label4.Text = "Country";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(78, 258);
            label5.Name = "label5";
            label5.Size = new Size(42, 25);
            label5.TabIndex = 4;
            label5.Text = "City";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(78, 375);
            label6.Name = "label6";
            label6.Size = new Size(87, 25);
            label6.TabIndex = 5;
            label6.Text = "Password";
            // 
            // txtId
            // 
            txtId.Location = new Point(280, 81);
            txtId.Name = "txtId";
            txtId.Size = new Size(289, 31);
            txtId.TabIndex = 6;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(280, 375);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(289, 31);
            txtPassword.TabIndex = 7;
            // 
            // txtCompany
            // 
            txtCompany.Location = new Point(280, 196);
            txtCompany.Name = "txtCompany";
            txtCompany.Size = new Size(289, 31);
            txtCompany.TabIndex = 8;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(280, 321);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(289, 31);
            txtCountry.TabIndex = 9;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(280, 140);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(289, 31);
            txtEmail.TabIndex = 10;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(280, 255);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(289, 31);
            txtCity.TabIndex = 11;
            // 
            // btnSave
            // 
            btnSave.DialogResult = DialogResult.OK;
            btnSave.Location = new Point(408, 484);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(161, 34);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save Change";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // frmProfile
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(649, 561);
            Controls.Add(btnSave);
            Controls.Add(txtCity);
            Controls.Add(txtEmail);
            Controls.Add(txtCountry);
            Controls.Add(txtCompany);
            Controls.Add(txtPassword);
            Controls.Add(txtId);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "frmProfile";
            Text = "frmProfile";
            TopMost = true;
            Load += frmProfile_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtId;
        private TextBox txtPassword;
        private TextBox txtCompany;
        private TextBox txtCountry;
        private TextBox txtEmail;
        private TextBox txtCity;
        private Button btnSave;
    }
}