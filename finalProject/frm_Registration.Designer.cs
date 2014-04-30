namespace groupAssignment
{
    partial class frm_Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Registration));
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_login = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_login = new System.Windows.Forms.TextBox();
            this.btn_register = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.grpbx_top = new System.Windows.Forms.GroupBox();
            this.lbl_errors = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.chkbx_license = new System.Windows.Forms.CheckBox();
            this.grpbx_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(40, 26);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(55, 20);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "&Name:";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(37, 59);
            this.lbl_email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(57, 20);
            this.lbl_email.TabIndex = 1;
            this.lbl_email.Text = "&E-mail:";
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Location = new System.Drawing.Point(8, 90);
            this.lbl_login.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(87, 20);
            this.lbl_login.TabIndex = 2;
            this.lbl_login.Text = "&Username:";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(102, 22);
            this.txt_name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(124, 26);
            this.txt_name.TabIndex = 5;
            // 
            // txt_login
            // 
            this.txt_login.Location = new System.Drawing.Point(102, 88);
            this.txt_login.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_login.Name = "txt_login";
            this.txt_login.Size = new System.Drawing.Size(124, 26);
            this.txt_login.TabIndex = 7;
            // 
            // btn_register
            // 
            this.btn_register.Location = new System.Drawing.Point(21, 388);
            this.btn_register.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(91, 33);
            this.btn_register.TabIndex = 1;
            this.btn_register.Text = "&Register";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(116, 388);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(78, 33);
            this.btn_cancel.TabIndex = 2;
            this.btn_cancel.Text = "&Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(102, 55);
            this.txt_email.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(124, 26);
            this.txt_email.TabIndex = 6;
            // 
            // grpbx_top
            // 
            this.grpbx_top.Controls.Add(this.txt_email);
            this.grpbx_top.Controls.Add(this.txt_login);
            this.grpbx_top.Controls.Add(this.txt_name);
            this.grpbx_top.Controls.Add(this.lbl_login);
            this.grpbx_top.Controls.Add(this.lbl_email);
            this.grpbx_top.Controls.Add(this.lbl_name);
            this.grpbx_top.Location = new System.Drawing.Point(9, 12);
            this.grpbx_top.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpbx_top.Name = "grpbx_top";
            this.grpbx_top.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpbx_top.Size = new System.Drawing.Size(259, 127);
            this.grpbx_top.TabIndex = 0;
            this.grpbx_top.TabStop = false;
            // 
            // lbl_errors
            // 
            this.lbl_errors.AutoSize = true;
            this.lbl_errors.ForeColor = System.Drawing.Color.Red;
            this.lbl_errors.Location = new System.Drawing.Point(284, 34);
            this.lbl_errors.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_errors.Name = "lbl_errors";
            this.lbl_errors.Size = new System.Drawing.Size(0, 20);
            this.lbl_errors.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(10, 144);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(674, 211);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // chkbx_license
            // 
            this.chkbx_license.AutoSize = true;
            this.chkbx_license.Location = new System.Drawing.Point(21, 359);
            this.chkbx_license.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkbx_license.Name = "chkbx_license";
            this.chkbx_license.Size = new System.Drawing.Size(261, 24);
            this.chkbx_license.TabIndex = 3;
            this.chkbx_license.Text = "I &accept the License Agreement";
            this.chkbx_license.UseVisualStyleBackColor = true;
            // 
            // frm_Registration
            // 
            this.AcceptButton = this.btn_register;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(692, 430);
            this.Controls.Add(this.chkbx_license);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lbl_errors);
            this.Controls.Add(this.grpbx_top);
            this.Controls.Add(this.btn_register);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frm_Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.grpbx_top.ResumeLayout(false);
            this.grpbx_top.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_login;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.GroupBox grpbx_top;
        private System.Windows.Forms.Label lbl_errors;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.CheckBox chkbx_license;
    }
}