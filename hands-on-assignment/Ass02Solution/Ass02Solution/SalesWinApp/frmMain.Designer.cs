namespace SalesWinApp
{
    partial class frmMain
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
            mainMenu = new MenuStrip();
            mnuHome = new ToolStripMenuItem();
            mnuProfile = new ToolStripMenuItem();
            mnuManagement = new ToolStripMenuItem();
            mnuOrder = new ToolStripMenuItem();
            mnuProduct = new ToolStripMenuItem();
            mnuMember = new ToolStripMenuItem();
            dgvProduct = new DataGridView();
            lbSale = new Label();
            lbSort = new Label();
            cboSort = new ComboBox();
            btnLoad = new Button();
            btnLogOut = new Button();
            mainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            SuspendLayout();
            // 
            // mainMenu
            // 
            mainMenu.ImageScalingSize = new Size(24, 24);
            mainMenu.Items.AddRange(new ToolStripItem[] { mnuHome, mnuManagement });
            mainMenu.Location = new Point(0, 0);
            mainMenu.Name = "mainMenu";
            mainMenu.Size = new Size(963, 33);
            mainMenu.TabIndex = 0;
            mainMenu.Text = "menuStrip1";
            // 
            // mnuHome
            // 
            mnuHome.DropDownItems.AddRange(new ToolStripItem[] { mnuProfile });
            mnuHome.Name = "mnuHome";
            mnuHome.Size = new Size(77, 29);
            mnuHome.Text = "Home";
            // 
            // mnuProfile
            // 
            mnuProfile.Name = "mnuProfile";
            mnuProfile.Size = new Size(164, 34);
            mnuProfile.Text = "Profile";
            mnuProfile.Click += mnuProfile_Click;
            // 
            // mnuManagement
            // 
            mnuManagement.DropDownItems.AddRange(new ToolStripItem[] { mnuOrder, mnuProduct, mnuMember });
            mnuManagement.Name = "mnuManagement";
            mnuManagement.Size = new Size(133, 29);
            mnuManagement.Text = "Management";
            // 
            // mnuOrder
            // 
            mnuOrder.Name = "mnuOrder";
            mnuOrder.Size = new Size(181, 34);
            mnuOrder.Text = "Order";
            mnuOrder.Click += mnuOrder_Click;
            // 
            // mnuProduct
            // 
            mnuProduct.Name = "mnuProduct";
            mnuProduct.Size = new Size(181, 34);
            mnuProduct.Text = "Product";
            mnuProduct.Click += mnuProduct_Click;
            // 
            // mnuMember
            // 
            mnuMember.Name = "mnuMember";
            mnuMember.Size = new Size(181, 34);
            mnuMember.Text = "Member";
            mnuMember.Click += mnuMember_Click;
            // 
            // dgvProduct
            // 
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduct.Location = new Point(8, 72);
            dgvProduct.Name = "dgvProduct";
            dgvProduct.RowHeadersWidth = 62;
            dgvProduct.RowTemplate.Height = 33;
            dgvProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProduct.Size = new Size(943, 537);
            dgvProduct.TabIndex = 1;
            dgvProduct.CellContentClick += dgvProduct_CellContentClick;
            // 
            // lbSale
            // 
            lbSale.AutoSize = true;
            lbSale.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lbSale.Location = new Point(12, 33);
            lbSale.Name = "lbSale";
            lbSale.Size = new Size(199, 30);
            lbSale.TabIndex = 2;
            lbSale.Text = "Sale Management";
            // 
            // lbSort
            // 
            lbSort.AutoSize = true;
            lbSort.Location = new Point(707, 38);
            lbSort.Name = "lbSort";
            lbSort.Size = new Size(45, 25);
            lbSort.TabIndex = 3;
            lbSort.Text = "Sort";
            // 
            // cboSort
            // 
            cboSort.FormattingEnabled = true;
            cboSort.Items.AddRange(new object[] { "Descending", "Ascending" });
            cboSort.Location = new Point(769, 35);
            cboSort.Name = "cboSort";
            cboSort.Size = new Size(182, 33);
            cboSort.TabIndex = 4;
            cboSort.SelectedIndexChanged += cboSort_SelectedIndexChanged;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(839, 621);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(112, 34);
            btnLoad.TabIndex = 5;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.Location = new Point(707, 621);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(112, 34);
            btnLogOut.TabIndex = 6;
            btnLogOut.Text = "Log out";
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(963, 667);
            Controls.Add(btnLogOut);
            Controls.Add(btnLoad);
            Controls.Add(cboSort);
            Controls.Add(lbSort);
            Controls.Add(lbSale);
            Controls.Add(dgvProduct);
            Controls.Add(mainMenu);
            MainMenuStrip = mainMenu;
            Name = "frmMain";
            Text = "frmMain";
            Load += frmMain_Load;
            mainMenu.ResumeLayout(false);
            mainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem mnuProfile;
        private ToolStripMenuItem mnuManagement;
        private ToolStripMenuItem mnuOrder;

        private ToolStripMenuItem mnuProduct;
        private DataGridView dgvProduct;
        private ToolStripMenuItem mnuHome;
        private MenuStrip mainMenu;
        private ToolStripMenuItem mnuMember;
        private Label lbSale;
        private Label lbSort;
        private ComboBox cboSort;
        private Button btnLoad;
        private Button btnLogOut;
    }
}