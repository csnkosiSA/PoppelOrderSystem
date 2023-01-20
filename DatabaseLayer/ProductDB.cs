using PoppelOrderSystem.BusinessLayer;
using System;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;

namespace PoppelOrderSystem.DatabaseLayer
{
    internal class ProductDB : DB
    {


        #region  Data members
        private string table1 = "Product";
        private string sqlLocal1 = "SELECT * FROM Product";
        private Collection<Product> products;
        private Product product;
        #endregion

        #region Property Method: Collection
        public Collection<Product> AllProducts
        {
            get
            {
                return products;
            }
        }
        #endregion

        #region Constructor
        public ProductDB() : base()
        {
            products = new Collection<Product>();
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
                    product = new Product();
                    //Obtain each customer attribute from the specific field in the row in the table
                    product.ProductID = Convert.ToString(myRow["ProductID"]).TrimEnd();
                    product.ProductPrice = Convert.ToDecimal(myRow["Price"]);
                    product.ProductName = Convert.ToString(myRow["ProductName"]).TrimEnd();
                    product.ProductDescription = Convert.ToString(myRow["ProductDescription"]).TrimEnd();
                    product.ExpiryDate = Convert.ToDateTime(myRow["ExpiryDate"]);
                    product.Quantity = Convert.ToInt32(myRow["Quantity"]);


                    products.Add(product);
                }
            }
        }
        private void FillRow(DataRow aRow, Product product, DBOperation operation)
        {

            aRow["ProductID"] = product.ProductID;
            aRow["Price"] = product.ProductPrice;
            aRow["ProductName"] = product.ProductName;
            aRow["ProductDescription"] = product.ProductDescription;
            aRow["ExpiryDate"] = product.ExpiryDate;
            aRow["Quantity"] = product.Quantity;



        }

        private int FindRow(Product product, string table)
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
                    if (product.ProductID == Convert.ToString(dsMain.Tables[table].Rows[rowIndex]["ProductID"]))
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
        public void DataSetChange(Product product, DB.DBOperation operation)
        {
            DataRow aRow = null;
            string dataTable = table1;

            switch (operation)
            {
                case DB.DBOperation.Add:
                    aRow = dsMain.Tables[dataTable].NewRow();
                    FillRow(aRow, product, operation);
                    //Add to the dataset
                    dsMain.Tables[dataTable].Rows.Add(aRow);
                    break;
                case DB.DBOperation.Edit:
                    // to Edit
                    aRow = dsMain.Tables[dataTable].Rows[FindRow(product, dataTable)];
                    FillRow(aRow, product, operation);
                    break;
                case DB.DBOperation.Delete:
                    //to delete

                    break;
            }
        }
        #endregion

        #region Build Parameters, Create Commands & Update database
        private void Build_INSERT_Parameters(Product product)
        {
            //Create Parameters to communicate with SQL INSERT...
            //add the input parameter and set its properties.             
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@ProductID", SqlDbType.NVarChar, 15, "ProductID");
            daMain.InsertCommand.Parameters.Add(param);//Add the parameter to the Parameters collection.

            //Do the same for Description & answer -ensure that you choose the right size
            param = new SqlParameter("@ProductName", SqlDbType.NVarChar, 50, "ProductName");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Price", SqlDbType.Money, 15, "Price");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@ProductDescription", SqlDbType.NVarChar, 35, "ProductDescription");
            daMain.InsertCommand.Parameters.Add(param);
            param = new SqlParameter("@ExpiryDate", SqlDbType.DateTime, 100, "Expiry");
            daMain.InsertCommand.Parameters.Add(param);
            param = new SqlParameter("@Quantity", SqlDbType.SmallInt, 10, "Quantity");
            daMain.InsertCommand.Parameters.Add(param);


        }

        private void Build_UPDATE_Parameters(Product product)
        {
            //---Create Parameters to communicate with SQL UPDATE
            SqlParameter param = default(SqlParameter);

            param = new SqlParameter("@ProductID", SqlDbType.NVarChar, 100, "ProductID");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@ProductName", SqlDbType.NVarChar, 50, "ProductName");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Price", SqlDbType.Money, 15, "Price");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@ProductDescription", SqlDbType.NVarChar, 35, "ProductDescription");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@ExpiryDate", SqlDbType.NVarChar, 100, "ExpiryDate");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);
            param = new SqlParameter("@Quantity", SqlDbType.SmallInt, 10, "Quantity");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);
        }

        private void Create_INSERT_Command(Product product)
        {
            //Create the command that must be used to insert values into the table..
            //cnMain.Open();
            daMain.InsertCommand = new SqlCommand("INSERT into Product (ProductID, Price,ProductName ,ProductDesription, ExpiryDate, Quantity) VALUES (@ProductID, @Price,@ProductName, @ProductDesription, @ExpiryDate,@Quantity)", cnMain);
            //daMain.InsertCommand.ExecuteNonQuery();
            //cnMain.Close();
            Build_INSERT_Parameters(product);
        }

        private void Create_UPDATE_Command(Product product)
        {
            //Create the command that must be used to insert values into one of the three tables
            //Assumption is that the ID and customer ID cannot be changed

            //cnMain.Open();
            daMain.UpdateCommand = new SqlCommand("UPDATE Product SET  ProductID =@ProductID, Price =@Price,ProductName =@ProductName, ProductDescription =@ProductDescription, ExpiryDate = @ExpiryDate, Quantity =@Quantity" + " WHERE ProductID = @ProductID", cnMain);
            //daMain.UpdateCommand.ExecuteNonQuery();
            // cnMain.Close();

            Build_UPDATE_Parameters(product);
        }
        public bool UpdateDataSource(Product product)
        {
            bool success = true;
            Create_INSERT_Command(product);
            Create_UPDATE_Command(product);
            success = UpdateDataSource(sqlLocal1, table1);
            return success;
        }
        ///Update Quantity of product in Database



        //Restore old quantity after order cancelled
        public void restoreQuantity(Collection<Product> addedProducts)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Sizwe\\Desktop\\pp\\PoppelOrderSystem-main(2)\\PoppelOrderSystem-main\\PoppelOrderSystem-main\\PoppelOrderSystemDataBase.mdf;Integrated Security=True";
            foreach (Product aProduct in addedProducts)
            {
                string Query = "UPDATE Product SET Quantity = Quantity + '" + aProduct.Quantity + "'WHERE ProductID= '" + aProduct.ProductID + "';";
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                SqlCommand command = new SqlCommand(Query, con);
                command.ExecuteNonQuery();
                command.Dispose();
                con.Close();
            }

        }


        #endregion

    }
}
