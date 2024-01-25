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
    public partial class frmProducts : Form
    {
        private readonly IProductRepository _productRepository = new ProductRepository();
        private BindingSource _source;
        public frmProducts()
        {
            InitializeComponent();
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            LoadProductList();
        }

        private void LoadProductList(IEnumerable<Product> Products = null)
        {
            if (Products == null)
            {
                Products = _productRepository.GetProducts();
            }
            _source = new BindingSource();
            _source.DataSource = Products;

            dgvProduct.DataSource = null;
            dgvProduct.DataSource = _source;
        }

        private void btnSearchByIdName_Click(object sender, EventArgs e)
        {
            txtUnit.Clear();
            string search = txtProduct.Text;
            LoadProductList(_productRepository.GetProductsByNameId(search));
        }

        private void btnSearchByUnit_Click(object sender, EventArgs e)
        {
            txtProduct.Clear();
            string search = txtUnit.Text;
            LoadProductList(_productRepository.GetProductsByUnit(search));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmProductDetails frmProductDetails = new frmProductDetails()
            {
                Text = "Add Product",
                ProductRepository = _productRepository,
                IsUpdate = false,
                Product = GetProduct()
            };
            if (frmProductDetails.ShowDialog() == DialogResult.OK)
            {
                LoadProductList();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmProductDetails frmProductDetails = new frmProductDetails()
            {
                Text = "Update Product",
                ProductRepository = _productRepository,
                IsUpdate = true,
                Product = GetProduct()
            };
            if (frmProductDetails.ShowDialog() == DialogResult.OK)
            {
                LoadProductList();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Product product = GetProduct();

                _productRepository.DeleteProduct(product.ProductId);
                LoadProductList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private Product GetProduct()
        {
            return dgvProduct.SelectedRows[0].DataBoundItem as Product;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadProductList();
        }
    }
}
