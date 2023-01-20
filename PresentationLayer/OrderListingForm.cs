using GoodFoodSystem.BusinessLayer;
using Microsoft.VisualBasic;
using PoppelOrderSystem.BusinessLayer;
using PoppelOrderSystem.PresentationLayer;
using System;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Windows.Forms;

namespace PoppelOrderSystem
{
    public partial class OrderListingForm : Form
    {


        #region Variables
        public bool listFormClosed;
        private Collection<Product> products;
        private ProductController productController;
        private OrderController orderController;
        private FormStates state;
        private Product product;
        private CustomerOrder order;
        private CustomerOrder customerOrder;
        private Customer customer;
        private Collection<Product> addedProducts = new Collection<Product>();
        private string clerkID;
        private int quantity;
        //store total price
        private decimal totalPrice = 0;
        //store whether order has been cancelled
        Boolean bCancelled = false;
        //store whether cart is visible
        bool bCart = false;

        /// set maximum credit allowed

        private decimal threshold = 1000;
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
        #region
        #endregion
        public OrderListingForm(ProductController anProd)
        {
            InitializeComponent();
            productController = anProd;
            this.Load += Order_Load;
            this.Activated += OrderListingForm_Activated;
            this.FormClosed += OrderListingForm_FormClosed;
            state = FormStates.View;
        }
        public OrderListingForm(Customer customer, string clerkID)
        {
            InitializeComponent();
            order = new CustomerOrder();
            this.clerkID = clerkID;
            this.customer = customer;
            productController = new ProductController();
            orderController = new OrderController();

        }

        #region Utility Methods
        ///Insert initial cart values
        private void setUpCart()
        {


            Cart_richTextBox.Visible = true;
            Cart_richTextBox.Font = new Font(Cart_richTextBox.Font, Cart_richTextBox.Font.Style & ~FontStyle.Bold);
            Cart_richTextBox.Text = "Order summary for customer : " + customer.Customer_ID + "\n";
            Cart_richTextBox.AppendText("----------------------------------------------------------------------------------------------\n");
        }

        //Display Cart
        private void DisplayCart()
        {
            //Display Cart
            foreach (Product product in addedProducts)
            {
                Cart_richTextBox.AppendText(product.ProductName + "             " + product.ProductPrice + "           X           " + product.Quantity + "\n");
                ///add to total price
                totalPrice = totalPrice + (product.ProductPrice * product.Quantity);
            }
            Cart_richTextBox.AppendText("Shipping Address: " + shipping_adress_textBox.Text + "\n");
            Cart_richTextBox.AppendText("Shipping Date: " + shippingDate_textBox.Value + "\n");
            Cart_richTextBox.AppendText("Total Amount: R" + totalPrice + "\n");
            Cart_richTextBox.Visible = true;
        }
        #endregion

        #region The List View
        public void setUpOrderListView()
        {


            ListViewItem orderDetails;   //Declare variables

            //Clear current List View Control
            productList_view.Clear();

            //Set Up Columns of List View
            productList_view.Columns.Insert(0, "Porduct_ID", 120, HorizontalAlignment.Left);
            productList_view.Columns.Insert(1, "Price", 120, HorizontalAlignment.Left);
            productList_view.Columns.Insert(2, "Product_Name", 150, HorizontalAlignment.Left);
            productList_view.Columns.Insert(3, "Product_Description", 100, HorizontalAlignment.Left);
            productList_view.Columns.Insert(4, "Quantity", 100, HorizontalAlignment.Left);
            products = productController.AllProducts;
            //Add employee details to each ListView item 
            foreach (Product product in products)
            {
                orderDetails = new ListViewItem();
                orderDetails.Text = product.ProductID.ToString();
                orderDetails.SubItems.Add(product.ProductPrice.ToString());
                orderDetails.SubItems.Add(product.ProductName.ToString());
                orderDetails.SubItems.Add(product.ProductDescription.ToString());
                orderDetails.SubItems.Add(product.Quantity.ToString());

                productList_view.Items.Add(orderDetails);
            }
            productList_view.Refresh();
            productList_view.GridLines = true;
        }
        #endregion


        #region Buttons Region

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Order_Load(object sender, EventArgs e)
        {
            productList_view.View = View.Details;
        }

        private void OrderListingForm_Activated(object sender, EventArgs e)
        {

            productList_view.View = View.Details;
            customerID_txtbox.Text = customer.Customer_ID;
            orderID_textbox.Text = "2";
            handle_textBox.Text = clerkID;
            order_status_textbox.Text = order.orderStatus.ToString();
            shipping_status_textBox.Text = order.shippingStatus.ToString();
            shipping_adress_textBox.Text = customer.Address.ToString();

            setUpOrderListView();

        }

