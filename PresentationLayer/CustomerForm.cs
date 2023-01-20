using GoodFoodSystem.BusinessLayer;
using Microsoft.VisualBasic;
using PoppelOrderSystem.BusinessLayer;
using System;
using System.Collections.ObjectModel;
using System.Windows.Forms;

namespace PoppelOrderSystem
{
    public partial class CustomerForm : Form
    {

        #region Data Member
        private Customer customer;
        private CustomerController customerController;
        public bool listFormClosed;
        private Collection<Customer> customers;
        private FormStates state;
        private string clerkID;

        /// security code to update credit status
        private string securityCode = "1011";
        private int numTries = 3;//number of tries allowed for security code
        private int threshold = 1000;/// store the credit threshold



        #endregion



        #region Enumeration
        public enum FormStates
        {
            View = 0,
            Add = 1,
            Edit = 2,
            Delete = 3
        }
        #endregion
        public CustomerForm(string clerkID)
        {
            InitializeComponent();
            this.clerkID = clerkID;
            customerController = new CustomerController();
            this.clerkID = clerkID;
        }

        #region The List View
        public void setUpCustomerListView()
        {
            ListViewItem customerDetails;   //Declare variables
                                            // Customer customer;
                                            //Clear current List View Control
            customerListView.Clear();
            //Set Up Columns of List View
            customerListView.Columns.Insert(0, "ID", 120, HorizontalAlignment.Left);
            customerListView.Columns.Insert(1, "CustomerID", 120, HorizontalAlignment.Left);
            customerListView.Columns.Insert(2, "Name", 150, HorizontalAlignment.Left);
            customerListView.Columns.Insert(3, "Phone", 100, HorizontalAlignment.Left);
            customerListView.Columns.Insert(4, "Email", 100, HorizontalAlignment.Left);
            customerListView.Columns.Insert(5, "Credit", 100, HorizontalAlignment.Left);
            customerListView.Columns.Insert(6, "Address", 100, HorizontalAlignment.Left);

            customers = customerController.AllCustomers;
            foreach (Customer customer in customers)
            {
                customerDetails = new ListViewItem();
                customerDetails.Text = customer.ID.ToString();
                customerDetails.SubItems.Add(customer.Customer_ID);
                customerDetails.SubItems.Add(customer.Name);
                customerDetails.SubItems.Add(customer.Telephone);
                customerDetails.SubItems.Add(customer.Email);
                customerDetails.SubItems.Add(customer.Credit.ToString());
                customerDetails.SubItems.Add(customer.Address);

                customerListView.Items.Add(customerDetails);
            }
            customerListView.Refresh();
            customerListView.GridLines = true;
        }
        #endregion


        public void ClearAll()
        {
            ID_textBox.Clear();
            customerID_textBox.Clear();
            name_textBox.Clear();
            phone_textBox.Clear();
            email_textBox.Clear();
            credit_textBox.Clear();
            address_textBox.Clear();
            ID_textBox.Focus();
            ID_textBox.Enabled = true; ;
            customerID_textBox.Enabled = true;
        }
        private void PopulateTextBoxes(Customer cust)
        {

            ID_textBox.Text = cust.ID.ToString();
            customerID_textBox.Text = cust.Customer_ID.ToString();
            name_textBox.Text = cust.Name.ToString();
            email_textBox.Text = cust.Email.ToString();
            credit_textBox.Text = cust.Credit.ToString();
            address_textBox.Text = cust.Address.ToString();
            phone_textBox.Text = cust.Address.ToString();
        }

