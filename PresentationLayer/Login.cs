using Microsoft.VisualBasic;
using PoppelOrderSystem.BusinessLayer;
using PoppelOrderSystem.DatabaseLayer;
using System;
using System.Windows.Forms;

namespace PoppelOrderSystem
{

    public partial class Login : Form

    {

        #region Variables
        private MarketingClerkDB marketingClerkDB;
        private MarketingClerkController marketingClerkController;
        private Boolean EmpIDFound = false;///stores whether the EMP exists
        private string employeeID = "";///stores the employeeID
        private string emID;
        //store when user clicks on forgot password
        Boolean bForgot;
        #endregion
        #region Methods
        private void resetAll()
        {
            lblHeading.Text = "Sign in to start order";
            lblEmail.Text = "Email/Employee ID";
            lblPassword.Text = "Password";
            txtBoxPassword.UseSystemPasswordChar = true;
            txtBoxEmail.UseSystemPasswordChar = false;
            lblInvalid.Visible = false;
            bForgot = false;
            lblForgotP.Visible = true;
            lblViewP.Visible = true;
            btnLogin.Text = "Sign in";
            txtBoxPassword.Clear();
            txtBoxEmail.Clear();


        }
        #endregion
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Boolean variable to ensure everything is correct before being allowed to proceed
            ////IF purpose of clicking button is to login
            Boolean bInvalid = false;
            if (btnLogin.Text == "Sign in")
            {
                ///Fill collection with all the data on the MArketing Clerk Database
                marketingClerkDB = new MarketingClerkDB();
                //marketingClerkDB.Add2Collection("MarketingClerk");
                ///Store information entered by user
                string email = txtBoxEmail.Text;
                string password = txtBoxPassword.Text;
                if (email == "")
                {
                    lblInvalid.Visible = true;
                    lblInvalid.Text = "Email/Employee ID field cannot be empty";
                    bInvalid = true;

                }
                else if (password == "")
                {
                    lblInvalid.Visible = true;
                    lblInvalid.Text = "Password field cannot be empty";
                    bInvalid = true;

                }
                else if (password == "" && email == "")
                {
                    lblInvalid.Visible = true;
                    lblInvalid.Text = "Email/Employee ID and Password fields cannot be empty";
                    bInvalid = true;
                }

                ///use a boolean variable to store whether information entered exists in DB
                marketingClerkController = new MarketingClerkController();
                Boolean found = marketingClerkController.getClerk(email, password);

                if (found == true)
                {
                    CustomerForm customerForm;
                    customerForm = new CustomerForm(email);
                    customerForm.Show();
                    this.Hide();
                    this.resetAll();
                }
                else if (txtBoxEmail.Text == "" || txtBoxPassword.Text == "")
                {
                    lblInvalid.Text = "Fields cannot be empty.";
                    lblInvalid.Visible = true;
                }
                else
                {
                    lblInvalid.Text = "Details entered are invalid. Try Again.";
                    lblInvalid.Visible = true;
                }
            }

            ///If purpose of clicking button is to update password
            else
            {
                string newPassword = txtBoxEmail.Text;
                string confirmPassword = txtBoxPassword.Text;
                if (newPassword.Length < 8)
                {

                    bInvalid = true;
                    lblInvalid.Visible = true;
                    lblInvalid.Text = "Password length has to be atleast 8 characters.";
                }
                else if (newPassword != confirmPassword)
                {
                    bInvalid = true;
                    lblInvalid.Visible = true;
                    lblInvalid.Text = "Passwords do not match.";
                    lblInvalid.Text = "Passwords do not match.";
                }
                if (bInvalid == false)
                {
                    marketingClerkDB = new MarketingClerkDB();
                    // marketingClerkDB.updatePassword(newPassword, employeeID);
                    resetAll();

                    MessageBox.Show("Password change SUCCESSFUL.");
                }

            }


        }

        private void txtBoxEmail_Enter(object sender, EventArgs e)
        {


        }

        private void txtBoxEmail_Leave(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //store when user clicks on forgot password
            Boolean bForgot = false;
        }

        private void Form1_Activated(object sender, EventArgs e)
        {

        }

        private void txtBoxPassword_Enter(object sender, EventArgs e)
        {

        }

        private void txtBoxPassword_Leave(object sender, EventArgs e)
        {

        }

        private void lblForgotP_Click(object sender, EventArgs e)
        {
            ///prompt the user to enter they employee ID
            employeeID = Interaction.InputBox("Please enter your employee ID to reset your password", "Find Employee", "", 250, 250);
            ///Fill collection with all the data on the MArketing Clerk Database
            marketingClerkDB = new MarketingClerkDB();
            ;
            ///use a boolean variable to store whether information entered exists in DB
            marketingClerkController = new MarketingClerkController();
            EmpIDFound = marketingClerkController.findEmpID(employeeID);
            if (EmpIDFound == true)
            ///Allow user to change password
            {
                ///Store that password has been forgotten
                bForgot = true;
                lblForgotP.Visible = false;
                lblHeading.Text = "Reset Password";
                btnLogin.Text = "Update Password";
                lblEmail.Text = "Password";
                lblPassword.Text = "Confirm Password";
                lblInvalid.Visible = false;
                txtBoxEmail.UseSystemPasswordChar = true;
                ////Clear textboxes
                txtBoxEmail.Clear();
                txtBoxPassword.Clear();

                MessageBox.Show("Employee ID " + employeeID + " found. Proceed to reset password.");

            }
            else
                MessageBox.Show("Employee ID " + employeeID + " does not exist.");
        }

        private void lblViewP_Click(object sender, EventArgs e)
        {
            //Create a timer to show password for 1 second
            Timer timer = new Timer
            {
                Interval = 4000
            };
            timer.Tick += new System.EventHandler(OnTimerEvent);
            timer.Enabled = true;
            txtBoxPassword.UseSystemPasswordChar = false;

            //Check if email textbox is currently displaying a password as well
            if (bForgot == true)
            {
                txtBoxEmail.UseSystemPasswordChar = false;
            }
        }

        //Create an event to show the password for 1 second
        public void OnTimerEvent(object source, EventArgs e)
        {
            txtBoxPassword.UseSystemPasswordChar = true;
            //Check if email textbox is currently displaying a password as well
            if (bForgot == true)
            {
                txtBoxEmail.UseSystemPasswordChar = true;
            }
        }
    }
}
