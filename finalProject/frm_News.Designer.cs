namespace groupAssignment
{
    partial class frm_News
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_News));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_newsTitle = new System.Windows.Forms.Label();
            this.lbl_newsBody = new System.Windows.Forms.Label();
            this.grpbx_news = new System.Windows.Forms.GroupBox();
            this.grpbx_news.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_newsTitle
            // 
            this.lbl_newsTitle.AutoSize = true;
            this.lbl_newsTitle.Location = new System.Drawing.Point(23, 42);
            this.lbl_newsTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_newsTitle.Name = "lbl_newsTitle";
            this.lbl_newsTitle.Size = new System.Drawing.Size(70, 26);
            this.lbl_newsTitle.TabIndex = 0;
            this.lbl_newsTitle.Text = "label1";
            // 
            // lbl_newsBody
            // 
            this.lbl_newsBody.AutoEllipsis = true;
            this.lbl_newsBody.AutoSize = true;
            this.lbl_newsBody.Location = new System.Drawing.Point(23, 116);
            this.lbl_newsBody.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_newsBody.Name = "lbl_newsBody";
            this.lbl_newsBody.Size = new System.Drawing.Size(70, 26);
            this.lbl_newsBody.TabIndex = 1;
            this.lbl_newsBody.Text = "label2";
            // 
            // grpbx_news
            // 
            this.grpbx_news.Controls.Add(this.lbl_newsBody);
            this.grpbx_news.Controls.Add(this.lbl_newsTitle);
            this.grpbx_news.Location = new System.Drawing.Point(24, 22);
            this.grpbx_news.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpbx_news.Name = "grpbx_news";
            this.grpbx_news.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpbx_news.Size = new System.Drawing.Size(817, 470);
            this.grpbx_news.TabIndex = 2;
            this.grpbx_news.TabStop = false;
            this.grpbx_news.Text = " ";
            // 
            // frm_News
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(864, 512);
            this.Controls.Add(this.grpbx_news);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_News";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "News";
            this.Load += new System.EventHandler(this.News_Load);
            this.grpbx_news.ResumeLayout(false);
            this.grpbx_news.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_newsTitle;
        private System.Windows.Forms.Label lbl_newsBody;
        private System.Windows.Forms.GroupBox grpbx_news;
    }
}