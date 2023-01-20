namespace PoppelOrderSystem
{
    partial class CustomerForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.customerListView = new System.Windows.Forms.ListView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.search_label = new System.Windows.Forms.Label();
            this.search_textbox = new System.Windows.Forms.TextBox();
            this.delete_button = new System.Windows.Forms.Button();
            this.update_button = new System.Windows.Forms.Button();
            this.insert_button = new System.Windows.Forms.Button();
            this.credit_label = new System.Windows.Forms.Label();
            this.address_label = new System.Windows.Forms.Label();
            this.email_label = new System.Windows.Forms.Label();
            this.phone_label = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.customeID_label = new System.Windows.Forms.Label();
            this.address_textBox = new System.Windows.Forms.TextBox();
            this.credit_textBox = new System.Windows.Forms.TextBox();
            this.email_textBox = new System.Windows.Forms.TextBox();
            this.phone_textBox = new System.Windows.Forms.TextBox();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.customerID_textBox = new System.Windows.Forms.TextBox();
            this.ID_textBox = new System.Windows.Forms.TextBox();
            this.ID_label = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnCredit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(17, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 17);
            this.label2.TabIndex = 54;
            this.label2.Text = "Registered Customers";
            // 
            // customerListView
            // 
            this.customerListView.HideSelection = false;
            this.customerListView.Location = new System.Drawing.Point(17, 140);
            this.customerListView.Margin = new System.Windows.Forms.Padding(2);
            this.customerListView.Name = "customerListView";
            this.customerListView.Size = new System.Drawing.Size(429, 254);
            this.customerListView.TabIndex = 49;
            this.customerListView.UseCompatibleStateImageBehavior = false;
            this.customerListView.SelectedIndexChanged += new System.EventHandler(this.customerListView_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(681, 34);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(61, 22);
            this.btnSearch.TabIndex = 48;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.ok_button_Click_1);
            // 
            // search_label
            // 
            this.search_label.AutoSize = true;
            this.search_label.Location = new System.Drawing.Point(401, 43);
            this.search_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.search_label.Name = "search_label";
            this.search_label.Size = new System.Drawing.Size(44, 13);
            this.search_label.TabIndex = 47;
            this.search_label.Text = "Search:";
            // 
            // search_textbox
            // 
            this.search_textbox.Location = new System.Drawing.Point(455, 36);
            this.search_textbox.Margin = new System.Windows.Forms.Padding(2);
            this.search_textbox.Multiline = true;
            this.search_textbox.Name = "search_textbox";
            this.search_textbox.Size = new System.Drawing.Size(213, 21);
            this.search_textbox.TabIndex = 46;
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(660, 317);
            this.delete_button.Margin = new System.Windows.Forms.Padding(2);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(67, 22);
            this.delete_button.TabIndex = 45;
            this.delete_button.Text = "Delete";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click_1);
            // 
            // update_button
            // 
            this.update_button.Location = new System.Drawing.Point(569, 317);
            this.update_button.Margin = new System.Windows.Forms.Padding(2);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(63, 22);
            this.update_button.TabIndex = 44;
            this.update_button.Text = "Update";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // insert_button
            // 
            this.insert_button.Location = new System.Drawing.Point(468, 317);
            this.insert_button.Margin = new System.Windows.Forms.Padding(2);
            this.insert_button.Name = "insert_button";
            this.insert_button.Size = new System.Drawing.Size(61, 22);
            this.insert_button.TabIndex = 43;
            this.insert_button.Text = "Insert";
            this.insert_button.UseVisualStyleBackColor = true;
            this.insert_button.Click += new System.EventHandler(this.insert_button_Click_1);
            // 
            // credit_label
            // 
            this.credit_label.AutoSize = true;
            this.credit_label.Location = new System.Drawing.Point(465, 248);
            this.credit_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.credit_label.Name = "credit_label";
            this.credit_label.Size = new System.Drawing.Size(34, 13);
            this.credit_label.TabIndex = 42;
            this.credit_label.Text = "Credit";
            // 
            // address_label
            // 
            this.address_label.AutoSize = true;
            this.address_label.Location = new System.Drawing.Point(465, 269);
            this.address_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.address_label.Name = "address_label";
            this.address_label.Size = new System.Drawing.Size(45, 13);
            this.address_label.TabIndex = 41;
            this.address_label.Text = "Address";
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Location = new System.Drawing.Point(465, 227);
            this.email_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(32, 13);
            this.email_label.TabIndex = 40;
            this.email_label.Text = "Email";
            // 
            // phone_label
            // 
            this.phone_label.AutoSize = true;
            this.phone_label.Location = new System.Drawing.Point(465, 207);
            this.phone_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.phone_label.Name = "phone_label";
            this.phone_label.Size = new System.Drawing.Size(38, 13);
            this.phone_label.TabIndex = 39;
            this.phone_label.Text = "Phone";
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(465, 186);
            this.name_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(35, 13);
            this.name_label.TabIndex = 38;
            this.name_label.Text = "Name";
            // 
            // customeID_label
            // 
            this.customeID_label.AutoSize = true;
            this.customeID_label.Location = new System.Drawing.Point(465, 165);
            this.customeID_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.customeID_label.Name = "customeID_label";
            this.customeID_label.Size = new System.Drawing.Size(65, 13);
            this.customeID_label.TabIndex = 37;
            this.customeID_label.Text = "Customer ID";
            // 
            // address_textBox
            // 
            this.address_textBox.Location = new System.Drawing.Point(569, 265);
            this.address_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.address_textBox.Name = "address_textBox";
            this.address_textBox.Size = new System.Drawing.Size(160, 20);
            this.address_textBox.TabIndex = 36;
            // 
            // credit_textBox
            // 
            this.credit_textBox.Location = new System.Drawing.Point(569, 244);
            this.credit_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.credit_textBox.Name = "credit_textBox";
            this.credit_textBox.Size = new System.Drawing.Size(160, 20);
            this.credit_textBox.TabIndex = 35;
            // 
            // email_textBox
            // 
            this.email_textBox.Location = new System.Drawing.Point(569, 224);
            this.email_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.email_textBox.Name = "email_textBox";
            this.email_textBox.Size = new System.Drawing.Size(160, 20);
            this.email_textBox.TabIndex = 34;
            // 
            // phone_textBox
            // 
            this.phone_textBox.Location = new System.Drawing.Point(569, 203);
            this.phone_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.phone_textBox.Name = "phone_textBox";
            this.phone_textBox.Size = new System.Drawing.Size(160, 20);
            this.phone_textBox.TabIndex = 33;
            // 
            // name_textBox
            // 
            this.name_textBox.Location = new System.Drawing.Point(569, 182);
            this.name_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(160, 20);
            this.name_textBox.TabIndex = 32;
            // 
            // customerID_textBox
            // 
            this.customerID_textBox.Location = new System.Drawing.Point(569, 161);
            this.customerID_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.customerID_textBox.Name = "customerID_textBox";
            this.customerID_textBox.Size = new System.Drawing.Size(160, 20);
            this.customerID_textBox.TabIndex = 31;
            // 
            // ID_textBox
            // 
            this.ID_textBox.Location = new System.Drawing.Point(569, 140);
            this.ID_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.ID_textBox.Name = "ID_textBox";
            this.ID_textBox.Size = new System.Drawing.Size(160, 20);
            this.ID_textBox.TabIndex = 30;
            // 
            // ID_label
            // 
            this.ID_label.AutoSize = true;
            this.ID_label.Location = new System.Drawing.Point(465, 144);
            this.ID_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ID_label.Name = "ID_label";
            this.ID_label.Size = new System.Drawing.Size(18, 13);
            this.ID_label.TabIndex = 29;
            this.ID_label.Text = "ID";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(62, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(9, 14);
            this.button2.TabIndex = 57;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(652, 359);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 58;
            this.btnNext.Text = "Proceed";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Visible = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnCredit
            // 
            this.btnCredit.Location = new System.Drawing.Point(469, 359);
            this.btnCredit.Name = "btnCredit";
            this.btnCredit.Size = new System.Drawing.Size(127, 23);
            this.btnCredit.TabIndex = 60;
            this.btnCredit.Text = "Update Credit";
            this.btnCredit.UseVisualStyleBackColor = true;
            this.btnCredit.Click += new System.EventHandler(this.btnCredit_Click);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 425);
            this.Controls.Add(this.btnCredit);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.customerListView);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.search_label);
            this.Controls.Add(this.search_textbox);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.insert_button);
            this.Controls.Add(this.credit_label);
            this.Controls.Add(this.address_label);
            this.Controls.Add(this.email_label);
            this.Controls.Add(this.phone_label);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.customeID_label);
            this.Controls.Add(this.address_textBox);
            this.Controls.Add(this.credit_textBox);
            this.Controls.Add(this.email_textBox);
            this.Controls.Add(this.phone_textBox);
            this.Controls.Add(this.name_textBox);
            this.Controls.Add(this.customerID_textBox);
            this.Controls.Add(this.ID_textBox);
            this.Controls.Add(this.ID_label);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.Activated += new System.EventHandler(this.CustomerForm_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CustomerForm_FormClosed);
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView customerListView;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label search_label;
        private System.Windows.Forms.TextBox search_textbox;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Button insert_button;
        private System.Windows.Forms.Label credit_label;
        private System.Windows.Forms.Label address_label;
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.Label phone_label;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label customeID_label;
        private System.Windows.Forms.TextBox address_textBox;
        private System.Windows.Forms.TextBox credit_textBox;
        private System.Windows.Forms.TextBox email_textBox;
        private System.Windows.Forms.TextBox phone_textBox;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.TextBox customerID_textBox;
        private System.Windows.Forms.TextBox ID_textBox;
        private System.Windows.Forms.Label ID_label;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnCredit;
    }
}