using PoppelOrderSystem.DatabaseLayer;
using System;
using System.Collections.ObjectModel;

namespace PoppelOrderSystem.BusinessLayer
{
    public class OrderController
    {

        #region Data Members
        private OrderDB orderDB;//make reference 
        private Collection<CustomerOrder> orders;

        #endregion

        #region Properties
        public Collection<CustomerOrder> AllOrders
        {
            get
            {
                return orders;
            }
        }
        #endregion

        #region Constructor
        public OrderController()
        {
            //***instantiate the CustomerDB object to communicate with the database
            orderDB = new OrderDB();
            orders = orderDB.AllOrders;
        }
        #endregion

        #region Database Communication.
        public void DataMaintenance(CustomerOrder order, DB.DBOperation operation)
        {
            int index = 0;
            //customerDB.InsertIntoDB(customer);
            orderDB.DataSetChange(order, operation);//calling method to do the insert
            switch (operation)
            {
                case DB.DBOperation.Add:
                    orders.Add(order); //*** Add the customer to the Collection
                    break;
                case DB.DBOperation.Edit:

                    index = FindIndex(order);
                    orders[index] = order; //**** replace details for this customer
                    break;
                case DB.DBOperation.Delete:
                    index = FindIndex(order);
                    while (index >= 0)
                    {
                        orders.RemoveAt(index);
                        index = FindIndex(order);
                    }
                    break;
            }
        }
        //***Commit the changes to the database
        public bool FinalizeChanges(CustomerOrder order)
        {
            //***call the EmployeeDB method that will commit the changes to the database

            return orderDB.UpdateDataSource(order);

        }
        #endregion

        #region Search Methods
        //This method  (function) searched through all the employess to finds onlly those with the required role
        public CustomerOrder Find(string ID)
        {
            int index = 0;
            bool found = (orders[index].OrderNo == ID);  //check if it is the first record
            int count = orders.Count;
            while (!(found) && (index < orders.Count - 1))  //if not "this" record and you are not at the end of the list 
            {
                index = index + 1;
                found = (orders[index].OrderNo == ID);   // this will be TRUE if found
            }
            return orders[index];  // this is the one!  
        }
        public int FindIndex(CustomerOrder order)
        {

            int counter = 0;
            bool found = false;
            found = (order.OrderNo == orders[counter].OrderNo);

            while (!(found) && (counter < orders.Count - 1))
            {
                counter++;
                found = (order.OrderNo == orders[counter].OrderNo);
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
        public int LastOrderNum()
        {
            int temp = Convert.ToInt32(orders[(orders.Count - 1)].OrderNo);
            return temp;
        }
        #endregion
    }
}
