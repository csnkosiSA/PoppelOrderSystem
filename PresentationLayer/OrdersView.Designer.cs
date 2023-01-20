namespace PoppelOrderSystem.PresentationLayer
{
    partial class OrdersView
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
            this.orderListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // orderListView
            // 
            this.orderListView.HideSelection = false;
            this.orderListView.Location = new System.Drawing.Point(25, 58);
            this.orderListView.Name = "orderListView";
            this.orderListView.Size = new System.Drawing.Size(677, 229);
            this.orderListView.TabIndex = 0;
            this.orderListView.UseCompatibleStateImageBehavior = false;
            // 
            // OrdersView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.orderListView);
            this.Name = "OrdersView";
            this.Text = "OrdersView";
            this.Activated += new System.EventHandler(this.OrdersView_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OrdersView_FormClosed);
            this.Load += new System.EventHandler(this.OrdersView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView orderListView;
    }
}