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
    public partial class frmAddOrUpdateOrderDetails : Form
    {
        private readonly IOrderDetailsRepository _repository = new OrderDetailsRepository();
        public bool IsUpdate { get; set; }
        public Order Order { get; set; }
        public OrderDetail OrderDetail { get; set; }
        public frmAddOrUpdateOrderDetails()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsUpdate)
                {
                    OrderDetail.UnitPrice = decimal.Parse(txtUnitPrice.Text);
                    OrderDetail.Quantity = int.Parse(txtQuantity.Text);
                    OrderDetail.ProductId = int.Parse(txtProductId.Text);
                    OrderDetail.Discount = float.Parse(txtDiscount.Text);
                    _repository.Update(OrderDetail);
                }
                else
                {
                    OrderDetail o = new OrderDetail()
                    {
                        OrderId = Order.OrderId,
                        ProductId = int.Parse(txtProductId.Text),
                        UnitPrice = decimal.Parse(txtUnitPrice.Text),
                        Quantity = int.Parse(txtQuantity.Text),
                        Discount = float.Parse(txtDiscount.Text)
                    };
                    _repository.AddNew(o);

                }
        }catch(Exception ex)
            {
                MessageBox.Show("Can't add product anymore!");
            }

}

        private void frmAddOrUpdateOrderDetails_Load(object sender, EventArgs e)
        {
            txtOrderId.Enabled = false;
            txtOrderId.Text = Order.OrderId.ToString();
            if (IsUpdate)
            {
                txtProductId.Text = OrderDetail.ProductId.ToString();
                txtQuantity.Text = OrderDetail.Quantity.ToString();
                txtUnitPrice.Text = OrderDetail.UnitPrice.ToString();
                txtDiscount.Text = OrderDetail.Discount.ToString();
            }
        }

    }
}
