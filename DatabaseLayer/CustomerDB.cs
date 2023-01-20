using PoppelOrderSystem.BusinessLayer;
using System;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;

namespace PoppelOrderSystem.DatabaseLayer
{
    internal class CustomerDB : DB
    {


        #region  Data members
        private string table1 = "Customer";
        private string sqlLocal1 = "SELECT * FROM Customer";
        private Collection<Customer> customers;
        #endregion

        #region Property Method: Collection
        public Collection<Customer> AllCustomers
        {
            get
            {
                return customers;
            }
        }
        #endregion

        #region Constructor
        public CustomerDB() : base()
        {
            customers = new Collection<Customer>();
            FillDataSet(sqlLocal1, table1);
            Add2Collection(table1);

        }
        #endregion

        #region Utility Methods
        public DataSet GetDataSet()
        {
            return dsMain;
        }
        private void Add2Collection(string table)
        {
            //Declare references to a myRow object and an Customer object
            DataRow myRow = null;
            Customer customer;

            //READ from the table  
            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    //Instantiate a new Customer object
                    customer = new Customer();
                    //Obtain each customer attribute from the specific field in the row in the table
                    customer.ID = Convert.ToString(myRow["ID"]).TrimEnd();
                    customer.Customer_ID = Convert.ToString(myRow["CustomerID"]).TrimEnd();
                    customer.Name = Convert.ToString(myRow["Name"]).TrimEnd();
                    customer.Telephone = Convert.ToString(myRow["Phone"]).TrimEnd();
                    customer.Email = Convert.ToString(myRow["Email"]).TrimEnd();
                    customer.Credit = Convert.ToDecimal(myRow["Credit"]);
                    customer.Address = Convert.ToString(myRow["Address"]).TrimEnd();


                    customers.Add(customer);
                }
            }
        }
        private void FillRow(DataRow aRow, Customer customer, DBOperation operation)
        {

            aRow["ID"] = customer.ID;
            aRow["CustomerID"] = customer.Customer_ID;
            aRow["Name"] = customer.Name;
            aRow["Phone"] = customer.Telephone;
            aRow["Email"] = customer.Email;
            aRow["Address"] = customer.Address;
            aRow["Credit"] = customer.Credit;

        }

        private int FindRow(Customer customer, string table)
        {
            int rowIndex = 0;
            DataRow myRow;
            int returnValue = -1;
            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                //Ignore rows marked as deleted in dataset
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    //In c# there is no item property (but we use the 2-dim array) it 
                    //is automatically known to the compiler when used as below
                    if (customer.ID == Convert.ToString(dsMain.Tables[table].Rows[rowIndex]["ID"]))
                    {
                        returnValue = rowIndex;
                    }
                }
                rowIndex += 1;
            }
            return returnValue;
        }
        #endregion

        #region Database Operations CRUD
        public void DataSetChange(Customer customer, DB.DBOperation operation)
        {
            DataRow aRow = null;
            string dataTable = table1;

            switch (operation)
            {
                case DB.DBOperation.Add:
                    aRow = dsMain.Tables[dataTable].NewRow();
                    FillRow(aRow, customer, operation);
                    //Add to the dataset
                    dsMain.Tables[dataTable].Rows.Add(aRow);
                    break;
                case DB.DBOperation.Edit:
                    // to Edit
                    aRow = dsMain.Tables[dataTable].Rows[FindRow(customer, dataTable)];
                    FillRow(aRow, customer, operation);
                    break;
                case DB.DBOperation.Delete:
                    //to delete

                    break;
            }
        }
        #endregion

        #region Build Parameters, Create Commands & Update database
        private void Build_INSERT_Parameters(Customer customer)
        {
            //Create Parameters to communicate with SQL INSERT...
            //add the input parameter and set its properties.             
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@ID", SqlDbType.NVarChar, 15, "ID");
            daMain.InsertCommand.Parameters.Add(param);//Add the parameter to the Parameters collection.

            param = new SqlParameter("@CustomerID", SqlDbType.NVarChar, 10, "CustomerID");
            daMain.InsertCommand.Parameters.Add(param);

            //Do the same for Description & answer -ensure that you choose the right size
            param = new SqlParameter("@Name", SqlDbType.NVarChar, 50, "Name");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Phone", SqlDbType.NVarChar, 15, "Phone");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Email", SqlDbType.NVarChar, 35, "Email");
            daMain.InsertCommand.Parameters.Add(param);
            param = new SqlParameter("@Credit", SqlDbType.NVarChar, 100, "Credit");
            daMain.InsertCommand.Parameters.Add(param);
            param = new SqlParameter("@Address", SqlDbType.NVarChar, 100, "Address");
            daMain.InsertCommand.Parameters.Add(param);

        }

        private void Build_UPDATE_Parameters(Customer customer)
        {
            //---Create Parameters to communicate with SQL UPDATE
            SqlParameter param = default(SqlParameter);

            param = new SqlParameter("@Name", SqlDbType.NVarChar, 100, "Name");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Phone", SqlDbType.NVarChar, 15, "Phone");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Email", SqlDbType.NVarChar, 35, "Email");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Credit", SqlDbType.Money, 100, "Credit");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Address", SqlDbType.NVarChar, 100, "Address");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            //testing the ID of record that needs to change with the original ID of the record
            param = new SqlParameter("@Original_ID", SqlDbType.NVarChar, 15, "ID");
            param.SourceVersion = DataRowVersion.Original;
            daMain.UpdateCommand.Parameters.Add(param);
        }

        private void Create_INSERT_Command(Customer customer)
        {
            //Create the command that must be used to insert values into the table..
            //cnMain.Open();
            daMain.InsertCommand = new SqlCommand("INSERT into Customer (ID, CustomerID, Name, Phone, Email, Credit, Address) VALUES (@ID, @CustomerID, @Name, @Phone, @Email, @Credit, @Address)", cnMain);
            //daMain.InsertCommand.ExecuteNonQuery();
            //cnMain.Close();
            Build_INSERT_Parameters(customer);
        }

        private void Create_UPDATE_Command(Customer customer)
        {
            //Create the command that must be used to insert values into one of the three tables
            //Assumption is that the ID and customer ID cannot be changed

            //cnMain.Open();
            daMain.UpdateCommand = new SqlCommand("UPDATE Customer SET Name =@Name, Phone =@Phone, Email =@Email, Credit = @Credit, Address = @Address " + "WHERE ID = @Original_ID", cnMain);
            //daMain.UpdateCommand.ExecuteNonQuery();
            // cnMain.Close();

            Build_UPDATE_Parameters(customer);
        }
        private void Create_DELETE_Command(Customer customer)
        {
            //Create the command that must be used to insert values into one of the three tables
            //Assumption is that the ID and customer ID cannot be changed

            //cnMain.Open();
            daMain.DeleteCommand = new SqlCommand("DELETE FROM Customer WHERE CustomerID= '" + customer.Customer_ID + "';", cnMain);

        }
        public bool UpdateDataSource(Customer customer)
        {
            bool success = true;
            Create_INSERT_Command(customer);
            Create_UPDATE_Command(customer);

            Create_DELETE_Command(customer);
            success = UpdateDataSource(sqlLocal1, table1);
            return success;
        }



        #endregion

    }
}