        public void PopulateObject()
        {
            customer = new Customer();
            customer.ID = ID_textBox.Text;
            customer.Name = name_textBox.Text;
            customer.Customer_ID = customerID_textBox.Text;
            customer.Email = email_textBox.Text;
            customer.Address = address_textBox.Text;
            customer.Telephone = phone_textBox.Text;
            customer.Credit = 0;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void name_label_Click(object sender, EventArgs e)
        {

        }

        private void cancel_button_Click(object sender, EventArgs e)
        {

            ClearAll();
        }

        private void submit_button_Click(object sender, EventArgs e)
        {

        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            //customerController = new CustomerController();
            //ClearAll();
            customerListView.View = View.Details;
            ///Initalize number of trials
            numTries = 3;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void search_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ID_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void delete_button_Click(object sender, EventArgs e)
        {

        }

        private void ok_button_Click(object sender, EventArgs e)
        {

        }

        private void insert_button_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void EnableEntries(bool value)
        {
            if ((state == FormStates.Edit) && value)
            {
                ID_textBox.Enabled = !value;
                customerID_textBox.Enabled = !value;
            }
            else
            {
                ID_textBox.Enabled = value;
                customerID_textBox.Enabled = value;
            }
            name_textBox.Enabled = value;
            phone_textBox.Enabled = value;
            email_textBox.Enabled = value;
            credit_textBox.Enabled = value;
            address_textBox.Enabled = value;
            /* if (state == FormStates.Delete)
             {
                 cancelButton.Visible = !value;
                 submitButton.Visible = !value;
             }
             else
             {
                 cancelButton.Visible = value;
                 submitButton.Visible = value;
             }*/
        }
        /*
                private void customerListView_SelectedIndexChanged(object sender, EventArgs e)
                {

                    state = FormStates.View;
                    EnableEntries(false);
                    if (customerListView.SelectedItems.Count > 0)   // if you selected an item 
                    {
                        customer = customerController.Find(customerListView.SelectedItems[0].Text);  //selected employee becoms current employee
                                                                                                     //employee = employeeController.Find(Convert.ToString(employeeListViews.SelectedItems[0]));  //selected employee becomes current employee
                        PopulateTextBoxes(customer);


                    }
                }*/

        private void insert_button_Click_1(object sender, EventArgs e)
        {
            this.PopulateObject();
            MessageBox.Show("Record has been submited to the database");
            btnNext.Visible = true;
            customerController.DataMaintenance(customer, DB.DBOperation.Add);
            customerController.FinalizeChanges(customer);

            customerListView.Refresh();
            customerListView.GridLines = true;
            ClearAll();

        }

        private void delete_button_Click_1(object sender, EventArgs e)
        {
            ///Get ID of customer to delete
            string deleteID = customerID_textBox.Text;
            DialogResult dialogResult = MessageBox.Show("Are you sure you would like to delete customer with customer ID " + deleteID, "Confirm Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //Delete Customer
                this.PopulateObject();
                btnNext.Visible = false;
                customerController.DataMaintenance(customer, DB.DBOperation.Delete);
                customerController.FinalizeChanges(customer);
                ClearAll();
                customerListView.Refresh();
                customerListView.GridLines = true;
                MessageBox.Show("Customer deleted successfully.");
            }

        }

        private void CustomerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            listFormClosed = true;
        }

        private void CustomerForm_Activated(object sender, EventArgs e)
        {
            customerListView.View = View.Details;
            setUpCustomerListView();

        }

        private void customerListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            state = FormStates.View;
            EnableEntries(false);
            if (customerListView.SelectedItems.Count > 0)
            {
                customer = customerController.Find(customerListView.SelectedItems[0].Text);
                PopulateTextBoxes(customer);
                name_textBox.Enabled = true; ;
                phone_textBox.Enabled = true;
                email_textBox.Enabled = true;
                ///Initialize number of tries allowed for changing credit status
                numTries = 3;
                address_textBox.Enabled = true;
                btnNext.Visible = true;
            }
        }

