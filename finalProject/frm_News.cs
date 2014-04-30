using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace groupAssignment
{
    public partial class frm_News : Form
    {
        public frm_News()
        {
            InitializeComponent();
        }

        private void News_Load(object sender, EventArgs e)
        {
            this.Name = "News";
            DataGridViewRow selectedRow = (DataGridViewRow)this.Tag;
            grpbx_news.Text = selectedRow.Cells[0].Value.ToString();
            lbl_newsTitle.Text = selectedRow.Cells[1].Value.ToString();
            lbl_newsBody.Text = selectedRow.Cells[2].Value.ToString();
            this.Text = selectedRow.Cells[1].Value.ToString();
            lbl_newsTitle.MaximumSize = new Size(300, 0);
            lbl_newsTitle.AutoSize = true;

            lbl_newsBody.MaximumSize = new Size(300, 0);
            lbl_newsBody.AutoSize = true;
        }
    }
}
