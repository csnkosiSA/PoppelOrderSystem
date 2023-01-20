using PoppelOrderSystem.BusinessLayer;
using PoppelOrderSystem.DatabaseLayer;
using System.Collections.ObjectModel;

namespace GoodFoodSystem.BusinessLayer
{
    public class ProductController
    {
        #region Data Members
        private ProductDB productDB;//make reference 
        private Collection<Product> products;

        #endregion

        #region Properties
        public Collection<Product> AllProducts
        {
            get
            {
                return products;
            }
        }
        #endregion

        #region Constructor
        public ProductController()
        {
            //***instantiate the CustomerDB object to communicate with the database
            productDB = new ProductDB();
            products = productDB.AllProducts;
        }
        #endregion

        #region Database Communication.
        public void DataMaintenance(Product product, DB.DBOperation operation)
        {
            int index = 0;
            //customerDB.InsertIntoDB(customer);
            productDB.DataSetChange(product, operation);//calling method to do the insert
            switch (operation)
            {
                case DB.DBOperation.Add:
                    products.Add(product); //*** Add the customer to the Collection
                    break;
                case DB.DBOperation.Edit:

                    index = FindIndex(product);
                    products[index] = product; //**** replace details for this customer
                    break;

            }
        }
        //***Commit the changes to the database
        public bool FinalizeChanges(Product product)
        {
            //***call the EmployeeDB method that will commit the changes to the database

            return productDB.UpdateDataSource(product);

        }
        #endregion

        #region Search Methods
        //This method  (function) searched through all the employess to finds onlly those with the required role
        public Product Find(string ID)
        {
            int index = 0;
            bool found = (products[index].ProductID == ID);  //check if it is the first record
            int count = products.Count;
            while (!(found) && (index < products.Count - 1))  //if not "this" record and you are not at the end of the list 
            {
                index = index + 1;
                found = (products[index].ProductID == ID);   // this will be TRUE if found
            }
            return products[index];  // this is the one!  
        }
        public int FindIndex(Product product)
        {

            int counter = 0;
            bool found = false;
            found = (product.ProductID == products[counter].ProductID);

            while (!(found) && (counter < products.Count - 1))
            {
                counter++;
                found = (product.ProductID == products[counter].ProductID);
            }
            if (found)
            {

                return counter;
            }
            else
            {
                return -1;
            }

        }
        //check if product exists in cart collection
        public int FindIndex(Product product, Collection<Product> addedProducts)
        {

            int counter = 0;
            bool found = false;

            found = (product.ProductID == addedProducts[counter].ProductID);

            while (!(found) && (counter < addedProducts.Count - 1))
            {
                counter++;
                found = (product.ProductID == addedProducts[counter].ProductID);
            }
            if (found)
            {

                return counter;
            }
            else
            {
                return -1;
            }

        }
        #endregion
    }
}