        private void ok_button_Click_1(object sender, EventArgs e)
        {
            //Get customer ID being searched for
            string customerID_search = search_textbox.Text;
            Boolean bFound = false;//store whether customer exists or not
            if (customerID_search != "")
            {
                ///Search for customer in list view
                int index = -1;


                while (index < customers.Count - 1)
                {
                    index++;
                    string line = customerListView.Items[index].SubItems[1].Text;
                    if (String.Equals(line, customerID_search))
                    {
                        bFound = true;
                        MessageBox.Show("Customer Exists");
                        //set number of trials allowed when needing to update credit
                        numTries = 3;
                        ///Populate TextBox
                        PopulateTextBoxes(customers[index]);
                        ID_textBox.Enabled = false;
                        customerID_textBox.Enabled = false;
                        credit_textBox.Enabled = false;
                        ///Allow to proceed to next interface
                        btnNext.Visible = true; ;
                        //stop searching
                        break;
                    }
                }
            }
            if (bFound == false)
            {
                MessageBox.Show("Customer does not exist. Ask customer whether they would like to become a customer.");
            }
        }


        private void update_button_Click(object sender, EventArgs e)
        {

            ///Confirm Action First
            DialogResult dialogResult = MessageBox.Show("Does the customer approve of the update?", "Customer Update", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //Update Customer Details
                this.PopulateObject();
                btnNext.Visible = true;
                ClearAll();
                customerController.DataMaintenance(customer, DB.DBOperation.Edit);
                customerController.FinalizeChanges(customer);
                customerListView.Refresh();
                customerListView.GridLines = true;
                MessageBox.Show("Customer Update Successful");
            }

        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            //check if credit status below threshold
            if (customer.Credit > threshold)
            {
                MessageBox.Show("Please inform customer that they need to pay atleast R" + (customer.Credit - threshold) + " in order to complete their. Proceed to checkout to do this.");
            }
            else
            {
                //Proceed to the next interface
                PopulateObject();
                OrderListingForm orderListingForm;
                customer.Credit = Convert.ToDecimal(credit_textBox.Text);
                orderListingForm = new OrderListingForm(customer, clerkID);
                orderListingForm.Show();
                this.Hide();
            }
        }

        private void btnCredit_Click(object sender, EventArgs e)
        {
            ///Check if there are still enough trials remaining
            if (numTries > 0)
            {
                //check if a customer has been selected
                if (ID_textBox.Text != "")
                {
                    ///prompt the user to enter the security code
                    string code = Interaction.InputBox("Please enter the security code to update credit", "Security Code", "", 250, 250);
                    //Security code matches
                    if (code == securityCode)
                    {
                        decimal amount = Convert.ToDecimal(Interaction.InputBox("Enter the amount user would like to pay (max=" + customer.Credit + ")", "Amount", "", 250, 250));

                        decimal currentCredit = Convert.ToDecimal(credit_textBox.Text);
                        if (amount > currentCredit)
                        {
                            MessageBox.Show("Maximum amount will be removed: R" + currentCredit + ".");
                            //set amount to be paid to max
                            amount = currentCredit;
                        }
                        //update with new code
                        DialogResult dialogResult = MessageBox.Show("Are you sure customer would like to pay? R" + amount, "Complete Order", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            ///Edit DB
                            //Update Customer Details
                            this.PopulateObject();
                            ClearAll();
                            btnNext.Visible = true;
                            customerController.DataMaintenance(customer, DB.DBOperation.Edit);
                            customerController.FinalizeChanges(customer);

                            customerListView.Refresh();
                            customerListView.GridLines = true;
                            MessageBox.Show("Customer credit updated successfully");


                        }
                        ///if decides against updating credit status
                        else
                        {
                            numTries = 3;
                        }



                    }
                    ///if code is not correct
                    else
                    {
                        //Decrease the number of tries allowed;
                        numTries--;
                        MessageBox.Show("Incorrect code entered. Number of trials remaining: " + numTries);
                    }
                }
                else
                {
                    //if no customer has been selected
                    MessageBox.Show("Please select a customer first.");
                }
            }
            else
                ////if there no longer trials remaining
                MessageBox.Show("Number of trials to change security code have been reached");

        }
    }
}
