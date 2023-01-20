using PoppelOrderSystem.BusinessLayer;
using PoppelOrderSystem.DatabaseLayer;
using System.Collections.ObjectModel;

namespace GoodFoodSystem.BusinessLayer
{
    public class CustomerController
    {
        #region Data Members
        private CustomerDB customerDB;//make reference 
        private Collection<Customer> customers;

        #endregion

        #region Properties
        public Collection<Customer> AllCustomers
        {
            get
            {
                return customers;
            }
        }
        #endregion

        #region Constructor
        public CustomerController()
        {
            //***instantiate the CustomerDB object to communicate with the database
            customerDB = new CustomerDB();
            customers = customerDB.AllCustomers;
        }
        #endregion

        #region Database Communication.
        public void DataMaintenance(Customer customer, DB.DBOperation operation)
        {
            int index = 0;
            //customerDB.InsertIntoDB(customer);
            customerDB.DataSetChange(customer, operation);//calling method to do the insert
            switch (operation)
            {
                case DB.DBOperation.Add:
                    customers.Add(customer); //*** Add the customer to the Collection
                    break;
                case DB.DBOperation.Edit:

                    index = FindIndex(customer);
                    customers[index] = customer; //**** replace details for this customer
                    break;


                case DB.DBOperation.Delete:

                    index = FindIndex(customer);
                    customers.Remove(customer); //**** replace details for this customer
                    break;
            }
        }
        //***Commit the changes to the database
        public bool FinalizeChanges(Customer customer)
        {
            //***call the CustomerDB method that will commit the changes to the database

            return customerDB.UpdateDataSource(customer);

        }
        #endregion

        #region Search Methods
        //This method  (function) searched through all the employess to finds onlly those with the required role
        public Customer Find(string ID)
        {
            int index = 0;
            bool found = (customers[index].ID == ID);  //check if it is the first record
            int count = customers.Count;
            while (!(found) && (index < customers.Count - 1))  //if not "this" record and you are not at the end of the list 
            {
                index = index + 1;
                found = (customers[index].ID == ID);   // this will be TRUE if found
            }
            return customers[index];  // this is the one!  
        }
        public int FindIndex(Customer customer)
        {

            int counter = 0;
            bool found = false;
            found = (customer.ID == customers[counter].ID);

            while (!(found) && (counter < customers.Count - 1))
            {
                counter++;
                found = (customer.ID == customers[counter].ID);
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
