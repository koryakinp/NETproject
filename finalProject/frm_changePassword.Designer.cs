namespace groupAssignment
{
    partial class frm_changePassword
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
            this.lbl_curpwd = new System.Windows.Forms.Label();
            this.lbl_newpwd = new System.Windows.Forms.Label();
            this.lbl_confirmpwd = new System.Windows.Forms.Label();
            this.txt_curpwd = new System.Windows.Forms.TextBox();
            this.txt_newpwd = new System.Windows.Forms.TextBox();
            this.txt_confirmpwd = new System.Windows.Forms.TextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_submit = new System.Windows.Forms.Button();
            this.grppx_main = new System.Windows.Forms.GroupBox();
            this.lbl_errors = new System.Windows.Forms.Label();
            this.grppx_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_curpwd
            // 
            this.lbl_curpwd.AutoSize = true;
            this.lbl_curpwd.Location = new System.Drawing.Point(17, 26);
            this.lbl_curpwd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_curpwd.Name = "lbl_curpwd";
            this.lbl_curpwd.Size = new System.Drawing.Size(135, 20);
            this.lbl_curpwd.TabIndex = 0;
            this.lbl_curpwd.Text = "&Current Password";
            // 
            // lbl_newpwd
            // 
            this.lbl_newpwd.AutoSize = true;
            this.lbl_newpwd.Location = new System.Drawing.Point(17, 59);
            this.lbl_newpwd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_newpwd.Name = "lbl_newpwd";
            this.lbl_newpwd.Size = new System.Drawing.Size(117, 20);
            this.lbl_newpwd.TabIndex = 1;
            this.lbl_newpwd.Text = "&New Password:";
            // 
            // lbl_confirmpwd
            // 
            this.lbl_confirmpwd.AutoSize = true;
            this.lbl_confirmpwd.Location = new System.Drawing.Point(17, 92);
            this.lbl_confirmpwd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_confirmpwd.Name = "lbl_confirmpwd";
            this.lbl_confirmpwd.Size = new System.Drawing.Size(176, 20);
            this.lbl_confirmpwd.TabIndex = 2;
            this.lbl_confirmpwd.Text = "C&onfirm New Password:";
            // 
            // txt_curpwd
            // 
            this.txt_curpwd.Location = new System.Drawing.Point(204, 24);
            this.txt_curpwd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_curpwd.Name = "txt_curpwd";
            this.txt_curpwd.PasswordChar = '*';
            this.txt_curpwd.Size = new System.Drawing.Size(113, 26);
            this.txt_curpwd.TabIndex = 3;
            // 
            // txt_newpwd
            // 
            this.txt_newpwd.Location = new System.Drawing.Point(204, 57);
            this.txt_newpwd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_newpwd.Name = "txt_newpwd";
            this.txt_newpwd.PasswordChar = '*';
            this.txt_newpwd.Size = new System.Drawing.Size(113, 26);
            this.txt_newpwd.TabIndex = 4;
            // 
            // txt_confirmpwd
            // 
            this.txt_confirmpwd.Location = new System.Drawing.Point(204, 90);
            this.txt_confirmpwd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_confirmpwd.Name = "txt_confirmpwd";
            this.txt_confirmpwd.PasswordChar = '*';
            this.txt_confirmpwd.Size = new System.Drawing.Size(113, 26);
            this.txt_confirmpwd.TabIndex = 5;
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(70, 164);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(95, 38);
            this.btn_cancel.TabIndex = 6;
            this.btn_cancel.Text = "&Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(188, 164);
            this.btn_submit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(87, 38);
            this.btn_submit.TabIndex = 7;
            this.btn_submit.Text = "&OK";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // grppx_main
            // 
            this.grppx_main.Controls.Add(this.txt_confirmpwd);
            this.grppx_main.Controls.Add(this.txt_newpwd);
            this.grppx_main.Controls.Add(this.txt_curpwd);
            this.grppx_main.Controls.Add(this.lbl_confirmpwd);
            this.grppx_main.Controls.Add(this.lbl_newpwd);
            this.grppx_main.Controls.Add(this.lbl_curpwd);
            this.grppx_main.Location = new System.Drawing.Point(9, 18);
            this.grppx_main.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grppx_main.Name = "grppx_main";
            this.grppx_main.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grppx_main.Size = new System.Drawing.Size(320, 142);
            this.grppx_main.TabIndex = 8;
            this.grppx_main.TabStop = false;
            // 
            // lbl_errors
            // 
            this.lbl_errors.AutoSize = true;
            this.lbl_errors.ForeColor = System.Drawing.Color.Red;
            this.lbl_errors.Location = new System.Drawing.Point(334, 43);
            this.lbl_errors.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_errors.Name = "lbl_errors";
            this.lbl_errors.Size = new System.Drawing.Size(0, 20);
            this.lbl_errors.TabIndex = 9;
            // 
            // frm_changePassword
            // 
            this.AcceptButton = this.btn_submit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(620, 228);
            this.Controls.Add(this.lbl_errors);
            this.Controls.Add(this.grppx_main);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.btn_cancel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frm_changePassword";
            this.Text = "Change Password";
            this.grppx_main.ResumeLayout(false);
            this.grppx_main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_curpwd;
        private System.Windows.Forms.Label lbl_newpwd;
        private System.Windows.Forms.Label lbl_confirmpwd;
        private System.Windows.Forms.TextBox txt_curpwd;
        private System.Windows.Forms.TextBox txt_newpwd;
        private System.Windows.Forms.TextBox txt_confirmpwd;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.GroupBox grppx_main;
        private System.Windows.Forms.Label lbl_errors;
    }
}