        private void OrderListingForm_Load(object sender, EventArgs e)
        {

            richTxtBoxReport.Visible = false;
            btnClose.Visible = false;
            productList_view.View = View.Details;
            btnFinish.Visible = false;
            btnCancel.Visible = false;
            lblWelcome.Text = lblWelcome.Text + " Clerk: " + clerkID;

            ///Create cart
            /// Add Clicked product to cart
            addedProducts.Clear();
            setUpCart();


        }

        private void OrderListingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            listFormClosed = true;
        }

        private void productList_view_SelectedIndexChanged(object sender, EventArgs e)
        {

            state = FormStates.View;

            if (productList_view.SelectedItems.Count > 0)   // if you selected an item 
            {
                product = productController.Find(productList_view.SelectedItems[0].Text);
                ///Insert Product ID into relevant textbox
                ProductID_textBox.Text = product.ProductID;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Set total price to 0
            totalPrice = 0;
            ///Ask CLerk if they are sure
            DialogResult dialogResult = MessageBox.Show("Are you sure you would like to cancel the order?", "Cancel Order", MessageBoxButtons.YesNo);
            ///If clerk decided to cancel order
            if (dialogResult == DialogResult.Yes)
            {
                bCancelled = true;
                foreach (Product aProduct in addedProducts)
                {


                    addedProducts.Remove(aProduct);//Remove product from cart

                    //Update Cart Display
                    setUpCart();
                    DisplayCart();
                    //Update Database
                    ///Update Database
                    int index = productController.FindIndex(aProduct);
                    products[index].Quantity = products[index].Quantity + aProduct.Quantity;//update quantity
                    productController.DataMaintenance(aProduct, DB.DBOperation.Edit);
                    productController.FinalizeChanges(aProduct);

                }
                productList_view.Refresh();
                productList_view.GridLines = true;

                ///Clear cart
                setUpCart();
                /// Add Clicked product to cart
                addedProducts.Clear();
                Cart_richTextBox.Visible = false;
                btnCancel.Visible = false;
                btnFinish.Visible = false;
                MessageBox.Show("Order cancelled succefully.");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Display cart
            bCart = true;
            setUpCart();
            DisplayCart();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Check if credit is lower than threshold first
            if (customer.Credit <= threshold)
            {
                //Check if a product was selected
                if (productList_view.SelectedItems.Count > 0)
                {

                    ///Get quantity required by customer
                    int quantity = Convert.ToInt32(Interaction.InputBox("Enter the quantity of " + product.ProductName + " required"));
                    this.quantity = quantity;
                    //Check if there is enough available in the database
                    if (quantity <= Convert.ToInt32(product.Quantity))
                    {
                        //Allow for option to cancel order now
                        btnCancel.Visible = true;
                        ///Allow for option to finish order
                        btnFinish.Visible = true;
                        bCancelled = false;//order has not been cancelled yet
                        /* /// Add to cart
                         Cart_richTextBox.AppendText(product.ProductName + " R" + product.ProductPrice + " X " + quantity + "\n");*/

                        ///Add to added products collection
                        ///check if product already on cart
                        if (addedProducts.Count >= 1)
                        {
                            int index = productController.FindIndex(product, addedProducts);
                            if (index != -1)
                                addedProducts[index].Quantity = addedProducts[index].Quantity - quantity;
                            else
                                addedProducts.Add(new Product(product.ProductID, product.ProductName, product.ProductPrice, quantity, product.ProductDescription, product.ExpiryDate));
                        }
                        else
                            addedProducts.Add(new Product(product.ProductID, product.ProductName, product.ProductPrice, quantity, product.ProductDescription, product.ExpiryDate));//There was nothing in cart

                        ///Update Database
                        product.Quantity = product.Quantity - quantity;//update quantity
                        productController.DataMaintenance(product, DB.DBOperation.Edit);
                        productController.FinalizeChanges(product);

                        productList_view.Refresh();
                        productList_view.GridLines = true;

                        ///Updae cart Dsiplay if cart currently visible
                        if (bCart == true)
                        {
                            setUpCart();
                            DisplayCart();
                        }
                        PopulateOrderObject();

                        orderController.DataMaintenance(customerOrder, DB.DBOperation.Add);
                        orderController.FinalizeChanges(customerOrder);
                        MessageBox.Show("Product Added Successfully");

                    }
                    else
                    {
                        MessageBox.Show("Maximum quantity available for selected product is " + product.Quantity);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a product to add to the cart first");
                }
            }
            //if credit status is not ok
            else
            {
                MessageBox.Show("Inform customer that their credit has to be less than or equal to R1000. It is currently at R" + customer.Credit + "Proceed to checkout to edit credit.");
            }

        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {

            ///Ask if clerk sure
            DialogResult dialogResult = MessageBox.Show("Has the customer finished their order?", "Finish Order", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                ///remove report box if visible
                richTxtBoxReport.Visible = false;
                ///Take clerk back to customer interface
                CustomerForm customerForm;
                customerForm = new CustomerForm(clerkID);
                customerForm.Show();
                this.Hide();
                //if order was not cancelled before checking out
                if (bCancelled == false)
                {
                    foreach (Product aProduct in addedProducts)
                    {

                        addedProducts.Remove(aProduct);//Remove product from cart
                        //Update Cart Display
                        setUpCart();
                        DisplayCart();
                        //Update Database
                        ///Update Database
                        int index = productController.FindIndex(aProduct);
                        products[index].Quantity = products[index].Quantity + aProduct.Quantity;//update quantity
                        productController.DataMaintenance(aProduct, DB.DBOperation.Edit);
                        productController.FinalizeChanges(aProduct);

                    }

                    productList_view.Refresh();
                    productList_view.GridLines = true;
                }
            }
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            ///Ask if clerk sure

            PopulateOrderObject();

            customerOrder.orderStatus = "Order Created";
            orderController.DataMaintenance(customerOrder, DB.DBOperation.Edit);
            DialogResult dialogResult = MessageBox.Show("Are you sure you would like to complete order?", "Complete Order", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                ProductID_textBox.Clear();
                ///Clear Cart
                bCart = false;
                //reset total price
                totalPrice = 0;
                setUpCart();
                addedProducts.Clear();
                Cart_richTextBox.Visible = false;
                btnCancel.Visible = false;
                btnFinish.Visible = false;
                MessageBox.Show("Order completed successfully");
            }

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

            ///store whether product exists in cart
            Boolean bExists = false;
            //Check if a product was selected

            if (productList_view.SelectedItems.Count > 0)
            {
                ///Ask if clerk sure
                DialogResult dialogResult = MessageBox.Show("Are you sure you would like to remove item from order?", "Remove Item", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (addedProducts.Count > 0)
                    {
                        foreach (Product aProduct in addedProducts)
                        {

                            if (aProduct.ProductID == product.ProductID)
                            {
                                addedProducts.Remove(aProduct);//Remove product from cart
                                bExists = true;///Product was found in cart
                                //Update Cart Display
                                setUpCart();
                                DisplayCart();
                                //Update Database
                                ///Update Database
                                product.Quantity = product.Quantity + aProduct.Quantity;//update quantity
                                productController.DataMaintenance(product, DB.DBOperation.Edit);
                                productController.FinalizeChanges(product);

                                productList_view.Refresh();
                                productList_view.GridLines = true;



                                MessageBox.Show(aProduct.ProductName + " has been successfully removed from the cart ");
                                break;
                            }
                        }
                    }
                }
            }
            else if (productList_view.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Select item cusomer would like removed from cart first");
                ///prevent last message from being diplayed
                bExists = true;
            }
            if (bExists == false)
            {
                MessageBox.Show(product.ProductName + " does not exist in cart ");

            }


        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ///make button to clear report visible
            btnClose.Visible = true;
            //make buttons to completeorder invisible
            //make button invisible after being clicked

            richTxtBoxReport.Visible = true;
            btnFinish.Visible = false;
            btnAdd.Visible = false;
            btnCancel.Visible = false;
            btnView.Visible = false;
            MessageBox.Show("Please close the report after viewing it\n");
            richTxtBoxReport.AppendText("Expired Products:\n");
            richTxtBoxReport.AppendText("Product:       Product expiry date: \n");
            ///iterate through all products to check which have expired
            foreach (Product prod in products)
            {
                ///if it has expired,display in rich edit box
                if (Convert.ToDateTime(prod.ExpiryDate) <= DateTime.Today)
                {
                    richTxtBoxReport.AppendText(prod.ProductName + "           " + prod.ExpiryDate + "\n");
                }
            }



        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //make button invisible after being clicked
            btnClose.Visible = false;
            richTxtBoxReport.Visible = false;
            btnFinish.Visible = true;
            btnAdd.Visible = true;
            btnCancel.Visible = true;
        }

        #endregion

        #region Popupulate Order Object region
        public void PopulateOrderObject()
        {
            customerOrder = new CustomerOrder();

            customerOrder.OrderNo = orderID_textbox.Text;
            customerOrder.CustomerID = customerID_txtbox.Text;
            customerOrder.orderStatus = "Order_Started";
            customerOrder.ShipDate = shippingDate_textBox.Text;
            customerOrder.shipping_status = shipping_status_textBox.Text;
            customerOrder.ShippingAddress = shipping_adress_textBox.Text;
            customerOrder.ProductID = ProductID_textBox.Text;
            customerOrder.HandleBy = handle_textBox.Text;
            customerOrder.Quantity = quantity;
            customerOrder.GrandTotal = product.ProductPrice;


        }

        #endregion

        private void orders_Button_Click(object sender, EventArgs e)
        {
            OrdersView ov = new OrdersView(orderController);
            ov.Show();
        }
    }
}
