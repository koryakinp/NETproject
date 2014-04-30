using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.ServiceModel.Syndication;
using System.Text.RegularExpressions;

namespace groupAssignment
{
    public partial class frm_LiveNews : Form
    {
        public frm_LiveNews()
        {
            InitializeComponent();
        }

        private void LiveNews_Load(object sender, EventArgs e)
        {
            this.Name = "frm_LiveNews";
            XmlReader reader = new XmlTextReader("http://feeds.reuters.com/reuters/companyNews?format=xml");
            SyndicationFeed feed = SyndicationFeed.Load(reader);

            foreach (SyndicationItem item in feed.Items)
            {
                String titel = item.Title.Text;
                String news = Regex.Replace(item.Summary.Text, "<.+?>", string.Empty);
                //item.PublishDate.ToLocalTime();
                dataGridView1.Rows.Add(item.PublishDate.DateTime.ToLocalTime().ToLongTimeString(), titel, news);
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var dataGridView = sender as DataGridView;
            if (dataGridView.Rows[e.RowIndex].Selected)
            {
                e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
                // edit: to change the background color:
                e.CellStyle.SelectionBackColor = Color.Coral;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];

            string a = Convert.ToString(selectedRow.Cells[1].Value);

            foreach (Form form in Application.OpenForms)
                if (form.Name == "News")
                {
                    form.Close();
                    break;
                }

            frm_News newMDIchild = new frm_News();
            newMDIchild.MdiParent = this.MdiParent;
            newMDIchild.Tag = selectedRow;
            newMDIchild.Show();
        }

        private void frm_LiveNews_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm_mainForm frm = (frm_mainForm)Application.OpenForms["frm_mainForm"];
            frm.enbaleNews();
        }
    }
}
