using System;

namespace PoppelOrderSystem.BusinessLayer
{
    public class CustomerOrder
    {
        #region DATA Members
        private string orderNo;
        static int orderId = 0;
        private string order_status;
        public string shipping_status;
        private string shipDate;
        private string shippingAddress;
        private decimal grandTotal;
        private string handleBY;
        private string product_ID;
        private string create_date;
        private string customerID;
        private int quantity;



        public enum ShippingStatus
        {
            To_Be_Collected = 0,
            In_Transit = 1,
            Delivered = 2,
        }
        public string shippingStatus
        {
            get { return shipping_status; }
            set { shipping_status = value; }
        }
        public string orderStatus
        {
            get { return order_status; }
            set { order_status = value; }
        }

        public string CustomerID
        {
            get { return customerID; }
            set { customerID = value; }
        }
        public string ShippingAddress
        {
            get { return shippingAddress; }
            set { shippingAddress = value; }
        }
        public string HandleBy
        {
            get { return handleBY; }
            set { handleBY = value; }
        }
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        public string ProductID
        {
            get { return product_ID; }
            set { product_ID = value; }
        }
        public string CreationDate
        {
            get { return create_date; }
            set { create_date = value; }
        }
        public CustomerOrder()
        {
            create_date = DateTime.Today + "";
            shipDate = DateTime.Today.AddDays(5) + "";
            orderId++;
            orderNo = orderId + "";
            order_status = "Created";
            shipping_status = "uknown";
            this.quantity = 0;
        }
        #endregion
        #region Methods
        public string OrderNo
        {
            get { return orderNo; }
            set { orderNo = value; }

        }
        public decimal GrandTotal
        {
            get { return grandTotal; }
            set { grandTotal = value; }
        }
        public string ShipDate
        {
            get { return shipDate; }
            set { shipDate = value; }
        }
        #endregion
    }
}
