using System;

namespace PoppelOrderSystem.BusinessLayer
{
    public class Product
    {
        #region members 
        private string productID;
        private string productName;
        private DateTime expiryDate;
        private decimal productPrice;
        private string productDescription;
        private int quantity;
        #endregion

        #region Constructor

        public Product()
        {
            productID = "";
            productName = "";
            expiryDate = DateTime.Today;
            productDescription = "";
            productPrice = 0;
            quantity = 0;

        }
        public Product(string productID, string productName, decimal productPrice, int quantity, string productDescription, DateTime expiryDate)
        {
            this.productID = productID;
            this.productName = productName;
            this.quantity = quantity;
            this.expiryDate = expiryDate;
            this.productDescription = productDescription;
            this.productPrice = productPrice;

        }
        #endregion

        #region Property Methods
        public string ProductID
        {
            get { return productID; }
            set { productID = value; }
        }
        public string ProductName
        {
            get { return productName; }
            set
            {
                productName = value;
            }
        }

        public decimal ProductPrice
        {
            get { return productPrice; }
            set
            {
                productPrice = value;
            }
        }
        public string ProductDescription
        {
            get { return productDescription; }
            set { productDescription = value; }
        }
        public DateTime ExpiryDate
        {
            get { return expiryDate; }
            set { expiryDate = value; }
        }
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        #endregion
    }
}
