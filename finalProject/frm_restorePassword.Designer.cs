namespace groupAssignment
{
    partial class frm_restorePassword
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
            this.lbl_text = new System.Windows.Forms.Label();
            this.txt_loginPass = new System.Windows.Forms.TextBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lbl_errors = new System.Windows.Forms.Label();
            this.grpbx_top = new System.Windows.Forms.GroupBox();
            this.grpbx_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_text
            // 
            this.lbl_text.AutoSize = true;
            this.lbl_text.Location = new System.Drawing.Point(6, 27);
            this.lbl_text.Name = "lbl_text";
            this.lbl_text.Size = new System.Drawing.Size(221, 26);
            this.lbl_text.TabIndex = 0;
            this.lbl_text.Text = "&Enter your username:";
            // 
            // txt_loginPass
            // 
            this.txt_loginPass.Location = new System.Drawing.Point(248, 22);
            this.txt_loginPass.Name = "txt_loginPass";
            this.txt_loginPass.Size = new System.Drawing.Size(284, 31);
            this.txt_loginPass.TabIndex = 1;
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(248, 61);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(137, 38);
            this.btn_submit.TabIndex = 2;
            this.btn_submit.Text = "&Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(403, 61);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(129, 38);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "&Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // lbl_errors
            // 
            this.lbl_errors.AutoSize = true;
            this.lbl_errors.ForeColor = System.Drawing.Color.Red;
            this.lbl_errors.Location = new System.Drawing.Point(35, 162);
            this.lbl_errors.Name = "lbl_errors";
            this.lbl_errors.Size = new System.Drawing.Size(0, 26);
            this.lbl_errors.TabIndex = 4;
            // 
            // grpbx_top
            // 
            this.grpbx_top.Controls.Add(this.btn_cancel);
            this.grpbx_top.Controls.Add(this.btn_submit);
            this.grpbx_top.Controls.Add(this.txt_loginPass);
            this.grpbx_top.Controls.Add(this.lbl_text);
            this.grpbx_top.Location = new System.Drawing.Point(12, 21);
            this.grpbx_top.Name = "grpbx_top";
            this.grpbx_top.Size = new System.Drawing.Size(553, 126);
            this.grpbx_top.TabIndex = 5;
            this.grpbx_top.TabStop = false;
            // 
            // frm_restorePassword
            // 
            this.AcceptButton = this.btn_submit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(605, 220);
            this.Controls.Add(this.grpbx_top);
            this.Controls.Add(this.lbl_errors);
            this.Name = "frm_restorePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restore Password";
            this.grpbx_top.ResumeLayout(false);
            this.grpbx_top.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_text;
        private System.Windows.Forms.TextBox txt_loginPass;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label lbl_errors;
        private System.Windows.Forms.GroupBox grpbx_top;
    }
}