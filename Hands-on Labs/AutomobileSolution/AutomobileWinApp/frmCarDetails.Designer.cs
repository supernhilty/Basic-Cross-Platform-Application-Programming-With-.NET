namespace AutomobileWinApp
{
    partial class frmCarDetails
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
            txtPrice = new MaskedTextBox();
            txtReleaseYear = new MaskedTextBox();
            cboManufacturer = new ComboBox();
            btnCancel = new Button();
            btnSave = new Button();
            SuspendLayout();
            // 
            // lbCarID
            // 
            lbCarID.AutoSize = true;
            lbCarID.Location = new Point(40, 39);
            lbCarID.Name = "lbCarID";
            lbCarID.Size = new Size(61, 25);
            lbCarID.TabIndex = 0;
            lbCarID.Text = "Car ID";
            // 
            // lbCarName
            // 
            lbCarName.AutoSize = true;
            lbCarName.Location = new Point(40, 103);
            lbCarName.Name = "lbCarName";
            lbCarName.Size = new Size(90, 25);
            lbCarName.TabIndex = 1;
            lbCarName.Text = "Car Name";
            // 
            // lbManufacturer
            // 
            lbManufacturer.AutoSize = true;
            lbManufacturer.Location = new Point(40, 155);
            lbManufacturer.Name = "lbManufacturer";
            lbManufacturer.Size = new Size(117, 25);
            lbManufacturer.TabIndex = 2;
            lbManufacturer.Text = "Manufacturer";
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Location = new Point(40, 216);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(49, 25);
            lbPrice.TabIndex = 3;
            lbPrice.Text = "Price";
            // 
            // lbReleaseYear
            // 
            lbReleaseYear.AutoSize = true;
            lbReleaseYear.Location = new Point(40, 277);
            lbReleaseYear.Name = "lbReleaseYear";
            lbReleaseYear.Size = new Size(102, 25);
            lbReleaseYear.TabIndex = 4;
            lbReleaseYear.Text = "ReleaseYear";
            // 
            // txtCarID
            // 
            txtCarID.Location = new Point(266, 39);
            txtCarID.Name = "txtCarID";
            txtCarID.Size = new Size(313, 31);
            txtCarID.TabIndex = 5;
            // 
            // txtCarName
            // 
            txtCarName.Location = new Point(266, 100);
            txtCarName.Name = "txtCarName";
            txtCarName.Size = new Size(313, 31);
            txtCarName.TabIndex = 6;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(266, 210);
            txtPrice.Mask = "000000000";
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(313, 31);
            txtPrice.TabIndex = 7;
            txtPrice.Text = "0";
            // 
            // txtReleaseYear
            // 
            txtReleaseYear.Location = new Point(266, 274);
            txtReleaseYear.Mask = "0000";
            txtReleaseYear.Name = "txtReleaseYear";
            txtReleaseYear.Size = new Size(313, 31);
            txtReleaseYear.TabIndex = 8;
            txtReleaseYear.Text = "0";
            // 
            // cboManufacturer
            // 
            cboManufacturer.FormattingEnabled = true;
            cboManufacturer.Items.AddRange(new object[] { "Audi", "BMW", "Ford", "Honda", "Hyundai", "Kia", "Suzuki", "Toyota" });
            cboManufacturer.Location = new Point(266, 152);
            cboManufacturer.Name = "cboManufacturer";
            cboManufacturer.Size = new Size(313, 33);
            cboManufacturer.TabIndex = 9;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(467, 346);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.DialogResult = DialogResult.OK;
            btnSave.Location = new Point(266, 346);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // frmCarDetails
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(658, 430);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(cboManufacturer);
            Controls.Add(txtReleaseYear);
            Controls.Add(txtPrice);
            Controls.Add(txtCarName);
            Controls.Add(txtCarID);
            Controls.Add(lbReleaseYear);
            Controls.Add(lbPrice);
            Controls.Add(lbManufacturer);
            Controls.Add(lbCarName);
            Controls.Add(lbCarID);
            Name = "frmCarDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCarDetails";
            Load += frmCarDetails_Load;
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
        private MaskedTextBox txtPrice;
        private MaskedTextBox txtReleaseYear;
        private ComboBox cboManufacturer;
        private Button btnCancel;
        private Button btnSave;
    }
}