namespace PoppelOrderSystem.BusinessLayer
{
    public class MarketingClerk : Person
    {
        #region data members
        private string address;
        private string email;
        private string employee_ID;
        private string years_working;
        private string password;


        #endregion
        #region Constructor

        public MarketingClerk(string email, string address, string Employee_ID, string name, string phone, string ID, string password) : base()
        {
            this.email = email;
            this.address = address;
            this.employee_ID = Employee_ID;
            this.Name = name;
            this.ID = ID;
            this.Telephone = phone;
            this.years_working = "0";
            this.password = password;

        }

        #endregion
        #region Property Methods
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string Years_working
        {
            get { return years_working; }
            set
            {
                years_working = value;
            }
        }
        public string EmployeeID
        {
            get { return employee_ID; }
            set
            {
                employee_ID = value;
            }
        }

        #endregion


    }
}
