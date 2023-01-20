namespace PoppelOrderSystem
{
    partial class OrderListingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.productList_view = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.OrderID_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.customerID_txtbox = new System.Windows.Forms.TextBox();
            this.order_status_textbox = new System.Windows.Forms.TextBox();
            this.shipping_status_textBox = new System.Windows.Forms.TextBox();
            this.shipping_adress_textBox = new System.Windows.Forms.TextBox();
            this.ProductID_textBox = new System.Windows.Forms.TextBox();
            this.handle_textBox = new System.Windows.Forms.TextBox();
            this.orderID_textbox = new System.Windows.Forms.TextBox();
            this.creationDate_textBox = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.shippingDate_textBox = new System.Windows.Forms.DateTimePicker();
            this.btnView = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.Cart_richTextBox = new System.Windows.Forms.RichTextBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.richTxtBoxReport = new System.Windows.Forms.RichTextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.orders_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // productList_view
            // 
            this.productList_view.HideSelection = false;
            this.productList_view.Location = new System.Drawing.Point(16, 162);
            this.productList_view.Name = "productList_view";
            this.productList_view.Size = new System.Drawing.Size(466, 381);
            this.productList_view.TabIndex = 0;
            this.productList_view.UseCompatibleStateImageBehavior = false;
            this.productList_view.SelectedIndexChanged += new System.EventHandler(this.productList_view_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Products:";
            // 
            // OrderID_label
            // 
            this.OrderID_label.AutoSize = true;
            this.OrderID_label.Location = new System.Drawing.Point(536, 211);
            this.OrderID_label.Name = "OrderID_label";
            this.OrderID_label.Size = new System.Drawing.Size(70, 20);
            this.OrderID_label.TabIndex = 2;
            this.OrderID_label.Text = "Order ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(536, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Customer ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(536, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Order Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(536, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Shipping Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(536, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Shipping Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(536, 388);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Product ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(536, 420);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Creation Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(538, 452);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Handled_By";
            // 
            // customerID_txtbox
            // 
            this.customerID_txtbox.Location = new System.Drawing.Point(687, 248);
            this.customerID_txtbox.Name = "customerID_txtbox";
            this.customerID_txtbox.Size = new System.Drawing.Size(342, 26);
            this.customerID_txtbox.TabIndex = 10;
            this.customerID_txtbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // order_status_textbox
            // 
            this.order_status_textbox.Location = new System.Drawing.Point(687, 278);
            this.order_status_textbox.Name = "order_status_textbox";
            this.order_status_textbox.Size = new System.Drawing.Size(342, 26);
            this.order_status_textbox.TabIndex = 11;
            // 
            // shipping_status_textBox
            // 
            this.shipping_status_textBox.Location = new System.Drawing.Point(687, 312);
            this.shipping_status_textBox.Name = "shipping_status_textBox";
            this.shipping_status_textBox.Size = new System.Drawing.Size(342, 26);
            this.shipping_status_textBox.TabIndex = 12;
            // 
            // shipping_adress_textBox
            // 
            this.shipping_adress_textBox.Location = new System.Drawing.Point(687, 349);
            this.shipping_adress_textBox.Name = "shipping_adress_textBox";
            this.shipping_adress_textBox.Size = new System.Drawing.Size(342, 26);
            this.shipping_adress_textBox.TabIndex = 13;
            // 
            // ProductID_textBox
            // 
            this.ProductID_textBox.Location = new System.Drawing.Point(687, 382);
            this.ProductID_textBox.Name = "ProductID_textBox";
            this.ProductID_textBox.Size = new System.Drawing.Size(342, 26);
            this.ProductID_textBox.TabIndex = 14;
            // 
            // handle_textBox
            // 
            this.handle_textBox.Location = new System.Drawing.Point(687, 446);
            this.handle_textBox.Name = "handle_textBox";
            this.handle_textBox.Size = new System.Drawing.Size(342, 26);
            this.handle_textBox.TabIndex = 15;
            // 
            // orderID_textbox
            // 
            this.orderID_textbox.Location = new System.Drawing.Point(687, 205);
            this.orderID_textbox.Name = "orderID_textbox";
            this.orderID_textbox.Size = new System.Drawing.Size(342, 26);
            this.orderID_textbox.TabIndex = 16;
            // 
            // creationDate_textBox
            // 
            this.creationDate_textBox.Location = new System.Drawing.Point(687, 414);
            this.creationDate_textBox.Name = "creationDate_textBox";
            this.creationDate_textBox.Size = new System.Drawing.Size(342, 26);
            this.creationDate_textBox.TabIndex = 17;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(554, 552);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(132, 32);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Add To Cart";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(538, 486);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Shipping Date";
            // 
            // shippingDate_textBox
            // 
            this.shippingDate_textBox.Location = new System.Drawing.Point(687, 486);
            this.shippingDate_textBox.Name = "shippingDate_textBox";
            this.shippingDate_textBox.Size = new System.Drawing.Size(342, 26);
            this.shippingDate_textBox.TabIndex = 20;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(728, 552);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(132, 32);
            this.btnView.TabIndex = 21;
            this.btnView.Text = "View Cart";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(896, 552);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(132, 32);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "Cancel Order";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.button3_Click);
            // 
            // Cart_richTextBox
            // 
            this.Cart_richTextBox.Location = new System.Drawing.Point(16, 574);
            this.Cart_richTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Cart_richTextBox.Name = "Cart_richTextBox";
            this.Cart_richTextBox.Size = new System.Drawing.Size(457, 146);
            this.Cart_richTextBox.TabIndex = 23;
            this.Cart_richTextBox.Text = "";
            this.Cart_richTextBox.Visible = false;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(440, 71);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(115, 20);
            this.lblWelcome.TabIndex = 24;
            this.lblWelcome.Text = "Welcome Back";
            // 
            // btnCheckout
            // 
            this.btnCheckout.Location = new System.Drawing.Point(638, 615);
            this.btnCheckout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(132, 35);
            this.btnCheckout.TabIndex = 25;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(778, 615);
            this.btnFinish.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(112, 35);
            this.btnFinish.TabIndex = 26;
            this.btnFinish.Text = "Finish Order";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(336, 118);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(148, 35);
            this.btnRemove.TabIndex = 27;
            this.btnRemove.Text = "Remove item";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(186, 118);
            this.btnReport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(112, 35);
            this.btnReport.TabIndex = 29;
            this.btnReport.Text = "Print Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // richTxtBoxReport
            // 
            this.richTxtBoxReport.Location = new System.Drawing.Point(540, 191);
            this.richTxtBoxReport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTxtBoxReport.Name = "richTxtBoxReport";
            this.richTxtBoxReport.Size = new System.Drawing.Size(488, 324);
            this.richTxtBoxReport.TabIndex = 30;
            this.richTxtBoxReport.Text = "";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(687, 517);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(206, 35);
            this.btnClose.TabIndex = 31;
            this.btnClose.Text = "Close Report";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // orders_Button
            // 
            this.orders_Button.Location = new System.Drawing.Point(761, 71);
            this.orders_Button.Name = "orders_Button";
            this.orders_Button.Size = new System.Drawing.Size(144, 31);
            this.orders_Button.TabIndex = 33;
            this.orders_Button.Text = "Show Orders";
            this.orders_Button.UseVisualStyleBackColor = true;
            this.orders_Button.Click += new System.EventHandler(this.orders_Button_Click);
            // 
            // OrderListingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 768);
            this.Controls.Add(this.orders_Button);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.richTxtBoxReport);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.Cart_richTextBox);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.shippingDate_textBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.creationDate_textBox);
            this.Controls.Add(this.orderID_textbox);
            this.Controls.Add(this.handle_textBox);
            this.Controls.Add(this.ProductID_textBox);
            this.Controls.Add(this.shipping_adress_textBox);
            this.Controls.Add(this.shipping_status_textBox);
            this.Controls.Add(this.order_status_textbox);
            this.Controls.Add(this.customerID_txtbox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OrderID_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productList_view);
            this.Name = "OrderListingForm";
            this.Text = "Order";
            this.Activated += new System.EventHandler(this.OrderListingForm_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OrderListingForm_FormClosed);
            this.Load += new System.EventHandler(this.OrderListingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView productList_view;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label OrderID_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox customerID_txtbox;
        private System.Windows.Forms.TextBox order_status_textbox;
        private System.Windows.Forms.TextBox shipping_status_textBox;
        private System.Windows.Forms.TextBox shipping_adress_textBox;
        private System.Windows.Forms.TextBox ProductID_textBox;
        private System.Windows.Forms.TextBox handle_textBox;
        private System.Windows.Forms.TextBox orderID_textbox;
        private System.Windows.Forms.DateTimePicker creationDate_textBox;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker shippingDate_textBox;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.RichTextBox Cart_richTextBox;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.RichTextBox richTxtBoxReport;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button orders_Button;
    }
}