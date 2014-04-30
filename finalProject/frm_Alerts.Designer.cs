namespace groupAssignment
{
    partial class frm_Alerts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Alerts));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.symbols = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.targetPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbx_table = new System.Windows.Forms.GroupBox();
            this.btn_addalert = new System.Windows.Forms.Button();
            this.cmbbx_symbol = new System.Windows.Forms.ComboBox();
            this.txt_targetPrice = new System.Windows.Forms.TextBox();
            this.lbl_symbol = new System.Windows.Forms.Label();
            this.lbl_targetPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpbx_table.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.symbols,
            this.lastPrice,
            this.targetPrice});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(4, 28);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(836, 305);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // symbols
            // 
            this.symbols.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.symbols.HeaderText = "Symbols";
            this.symbols.Name = "symbols";
            this.symbols.ReadOnly = true;
            // 
            // lastPrice
            // 
            this.lastPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lastPrice.HeaderText = "Last price";
            this.lastPrice.Name = "lastPrice";
            this.lastPrice.ReadOnly = true;
            // 
            // targetPrice
            // 
            this.targetPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.targetPrice.HeaderText = "Target Price";
            this.targetPrice.Name = "targetPrice";
            this.targetPrice.ReadOnly = true;
            // 
            // grpbx_table
            // 
            this.grpbx_table.Controls.Add(this.dataGridView1);
            this.grpbx_table.Location = new System.Drawing.Point(28, 25);
            this.grpbx_table.Margin = new System.Windows.Forms.Padding(4);
            this.grpbx_table.Name = "grpbx_table";
            this.grpbx_table.Padding = new System.Windows.Forms.Padding(4);
            this.grpbx_table.Size = new System.Drawing.Size(844, 337);
            this.grpbx_table.TabIndex = 1;
            this.grpbx_table.TabStop = false;
            // 
            // btn_addalert
            // 
            this.btn_addalert.Location = new System.Drawing.Point(28, 381);
            this.btn_addalert.Margin = new System.Windows.Forms.Padding(4);
            this.btn_addalert.Name = "btn_addalert";
            this.btn_addalert.Size = new System.Drawing.Size(132, 46);
            this.btn_addalert.TabIndex = 2;
            this.btn_addalert.Text = "&Add alert";
            this.btn_addalert.UseVisualStyleBackColor = true;
            this.btn_addalert.Click += new System.EventHandler(this.btn_addalert_Click);
            // 
            // cmbbx_symbol
            // 
            this.cmbbx_symbol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbx_symbol.Location = new System.Drawing.Point(298, 392);
            this.cmbbx_symbol.Margin = new System.Windows.Forms.Padding(4);
            this.cmbbx_symbol.Name = "cmbbx_symbol";
            this.cmbbx_symbol.Size = new System.Drawing.Size(144, 33);
            this.cmbbx_symbol.TabIndex = 4;
            this.cmbbx_symbol.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmbbx_symbol_MouseClick);
            // 
            // txt_targetPrice
            // 
            this.txt_targetPrice.AcceptsReturn = true;
            this.txt_targetPrice.Location = new System.Drawing.Point(616, 396);
            this.txt_targetPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txt_targetPrice.Name = "txt_targetPrice";
            this.txt_targetPrice.Size = new System.Drawing.Size(182, 31);
            this.txt_targetPrice.TabIndex = 5;
            // 
            // lbl_symbol
            // 
            this.lbl_symbol.AutoSize = true;
            this.lbl_symbol.Location = new System.Drawing.Point(200, 400);
            this.lbl_symbol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_symbol.Name = "lbl_symbol";
            this.lbl_symbol.Size = new System.Drawing.Size(92, 26);
            this.lbl_symbol.TabIndex = 6;
            this.lbl_symbol.Text = "&Symbol:";
            // 
            // lbl_targetPrice
            // 
            this.lbl_targetPrice.AutoSize = true;
            this.lbl_targetPrice.Location = new System.Drawing.Point(476, 400);
            this.lbl_targetPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_targetPrice.Name = "lbl_targetPrice";
            this.lbl_targetPrice.Size = new System.Drawing.Size(135, 26);
            this.lbl_targetPrice.TabIndex = 7;
            this.lbl_targetPrice.Text = "&Target Price:";
            // 
            // frm_Alerts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 523);
            this.Controls.Add(this.lbl_targetPrice);
            this.Controls.Add(this.lbl_symbol);
            this.Controls.Add(this.txt_targetPrice);
            this.Controls.Add(this.cmbbx_symbol);
            this.Controls.Add(this.btn_addalert);
            this.Controls.Add(this.grpbx_table);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_Alerts";
            this.Text = "Alerts";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_Alerts_FormClosed);
            this.Load += new System.EventHandler(this.Alerts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpbx_table.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox grpbx_table;
        private System.Windows.Forms.Button btn_addalert;
        private System.Windows.Forms.ComboBox cmbbx_symbol;
        private System.Windows.Forms.TextBox txt_targetPrice;
        private System.Windows.Forms.Label lbl_symbol;
        private System.Windows.Forms.Label lbl_targetPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn symbols;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn targetPrice;
    }
}