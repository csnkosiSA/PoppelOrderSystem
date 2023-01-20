namespace PoppelOrderSystem
{
    partial class Login
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
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblForgotP = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.lblInvalid = new System.Windows.Forms.Label();
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblViewP = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(27, 116);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(160, 22);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email/Employee ID";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(27, 165);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(89, 22);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password";
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEmail.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtBoxEmail.Location = new System.Drawing.Point(207, 111);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(211, 27);
            this.txtBoxEmail.TabIndex = 2;
            this.txtBoxEmail.Enter += new System.EventHandler(this.txtBoxEmail_Enter);
            this.txtBoxEmail.Leave += new System.EventHandler(this.txtBoxEmail_Leave);
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPassword.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtBoxPassword.Location = new System.Drawing.Point(207, 165);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.Size = new System.Drawing.Size(211, 27);
            this.txtBoxPassword.TabIndex = 3;
            this.txtBoxPassword.UseSystemPasswordChar = true;
            this.txtBoxPassword.Enter += new System.EventHandler(this.txtBoxPassword_Enter);
            this.txtBoxPassword.Leave += new System.EventHandler(this.txtBoxPassword_Leave);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(239, 232);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(134, 43);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Sign in";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(213, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 31);
            this.label1.TabIndex = 5;
            // 
            // lblForgotP
            // 
            this.lblForgotP.AutoSize = true;
            this.lblForgotP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForgotP.Location = new System.Drawing.Point(246, 195);
            this.lblForgotP.Name = "lblForgotP";
            this.lblForgotP.Size = new System.Drawing.Size(142, 17);
            this.lblForgotP.TabIndex = 6;
            this.lblForgotP.Text = "Forgotten Password?";
            this.lblForgotP.Click += new System.EventHandler(this.lblForgotP_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(293, 141);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 7;
            // 
            // lblInvalid
            // 
            this.lblInvalid.AutoSize = true;
            this.lblInvalid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvalid.ForeColor = System.Drawing.Color.Red;
            this.lblInvalid.Location = new System.Drawing.Point(204, 145);
            this.lblInvalid.Name = "lblInvalid";
            this.lblInvalid.Size = new System.Drawing.Size(46, 17);
            this.lblInvalid.TabIndex = 8;
            this.lblInvalid.Text = "label2";
            this.lblInvalid.Visible = false;
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(214, 65);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(185, 25);
            this.lblHeading.TabIndex = 9;
            this.lblHeading.Text = "Sign in to start order";
            // 
            // lblViewP
            // 
            this.lblViewP.AutoSize = true;
            this.lblViewP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewP.Location = new System.Drawing.Point(433, 173);
            this.lblViewP.Name = "lblViewP";
            this.lblViewP.Size = new System.Drawing.Size(78, 13);
            this.lblViewP.TabIndex = 10;
            this.lblViewP.Text = "View password";
            this.lblViewP.Click += new System.EventHandler(this.lblViewP_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblViewP);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.lblInvalid);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblForgotP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtBoxPassword);
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblEmail);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblForgotP;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblInvalid;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblViewP;
    }
}

