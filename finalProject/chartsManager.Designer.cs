namespace groupAssignment
{
    partial class frm_chartManager
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
            this.cmbbx_importedCharts = new System.Windows.Forms.ComboBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_import = new System.Windows.Forms.Button();
            this.grpbx_main = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_path = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.grpbx_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbbx_importedCharts
            // 
            this.cmbbx_importedCharts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbx_importedCharts.FormattingEnabled = true;
            this.cmbbx_importedCharts.Location = new System.Drawing.Point(106, 91);
            this.cmbbx_importedCharts.Name = "cmbbx_importedCharts";
            this.cmbbx_importedCharts.Size = new System.Drawing.Size(363, 33);
            this.cmbbx_importedCharts.TabIndex = 0;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(487, 88);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(122, 37);
            this.btn_delete.TabIndex = 1;
            this.btn_delete.Text = "&Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(195, 179);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(139, 47);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "&Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // btn_import
            // 
            this.btn_import.Location = new System.Drawing.Point(487, 32);
            this.btn_import.Name = "btn_import";
            this.btn_import.Size = new System.Drawing.Size(122, 38);
            this.btn_import.TabIndex = 6;
            this.btn_import.Text = "Browse ...";
            this.btn_import.UseVisualStyleBackColor = true;
            this.btn_import.Click += new System.EventHandler(this.btn_import_Click);
            // 
            // grpbx_main
            // 
            this.grpbx_main.Controls.Add(this.label2);
            this.grpbx_main.Controls.Add(this.txt_path);
            this.grpbx_main.Controls.Add(this.label1);
            this.grpbx_main.Controls.Add(this.btn_delete);
            this.grpbx_main.Controls.Add(this.btn_import);
            this.grpbx_main.Controls.Add(this.cmbbx_importedCharts);
            this.grpbx_main.Location = new System.Drawing.Point(25, 12);
            this.grpbx_main.Name = "grpbx_main";
            this.grpbx_main.Size = new System.Drawing.Size(645, 151);
            this.grpbx_main.TabIndex = 7;
            this.grpbx_main.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "&Import:";
            // 
            // txt_path
            // 
            this.txt_path.Location = new System.Drawing.Point(106, 36);
            this.txt_path.Name = "txt_path";
            this.txt_path.Size = new System.Drawing.Size(363, 31);
            this.txt_path.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 26);
            this.label2.TabIndex = 10;
            this.label2.Text = "&Delete:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(355, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 47);
            this.button1.TabIndex = 8;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Enabled = false;
            this.progressBar1.Location = new System.Drawing.Point(25, 248);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(645, 23);
            this.progressBar1.TabIndex = 9;
            // 
            // frm_chartManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(695, 307);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grpbx_main);
            this.Controls.Add(this.btn_cancel);
            this.Name = "frm_chartManager";
            this.Text = "Imported Charts Manager";
            this.Load += new System.EventHandler(this.chartsManager_Load);
            this.grpbx_main.ResumeLayout(false);
            this.grpbx_main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbbx_importedCharts;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_import;
        private System.Windows.Forms.GroupBox grpbx_main;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_path;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}