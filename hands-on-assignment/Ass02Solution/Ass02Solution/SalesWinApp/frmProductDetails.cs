using BusinessObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmProductDetails : Form
    {
        public bool IsUpdate { get; set; }
        public IProductRepository ProductRepository { get; set; }
        public Product Product { get; set; }
        public frmProductDetails()
        {
            InitializeComponent();
        }

        private void frmProductDetails_Load(object sender, EventArgs e)
        {
            if (IsUpdate)
            {
                txtCategory.Text = Product.CategoryId.ToString();
                txtName.Text = Product.ProductName;
                txtWeight.Text = Product.Weight.ToString();
                txtUnitPrice.Text = Product.UnitPrice.ToString();
                txtUnitStock.Text = Product.UnitInStock.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Control contr in this.Controls)
                {
                    if(contr is TextBox)
                    {
                        if (contr.Text == string.Empty && contr.Enabled == true)
                        {
                            MessageBox.Show("Please fill " + contr.Name + "!");
                            break;
                        }
                    }
                    
                }
                if (IsUpdate)
                {
                    try
                    {
                        Product.UnitPrice = decimal.Parse(txtUnitPrice.Text);
                        Product.UnitInStock = int.Parse(txtUnitStock.Text);
                        Product.Weight = txtWeight.Text;
                        Product.ProductName = txtName.Text;
                        Product.CategoryId = int.Parse(txtCategory.Text);
                        ProductRepository.Update(Product);
                    }
                    catch(Exception exc)
                    {
                        MessageBox.Show(exc.Message);
                    }
                   
                }
                else
                {
                    Product p = new Product()
                    {
                        CategoryId = int.Parse(txtCategory.Text),
                        ProductName = txtName.Text,
                        Weight = txtWeight.Text,
                        UnitPrice = decimal.Parse(txtUnitPrice.Text),
                        UnitInStock = int.Parse(txtUnitStock.Text),
                    };
                    ProductRepository.Add(p);
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
    }
}
