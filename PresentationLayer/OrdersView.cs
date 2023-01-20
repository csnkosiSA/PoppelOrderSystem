using PoppelOrderSystem.BusinessLayer;
using System;
using System.Collections.ObjectModel;
using System.Windows.Forms;
namespace PoppelOrderSystem.PresentationLayer
{
    public partial class OrdersView : Form
    {
        #region Variables
        public bool listFormClosed;
        private Collection<CustomerOrder> orders;

        private OrderController orderController;
        private FormStates state;
        private CustomerOrder order;
        #endregion

        #region Enumeration
        public enum FormStates
        {
            View = 0,
            Add = 1,
            Edit = 2,
            Delete = 3
        }
        #endregion
        public OrdersView(OrderController orderController)
        {
            InitializeComponent();
            this.orderController = orderController;
            orders = orderController.AllOrders;
            this.Load += OrdersView_Load;
            this.Activated += OrdersView_Activated;
            this.FormClosed += OrdersView_FormClosed;
            state = FormStates.View;
        }

        private void OrdersView_Load(object sender, EventArgs e)
        {
            orderListView.View = View.Details;
        }
        #region The List View

        public void OrderListView()
        {
            ListViewItem orderDetails;
            orderListView.Clear();
            orderListView.Columns.Insert(0, "OrderNo", 120, HorizontalAlignment.Left);
            orderListView.Columns.Insert(1, "CustomerID", 120, HorizontalAlignment.Left);
            orderListView.Columns.Insert(2, "Order_Status", 120, HorizontalAlignment.Left);
            orderListView.Columns.Insert(3, "Shipping_Date", 120, HorizontalAlignment.Left);
            orderListView.Columns.Insert(4, "Shipping_Address", 120, HorizontalAlignment.Left);
            orderListView.Columns.Insert(5, "Grand_Total", 120, HorizontalAlignment.Left);
            orderListView.Columns.Insert(6, "Product_ID", 120, HorizontalAlignment.Left);
            orderListView.Columns.Insert(7, "Creation_Date", 120, HorizontalAlignment.Left);
            orderListView.Columns.Insert(8, "Quantity", 120, HorizontalAlignment.Left);



            foreach (CustomerOrder order in orders)
            {
                orderDetails = new ListViewItem();

                orderDetails.Text = order.OrderNo.ToString();
                orderDetails.SubItems.Add(order.CustomerID.ToString());
                orderDetails.SubItems.Add(order.orderStatus);
                orderDetails.SubItems.Add(order.ShipDate);
                orderDetails.SubItems.Add(order.ShippingAddress);
                orderDetails.SubItems.Add(order.GrandTotal.ToString());
                orderDetails.SubItems.Add(order.ProductID);
                orderDetails.SubItems.Add(order.CreationDate);
                orderDetails.SubItems.Add(order.Quantity.ToString());

                orderListView.Items.Add(orderDetails);
            }
            orderListView.Refresh();
            orderListView.GridLines = true;

        }

        #endregion

        private void OrdersView_Activated(object sender, EventArgs e)
        {
            orderListView.View = View.Details;
            OrderListView();

        }

        private void OrdersView_FormClosed(object sender, FormClosedEventArgs e)
        {
            listFormClosed = true;
        }
    }
}
