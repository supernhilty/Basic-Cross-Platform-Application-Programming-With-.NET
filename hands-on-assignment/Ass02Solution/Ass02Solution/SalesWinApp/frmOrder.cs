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
    public partial class frmOrder : Form
    {
        private readonly IOrderRepository _orderRepository = new OrderRepository();
        private BindingSource _source;
        public Member Member { get; set; }
        public frmOrder()
        {
            InitializeComponent();
        }

        private void frmOrder_Load(object sender, EventArgs e)
        {
           
            LoadOrderList();
        }
        private void LoadOrderList(IEnumerable<Order> orders = null)
        {
            if (Member == null)
            {
                if (orders == null)
                {
                    orders = _orderRepository.GetOrders();
                }
                _source = new BindingSource();
                _source.DataSource = orders;

                dgvOrder.DataSource = null;
                dgvOrder.DataSource = _source;
            }
            else
            {
                if (orders == null)
                {
                    orders = _orderRepository.GetOrders(Member.MemberId);
                }
                _source = new BindingSource();
                _source.DataSource = orders;

                dgvOrder.DataSource = null;
                dgvOrder.DataSource = _source;
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime from = dtFrom.Value.Date;
                DateTime to = dtTo.Value.Date;
                LoadOrderList(_orderRepository.GetOrdersByDate(from, to));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btView_Click(object sender, EventArgs e)
        {
            frmOrdersDetails frmOrdersDetails = new frmOrdersDetails()
            {
                Order = GetOrder()
            };
            frmOrdersDetails.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmOrderUpdate frmOrderUpdate = new frmOrderUpdate()
            {
                Member = Member,
                IsUpdate = true,
                Order = GetOrder()
            };
            if (frmOrderUpdate.ShowDialog() == DialogResult.OK)
            {
                LoadOrderList();
            }
        }
        private Order? GetOrder()
        {

            return dgvOrder.SelectedRows[0].DataBoundItem as Order;




        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadOrderList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmOrderUpdate frmOrderUpdate = new frmOrderUpdate()
            {
                IsUpdate = false,

                Member = Member
            };
            if (frmOrderUpdate.ShowDialog() == DialogResult.OK)
            {
                LoadOrderList();
            }
        }

       
    }
}
