namespace PoppelOrderSystem
{
    public class Person
    {
        #region data members
        private string Id, name, Phone;
        #endregion

        #region Properties
        public string ID
        {
            get { return Id; }
            set { Id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Telephone
        {
            get { return Phone; }
            set { Phone = value; }
        }
        #endregion

        #region Construtor
        public Person()
        {
            Id = "";
            name = "";
            Phone = "";
        }

        public Person(string pID, string pName, string pPhone)
        {
            Id = pID;
            name = pName;
            Phone = pPhone;
        }
        #endregion

        #region ToStringMethod
        public override string ToString()
        {
            return name + '\n' + Phone;
        }

        #endregion
    }

}
