using PoppelOrderSystem.BusinessLayer;
using System;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;

namespace PoppelOrderSystem.DatabaseLayer
{
    internal class OrderDB : DB
    {

        #region  Data members
        private string table1 = "[Orders]";
        private string sqlLocal1 = "SELECT * FROM [Orders]";
        private Collection<CustomerOrder> orders;
        #endregion

        #region Property Method: Collection
        public Collection<CustomerOrder> AllOrders
        {
            get
            {
                return orders;
            }
        }
        #endregion

        #region Constructor
        public OrderDB() : base()
        {
            orders = new Collection<CustomerOrder>();
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
            CustomerOrder customerOrder;

            //READ from the table  
            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    //Instantiate a new Customer object
                    customerOrder = new CustomerOrder();
                    //Obtain each customer attribute from the specific field in the row in the table
                    customerOrder.OrderNo = Convert.ToString(myRow["OrderID"]).TrimEnd();
                    customerOrder.CustomerID = Convert.ToString(myRow["CustomerID"]).TrimEnd();
                    customerOrder.orderStatus = Convert.ToString(myRow["Order_Status"]).TrimEnd();
                    customerOrder.shippingStatus = Convert.ToString(myRow["Shipping_Date"]).TrimEnd();
                    customerOrder.ShippingAddress = Convert.ToString(myRow["Shipping_Address"]).TrimEnd();
                    customerOrder.GrandTotal = Convert.ToDecimal(myRow["Grand_Total"]);
                    customerOrder.HandleBy = Convert.ToString(myRow["Handled_By"]).TrimEnd();
                    customerOrder.ProductID = Convert.ToString(myRow["Product_ID"]).TrimEnd();
                    customerOrder.CreationDate = Convert.ToString(myRow["Creation_Date"]).TrimEnd();
                    customerOrder.Quantity = Convert.ToInt32(myRow["Quantity"]);


                    orders.Add(customerOrder);
                }
            }
        }
        private void FillRow(DataRow aRow, CustomerOrder customerOrder, DBOperation operation)
        {

            aRow["OrderID"] = customerOrder.OrderNo.ToString();
            aRow["CustomerID"] = customerOrder.CustomerID.ToString();
            aRow["Order_Status"] = customerOrder.orderStatus.ToString();
            aRow["Shipping_Date"] = customerOrder.ShipDate.ToString();
            aRow["Shipping_Address"] = customerOrder.ShippingAddress.ToString();
            aRow["Grand_Total"] = customerOrder.GrandTotal;
            aRow["Handled_By"] = customerOrder.HandleBy.ToString();
            aRow["Product_ID"] = customerOrder.ProductID.ToString();
            aRow["Creation_Date"] = customerOrder.CreationDate.ToString();
            aRow["Quantity"] = customerOrder.Quantity;
        }

        private int FindRow(CustomerOrder customerordeder, string table)
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
                    if (customerordeder.OrderNo.Equals(Convert.ToString(dsMain.Tables[table].Rows[rowIndex]["OrderID"])))
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
        public void DataSetChange(CustomerOrder customerOrder, DB.DBOperation operation)
        {
            DataRow aRow = null;
            string dataTable = table1;

            switch (operation)
            {
                case DB.DBOperation.Add:
                    aRow = dsMain.Tables[dataTable].NewRow();
                    FillRow(aRow, customerOrder, operation);
                    //Add to the dataset
                    dsMain.Tables[dataTable].Rows.Add(aRow);
                    break;
                case DB.DBOperation.Edit:
                    // to Edit
                    aRow = dsMain.Tables[dataTable].Rows[FindRow(customerOrder, dataTable)];
                    FillRow(aRow, customerOrder, operation);
                    break;
                case DB.DBOperation.Delete:
                    //to delete

                    break;
            }
        }
        #endregion

        #region Build Parameters, Create Commands & Update database
        private void Build_INSERT_Parameters(CustomerOrder customerOrder)
        {

            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@OrderID", SqlDbType.NVarChar, 15, "OrderID");
            daMain.InsertCommand.Parameters.Add(param);//Add the parameter to the Parameters collection.

            param = new SqlParameter("@CustomerID", SqlDbType.NVarChar, 10, "CustomerID");
            daMain.InsertCommand.Parameters.Add(param);
            param = new SqlParameter("@Order_Status", SqlDbType.NVarChar, 15, "Order_Status");
            daMain.InsertCommand.Parameters.Add(param);
            //Do the same for Description & answer -ensure that you choose the right size
            param = new SqlParameter("@Shipping_Date", SqlDbType.NVarChar, 50, "Shipping_Date");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Shipping_Address", SqlDbType.NVarChar, 15, "Shipping_Address");
            daMain.InsertCommand.Parameters.Add(param);
           
            param = new SqlParameter("@Grand_Total", SqlDbType.NVarChar, 35, "Grand_Total");
            daMain.InsertCommand.Parameters.Add(param);
            param = new SqlParameter("@Handled_By", SqlDbType.NVarChar, 100, "Handled_By");
            daMain.InsertCommand.Parameters.Add(param);
            param = new SqlParameter("@Product_ID", SqlDbType.NVarChar, 100, "Product_ID");
            daMain.InsertCommand.Parameters.Add(param);
            param = new SqlParameter("@Creation_Date", SqlDbType.NVarChar, 100, "Creation_Date");
            daMain.InsertCommand.Parameters.Add(param);
            param = new SqlParameter("@Quantity", SqlDbType.NVarChar, 100, "Quantity");
            daMain.InsertCommand.Parameters.Add(param);

        }

        private void Build_UPDATE_Parameters(CustomerOrder customerOrder)
        {
            //---Create Parameters to communicate with SQL UPDATE
            SqlParameter param = default(SqlParameter);

            param = new SqlParameter("@OrderID", SqlDbType.NVarChar, 15, "OrderID");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@CustomerID", SqlDbType.NVarChar, 10, "CustomerID");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);
            
            param = new SqlParameter("@Order_Status", SqlDbType.NVarChar, 15, "Order_Status");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);
            
            param = new SqlParameter("@Shipping_Date", SqlDbType.NVarChar, 50, "Shipping_Date");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Shipping_Address", SqlDbType.NVarChar, 15, "Shipping_Address");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Grand_Total", SqlDbType.NVarChar, 35, "Grand_Total");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);
            param = new SqlParameter("@Handled_By", SqlDbType.NVarChar, 100, "Handled_By");
            param.SourceVersion = DataRowVersion.Original;
            daMain.UpdateCommand.Parameters.Add(param);
            //testing the ID of record that needs to change with the original ID of the record
            param = new SqlParameter("@Product_ID", SqlDbType.NVarChar, 100, "Product_ID");
            param.SourceVersion = DataRowVersion.Original;
            daMain.UpdateCommand.Parameters.Add(param);
            param = new SqlParameter("@Creation_Date", SqlDbType.NVarChar, 100, "Creation_Date");
            param.SourceVersion = DataRowVersion.Original;
            daMain.UpdateCommand.Parameters.Add(param);
            param = new SqlParameter("@Quantity", SqlDbType.NVarChar, 100, "Quantity");
            param.SourceVersion = DataRowVersion.Original;
            daMain.UpdateCommand.Parameters.Add(param);
        }

        private void Create_INSERT_Command(CustomerOrder customerOrder)
        {

            daMain.InsertCommand = new SqlCommand("INSERT into Orders (OrderID, CustomerID, Order_Status, Shipping_Date, Shipping_Address, Grand_Total,Handled_By ,Product_ID, Creation_Date, Quantity) VALUES (@OrderID, @CustomerID, @Order_Status, @Shipping_Date, @Shipping_Address, @Grand_Total,@Handled_By ,@Product_ID, @Creation_Date, @Quantity)", cnMain);
            Build_INSERT_Parameters(customerOrder);
        }

        private void Create_UPDATE_Command(CustomerOrder customerOrder)
        {
            //Create the command that must be used to insert values into one of the three tables
            //Assumption is that the ID and customer ID cannot be changed

            //cnMain.Open();
            daMain.UpdateCommand = new SqlCommand("UPDATE Orders SET Shipping_Date =@Shipping_Date, Shipping_Address =@Shipping_Address" + "WHERE OrderID = @Original_ID", cnMain);
            //daMain.UpdateCommand.ExecuteNonQuery();
            // cnMain.Close();

            Build_UPDATE_Parameters(customerOrder);
        }
        public bool UpdateDataSource(CustomerOrder customerOrder)
        {
            bool success = true;
            Create_INSERT_Command(customerOrder);
            Create_UPDATE_Command(customerOrder);
            success = UpdateDataSource(sqlLocal1, table1);
            return success;
        }

        ///To delete a customer
        #endregion
    }
}
