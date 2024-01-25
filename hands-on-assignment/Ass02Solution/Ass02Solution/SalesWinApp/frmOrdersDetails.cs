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
    public partial class frmOrdersDetails : Form
    {
        private readonly IOrderDetailsRepository _orderDetailRepository = new OrderDetailsRepository();
        public Order Order { get; set; }
        BindingSource _source;

        public frmOrdersDetails()
        {
            InitializeComponent();
        }

        private void frmOrdersDetails_Load(object sender, EventArgs e)
        {
            LoadOrderDetail();
        }
        private void LoadOrderDetail()
        {
            dgvOrderDetail.Visible = true;
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
            label1.Text = "Order Details";
            _source = new BindingSource();
            _source.DataSource = _orderDetailRepository.GetOrderDetails(Order.OrderId);

            dgvOrderDetail.DataSource = null;
            dgvOrderDetail.DataSource = _source;
            if (_orderDetailRepository.GetOrderDetails(Order.OrderId).Count() == 0)
            {
                dgvOrderDetail.Visible = false;
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
                label1.Text = "Have no product in order, please add new!";
            }
        }

        private void btnAddOrderDetails_Click(object sender, EventArgs e)
        {
            frmAddOrUpdateOrderDetails frmAddOrUpdateOrderDetails = new frmAddOrUpdateOrderDetails()
            {
                Order = Order,
                IsUpdate = false
            };
            if (frmAddOrUpdateOrderDetails.ShowDialog() == DialogResult.OK)
            {
                LoadOrderDetail();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmAddOrUpdateOrderDetails frmAddOrUpdateOrderDetails = new frmAddOrUpdateOrderDetails()
            {
                Order = Order,
                IsUpdate = true,
                OrderDetail = GetOrderDetail()
            };
            if (frmAddOrUpdateOrderDetails.ShowDialog() == DialogResult.OK)
            {
                LoadOrderDetail();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                OrderDetail o = GetOrderDetail();
                _orderDetailRepository.Delete(o.ProductId, o.OrderId);
                LoadOrderDetail();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private OrderDetail GetOrderDetail()
        {
            return dgvOrderDetail.SelectedRows[0].DataBoundItem as OrderDetail;
        }
    }
}
