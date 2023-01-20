using PoppelOrderSystem.BusinessLayer;
using System;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;

namespace PoppelOrderSystem.DatabaseLayer
{
    public class MarketingClerkDB : DB
    {
        #region Data members
        private Collection<MarketingClerk> MarketingClerks;
        private MarketingClerkController marketingClerkController;
        #endregion
        #region Property Method: Collection
        public Collection<MarketingClerk> AllMarketingClerks
        {
            get { return MarketingClerks; }
        }
        #endregion
        #region Constructor
        public MarketingClerkDB()
        {
            MarketingClerks = new Collection<MarketingClerk>();
            FillDataSet("SELECT * FROM MarketingClerk", "MarketingClerk");
            Add2Collection("MarketingClerk");
        }
        #endregion
        #region Utility Methods
        public DataSet GetDataSet()
        {
            return dsMain;
        }
        ///Adding each Marketing Clerk to the Marketing Clerk DB
        public void Add2Collection(string table)
        {
            ///Declare reference to a myRow object and a Marketing Clerk object
            DataRow myRow = null;
            MarketingClerk aMarketingClerk;
            //Declare references for Marketing Clerk attributes
            string ID = "", employeeID = "", name = "", yearsWorking = "", email = "", address = "", password = "", phone = "";

            //Read from tablews
            foreach (DataRow myRow_LoopVariable in dsMain.Tables[table].Rows)
            {
                ///obtain each Marketing Clerk attribute from the specific field in the row in the table
                myRow = myRow_LoopVariable;
                ID = Convert.ToString(myRow["ID"]);
                employeeID = Convert.ToString(myRow["EmployeeID"]);
                name = Convert.ToString(myRow["Name"]);

                email = Convert.ToString(myRow["Email"]);
                address = Convert.ToString(myRow["Address"]);
                yearsWorking = Convert.ToString(myRow["YearsWorking"]);
                password = Convert.ToString(myRow["Password"]);
                //Create a marketing clerk object
                aMarketingClerk = new MarketingClerk(email, address, employeeID, name, phone, ID, password);

                ///Add new marketing clerk to collection
                MarketingClerks.Add(aMarketingClerk);

            }

        }
        //Find Index of a customer

        //Update Clerk Password
        public void updatePassword(string newPassword, string EmpID)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Sizwe\\Desktop\\pp\\PoppelOrderSystem-main(2)\\PoppelOrderSystem-main\\PoppelOrderSystem-main\\PoppelOrderSystemDataBase.mdf;Integrated Security=True";
            string Query = "UPDATE MarketingClerk SET Password=' " + newPassword + "'WHERE EmployeeID= '" + EmpID + "';";
            SqlConnection sql = new SqlConnection(connectionString);
            sql.Open();
            SqlCommand sqlCommand = new SqlCommand(Query, sql);
            sql.Close();
            ///Update Collection
            marketingClerkController = new MarketingClerkController();
            int index = marketingClerkController.FindIndex(EmpID);
            /// marketingClerkController.AllMarketingClerks[index].Password = newPassword;
        }
        #endregion 
    }
}

