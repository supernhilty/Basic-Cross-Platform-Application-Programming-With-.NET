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
    public partial class frmOrderUpdate : Form
    {
        private readonly IOrderRepository _orderRepository = new OrderRepository();
        public Order Order { get; set; }
        public bool IsUpdate { get; set; }
        public Member Member { get; set; }
        public frmOrderUpdate()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach (Control contr in this.Controls)
            {
                if (contr is TextBox)
                {
                    if (contr.Text == string.Empty && contr.Enabled == true)
                    {
                        MessageBox.Show("Please fill " + contr.Name + "!");
                        break;
                    }
                }

            }
            try
            {
                if (dtOrderDate.Value.Date > dtShippedDate.Value.Date)
                    throw new Exception("Shipped Date must be after or equal Order Date!");
                if (dtOrderDate.Value.Date > dtRequiredDate.Value.Date)
                    throw new Exception("Required Date must be after or equal Order Date!");
                if (dtRequiredDate.Value.Date > dtShippedDate.Value.Date)
                    throw new Exception("Shipped Date must be after or equal Required Date!");
                
                if (IsUpdate)
                {
                    Order.MemberId = int.Parse(txtMemberId.Text);
                    Order.Freight = decimal.Parse(txtFreight.Text);
                    Order.RequiredDate = dtRequiredDate.Value.Date;
                    Order.ShippedDate = dtShippedDate.Value.Date;
                    _orderRepository.UpdateOrder(Order);
                }
                else
                {
                    Order order = new Order();
                    order.Freight = decimal.Parse(txtFreight.Text);
                    order.RequiredDate = dtRequiredDate.Value.Date;
                    order.ShippedDate = dtShippedDate.Value.Date;
                    order.OrderDate = dtOrderDate.Value.Date;
                    order.MemberId = int.Parse(txtMemberId.Text);
                    _orderRepository.AddOrder(order);
                }
               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void frmOrderUpdate_Load(object sender, EventArgs e)
        {
            if (Member != null)
            {
                txtMemberId.Enabled = false;
            }
            if (IsUpdate)
            {
                
                txtOrderId.Enabled = false;
                dtOrderDate.Enabled = false;
                txtMemberId.Text = Order.MemberId.ToString();
                if (Member != null)
                {
                    txtMemberId.Enabled=false;
                }
                txtOrderId.Text = Order.OrderId.ToString();
                dtOrderDate.Value = Order.OrderDate;
                dtRequiredDate.Value = Order.RequiredDate;
                dtShippedDate.Value = Order.ShippedDate;
                txtFreight.Text = Order.Freight.ToString();
            }
            else
            {
                txtOrderId.Enabled=false;
                if (Member != null)
                {
                    txtMemberId.Text=Member.MemberId.ToString();
                }
            }
            

        }
    }
}
