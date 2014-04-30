namespace groupAssignment
{
    partial class frmLoginForm
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
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.grpbx_top = new System.Windows.Forms.GroupBox();
            this.llbl_register = new System.Windows.Forms.LinkLabel();
            this.lbl_register = new System.Windows.Forms.Label();
            this.lbl_forgotpassword = new System.Windows.Forms.Label();
            this.llbl_forgotpassword = new System.Windows.Forms.LinkLabel();
            this.grpbx_bottom = new System.Windows.Forms.GroupBox();
            this.lbl_errors = new System.Windows.Forms.Label();
            this.grpbx_top.SuspendLayout();
            this.grpbx_bottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Palatino Linotype", 12.06283F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(6, 9);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(182, 45);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Palatino Linotype", 12.06283F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(16, 57);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(172, 45);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(193, 23);
            this.txtName.Margin = new System.Windows.Forms.Padding(6);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(154, 31);
            this.txtName.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(193, 68);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(6);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(154, 31);
            this.txtPassword.TabIndex = 3;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(241, 111);
            this.btnExit.Margin = new System.Windows.Forms.Padding(6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(106, 40);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "&Cancel";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(111, 111);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(6);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(118, 40);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "&LogIn";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // grpbx_top
            // 
            this.grpbx_top.BackColor = System.Drawing.Color.Transparent;
            this.grpbx_top.Controls.Add(this.btnLogin);
            this.grpbx_top.Controls.Add(this.btnExit);
            this.grpbx_top.Controls.Add(this.txtPassword);
            this.grpbx_top.Controls.Add(this.txtName);
            this.grpbx_top.Controls.Add(this.lblPassword);
            this.grpbx_top.Controls.Add(this.lblUsername);
            this.grpbx_top.Location = new System.Drawing.Point(22, 12);
            this.grpbx_top.Name = "grpbx_top";
            this.grpbx_top.Size = new System.Drawing.Size(373, 176);
            this.grpbx_top.TabIndex = 6;
            this.grpbx_top.TabStop = false;
            // 
            // llbl_register
            // 
            this.llbl_register.AutoSize = true;
            this.llbl_register.Location = new System.Drawing.Point(254, 26);
            this.llbl_register.Name = "llbl_register";
            this.llbl_register.Size = new System.Drawing.Size(93, 26);
            this.llbl_register.TabIndex = 7;
            this.llbl_register.TabStop = true;
            this.llbl_register.Text = "Register";
            this.llbl_register.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lbl_register
            // 
            this.lbl_register.AutoSize = true;
            this.lbl_register.Location = new System.Drawing.Point(9, 26);
            this.lbl_register.Name = "lbl_register";
            this.lbl_register.Size = new System.Drawing.Size(229, 26);
            this.lbl_register.TabIndex = 8;
            this.lbl_register.Text = "Do not have account ?";
            // 
            // lbl_forgotpassword
            // 
            this.lbl_forgotpassword.AutoSize = true;
            this.lbl_forgotpassword.Location = new System.Drawing.Point(9, 52);
            this.lbl_forgotpassword.Name = "lbl_forgotpassword";
            this.lbl_forgotpassword.Size = new System.Drawing.Size(239, 26);
            this.lbl_forgotpassword.TabIndex = 9;
            this.lbl_forgotpassword.Text = "Forgot your password ?";
            // 
            // llbl_forgotpassword
            // 
            this.llbl_forgotpassword.AutoSize = true;
            this.llbl_forgotpassword.Location = new System.Drawing.Point(254, 52);
            this.llbl_forgotpassword.Name = "llbl_forgotpassword";
            this.llbl_forgotpassword.Size = new System.Drawing.Size(109, 26);
            this.llbl_forgotpassword.TabIndex = 10;
            this.llbl_forgotpassword.TabStop = true;
            this.llbl_forgotpassword.Text = "Click here";
            this.llbl_forgotpassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbl_forgotpassword_LinkClicked);
            // 
            // grpbx_bottom
            // 
            this.grpbx_bottom.Controls.Add(this.llbl_forgotpassword);
            this.grpbx_bottom.Controls.Add(this.lbl_forgotpassword);
            this.grpbx_bottom.Controls.Add(this.lbl_register);
            this.grpbx_bottom.Controls.Add(this.llbl_register);
            this.grpbx_bottom.Location = new System.Drawing.Point(22, 194);
            this.grpbx_bottom.Name = "grpbx_bottom";
            this.grpbx_bottom.Size = new System.Drawing.Size(373, 90);
            this.grpbx_bottom.TabIndex = 11;
            this.grpbx_bottom.TabStop = false;
            // 
            // lbl_errors
            // 
            this.lbl_errors.AutoSize = true;
            this.lbl_errors.ForeColor = System.Drawing.Color.Red;
            this.lbl_errors.Location = new System.Drawing.Point(22, 303);
            this.lbl_errors.Name = "lbl_errors";
            this.lbl_errors.Size = new System.Drawing.Size(0, 26);
            this.lbl_errors.TabIndex = 12;
            // 
            // frmLoginForm
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(421, 405);
            this.Controls.Add(this.lbl_errors);
            this.Controls.Add(this.grpbx_bottom);
            this.Controls.Add(this.grpbx_top);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmLoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogIn";
            this.grpbx_top.ResumeLayout(false);
            this.grpbx_top.PerformLayout();
            this.grpbx_bottom.ResumeLayout(false);
            this.grpbx_bottom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.GroupBox grpbx_top;
        private System.Windows.Forms.LinkLabel llbl_register;
        private System.Windows.Forms.Label lbl_register;
        private System.Windows.Forms.Label lbl_forgotpassword;
        private System.Windows.Forms.LinkLabel llbl_forgotpassword;
        private System.Windows.Forms.GroupBox grpbx_bottom;
        private System.Windows.Forms.Label lbl_errors;
    }
}