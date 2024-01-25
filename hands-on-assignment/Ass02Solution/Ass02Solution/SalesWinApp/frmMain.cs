using BusinessObject;
using DataAccess.Repository;
using Microsoft.IdentityModel.Tokens;
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
    public partial class frmMain : Form
    {
        private readonly IProductRepository _productRepository = new ProductRepository();
        private readonly IOrderDetailsRepository _orderRepository = new OrderDetailsRepository();
        private BindingSource _source;
        public Member MemberAccount { get; set; }
        public bool IsAdmin { get; set; }
        public frmMain()
        {
            InitializeComponent();
            cboSort.SelectedIndex = 0;
        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (!IsAdmin)
            {
                mnuProduct.Visible = false;
                mnuMember.Visible = false;
                lbSale.Visible = false;
                lbSort.Visible = false;
                cboSort.Visible = false;
                LoadProductList();
            }
            else
            {
                LoadSale(_orderRepository.GetSale());
                mnuProfile.Visible = false;
            }


        }

        private void LoadProductList(IEnumerable<Product> products = null)
        {
            try
            {
                if (products == null)
                {
                    products = _productRepository.GetProducts();
                }
                _source = new BindingSource();
                _source.DataSource = products;

                dgvProduct.DataSource = null;
                dgvProduct.DataSource = _source;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load product list.");
            }



        }
        private void LoadSale(IEnumerable<Object> Sales)
        {
            try
            {
                _source = new BindingSource();
                _source.DataSource = Sales;

                dgvProduct.DataSource = null;
                dgvProduct.DataSource = _source;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void mnuProfile_Click(object sender, EventArgs e)
        {
            frmProfile frmProfile = new frmProfile()
            {
                Member = MemberAccount,
                IsUpdate = true
            };
            //frmProfile.MdiParent = this;
            frmProfile.Show();
        }

        private void mnuProduct_Click(object sender, EventArgs e)
        {
            frmProducts frmProducts = new frmProducts();
            frmProducts.Show();
        }

        private void mnuOrder_Click(object sender, EventArgs e)
        {

            frmOrder frmOrder = new frmOrder();
            if (!IsAdmin)
            {
                frmOrder.Member = MemberAccount;
            }
            frmOrder.Show();
        }

        private void mnuMember_Click(object sender, EventArgs e)
        {
            frmMembers frmMembers = new frmMembers();
            frmMembers.Show();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (IsAdmin)
            {
                LoadSale(_orderRepository.GetSale());
            }
            else
            {
                LoadProductList();
            }
        }

        private void cboSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSort.SelectedIndex == 0)
            {
                LoadSale(_orderRepository.GetSale());
            }
            else
            {
                LoadSale(_orderRepository.GetSaleAsc());
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
        }
    }
}
