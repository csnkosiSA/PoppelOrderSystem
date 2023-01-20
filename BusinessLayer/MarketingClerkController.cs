using PoppelOrderSystem.DatabaseLayer;
using System;
using System.Collections.ObjectModel;

namespace PoppelOrderSystem.BusinessLayer
{
    public class MarketingClerkController
    {
        #region Data Members
        private MarketingClerkDB marketingClerkDB;//make reference
        private Collection<MarketingClerk> marketingClerks;

        #endregion
        #region Properties
        public Collection<MarketingClerk> AllMarketingClerks
        {
            get { return marketingClerks; }
        }
        #endregion

        #region Constructor
        public MarketingClerkController()
        {
            marketingClerkDB = new MarketingClerkDB();
            marketingClerks = marketingClerkDB.AllMarketingClerks;
        }
        #endregion

        #region Search Methods
        ///Method to check whether Marketing clerk exists in the database
        public bool getClerk(string email, string password)
        {


            //Read from collection
            foreach (MarketingClerk aMarketingClerk in marketingClerks)
            {

                ///if the entered details are found in the marketing clerk DB
                if (String.Equals(email, aMarketingClerk.Email) && String.Equals(password, aMarketingClerk.Password.Trim()) || (String.Equals(email, aMarketingClerk.EmployeeID) && String.Equals(password, aMarketingClerk.Password.Trim())))

                    return true;

            }

            return false;
        }
        //Method to find if Employee ID exists in DB
        public bool findEmpID(string empID)
        {
            //Read from collection
            foreach (MarketingClerk aMarketingClerk in marketingClerks)
            {

                ///if the entered details are found in the marketing clerk DB
                if (String.Equals(empID, aMarketingClerk.EmployeeID.Trim()))
                    return true;
            }
            return false;
        }
        public int FindIndex(string email)
        {
            int counter = 0;
            bool found = false;
            ///Looking for marketing clerk ID in marketing clerk collection
            found = (email == AllMarketingClerks[counter].Email);

            while (!(found) && (counter < AllMarketingClerks.Count - 1))
            {
                counter++;
                found = (email == AllMarketingClerks[counter].Email); ;
            }
            ///if ID exists in collection
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
