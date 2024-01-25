namespace SalesWinApp
{
    partial class frmOrderUpdate
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
            btnSave = new Button();
            txtMemberId = new TextBox();
            txtOrderId = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtFreight = new TextBox();
            label6 = new Label();
            dtOrderDate = new DateTimePicker();
            dtRequiredDate = new DateTimePicker();
            dtShippedDate = new DateTimePicker();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.DialogResult = DialogResult.OK;
            btnSave.Location = new Point(404, 370);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 21;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtMemberId
            // 
            txtMemberId.Location = new Point(216, 105);
            txtMemberId.Name = "txtMemberId";
            txtMemberId.Size = new Size(300, 31);
            txtMemberId.TabIndex = 20;
            // 
            // txtOrderId
            // 
            txtOrderId.Location = new Point(216, 54);
            txtOrderId.Name = "txtOrderId";
            txtOrderId.Size = new Size(300, 31);
            txtOrderId.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(73, 209);
            label5.Name = "label5";
            label5.Size = new Size(124, 25);
            label5.TabIndex = 15;
            label5.Text = "Required Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(73, 159);
            label4.Name = "label4";
            label4.Size = new Size(100, 25);
            label4.TabIndex = 14;
            label4.Text = "Order Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(73, 262);
            label3.Name = "label3";
            label3.Size = new Size(120, 25);
            label3.TabIndex = 13;
            label3.Text = "Shipped Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 108);
            label2.Name = "label2";
            label2.Size = new Size(100, 25);
            label2.TabIndex = 12;
            label2.Text = "Member Id";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 55);
            label1.Name = "label1";
            label1.Size = new Size(79, 25);
            label1.TabIndex = 11;
            label1.Text = "Order Id";
            // 
            // txtFreight
            // 
            txtFreight.Location = new Point(216, 314);
            txtFreight.Name = "txtFreight";
            txtFreight.Size = new Size(300, 31);
            txtFreight.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(73, 317);
            label6.Name = "label6";
            label6.Size = new Size(67, 25);
            label6.TabIndex = 22;
            label6.Text = "Freight";
            // 
            // dtOrderDate
            // 
            dtOrderDate.Location = new Point(216, 159);
            dtOrderDate.Name = "dtOrderDate";
            dtOrderDate.Size = new Size(300, 31);
            dtOrderDate.TabIndex = 24;
            // 
            // dtRequiredDate
            // 
            dtRequiredDate.Location = new Point(216, 209);
            dtRequiredDate.Name = "dtRequiredDate";
            dtRequiredDate.Size = new Size(300, 31);
            dtRequiredDate.TabIndex = 25;
            // 
            // dtShippedDate
            // 
            dtShippedDate.Location = new Point(216, 262);
            dtShippedDate.Name = "dtShippedDate";
            dtShippedDate.Size = new Size(300, 31);
            dtShippedDate.TabIndex = 26;
            // 
            // frmOrderUpdate
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(606, 485);
            Controls.Add(dtShippedDate);
            Controls.Add(dtRequiredDate);
            Controls.Add(dtOrderDate);
            Controls.Add(txtFreight);
            Controls.Add(label6);
            Controls.Add(btnSave);
            Controls.Add(txtMemberId);
            Controls.Add(txtOrderId);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmOrderUpdate";
            Text = "frmOrderUpdate";
            Load += frmOrderUpdate_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private TextBox txtMemberId;
        private TextBox txtOrderId;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtFreight;
        private Label label6;
        private DateTimePicker dtOrderDate;
        private DateTimePicker dtRequiredDate;
        private DateTimePicker dtShippedDate;
    }
}