namespace PoppelOrderSystem.BusinessLayer
{
    public class Customer : Person
    {
        #region Data members
        private decimal credit;
        private string email;
        private string address;
        private string customer_ID;

        #endregion

        #region Constructor
        public Customer() : base()
        {
            credit = 0;
            address = "";
            customer_ID = "";
            email = "";
        }

        public Customer(string email, string address, string customer_ID, string name, string phone, string id) : base()
        {
            this.credit = 0;
            this.email = email;
            this.address = address;
            this.customer_ID = customer_ID;
            this.Name = name;
            this.ID = id;
            this.Telephone = phone;
        }

        #endregion

        #region Property Methods

        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }
        public string Address
        {
            get { return this.address; }
            set { this.address = value; }
        }
        public decimal Credit
        {
            get { return this.credit; }
            set
            {
                this.credit = value;
            }
        }
        public string Customer_ID
        {
            get { return this.customer_ID; }
            set { this.customer_ID = value; }
        }
        #endregion

    }
}
