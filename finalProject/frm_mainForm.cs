using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;


namespace groupAssignment
{
    public partial class frm_mainForm : Form
    {
        public bool isConnected;

        public frm_mainForm()
        {
            timer1 = new Timer();
            timer1.Interval = 10000;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Enabled = true;
            timer1.Start();
            InitializeComponent();
        }
        
        public void BuildMenuItems()
        {
            chartsToolStripMenuItem.DropDownItems.Clear();
            ArrayList ChartList = DataBase.getUsersChartList(User.curUsername);
            foreach (String symbol in ChartList)
            {
                ToolStripMenuItem item = new ToolStripMenuItem();
                item.Name = symbol;
                item.Text = symbol;
                item.Click += new EventHandler(MenuItemClickHandler);
                chartsToolStripMenuItem.DropDownItems.Add(item);
            }
        }

        private void MenuItemClickHandler(object sender, EventArgs e)
        {
            ChartControl chartControl = new ChartControl();
            ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;
            chartControl.Symbol = clickedItem.Text;
            frm_chart newMDIchild = new frm_chart(chartControl);
            newMDIchild.MdiParent = this;
            newMDIchild.Show();
        }

        private void MenuItemChartManagerClickHandler(object sender, EventArgs e)
        {
            frm_chartManager newMDIchild = new frm_chartManager();
            newMDIchild.MdiParent = this;
            newMDIchild.Show();
        }


        private static Hashtable quotes = new Hashtable();

        public static Hashtable Quotes
        {
            get { return frm_mainForm.quotes; }
            set { frm_mainForm.quotes = value; }
        }


        private void frm_mainForm_Load(object sender, EventArgs e)
        {

            BuildMenuItems();
            this.Text = User.curName + ", " + User.curUsername;

            toolStripStatusLabel_date.Text = DateTime.Now.ToLongDateString();
            toolStripStatusLabel_connection.Text = "Not connected";
            toolStripStatusLabel_connection.Image = Properties.Resources.conLOST;
            isConnected = false;


            ArrayList quoteList = DataBase.getUsersQuoteList(User.curUsername);
            foreach (String quote in quoteList)
            {
                Quotes.Add(quote, new Candle());
            }

            frm_LiveQuotes newMDIchild = new frm_LiveQuotes();
            newMDIchild.MdiParent = this;
            newMDIchild.Show();

            frm_LiveNews newMDIchild2 = new frm_LiveNews();
            newMDIchild2.MdiParent = this;
            newMDIchild2.Show();

            frm_Alerts newMDIchild3 = new frm_Alerts();
            newMDIchild3.MdiParent = this;
            newMDIchild3.Show();

            alertsToolStripMenuItem.Enabled = false;
            liveQuotesToolStripMenuItem.Enabled = false;
            newsToolStripMenuItem.Enabled = false;

            ArrayList DefaultChartList = DataBase.getDefaultChartList();

            foreach (String symbol in DefaultChartList)
            {
                ChartControl chartControl = new ChartControl();
                chartControl.Symbol = symbol;
                frm_chart newMDIchild4 = new frm_chart(chartControl);
                newMDIchild4.MdiParent = this;
                newMDIchild4.Show();
            }

            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileVertical);

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        public void timer1_Tick(object sender, EventArgs e)
        {
            if (this.isConnected)
            {
                
                this.toolStripStatusLabel_connection.Text = "Connected";
                this.toolStripStatusLabel_connection.Image = Properties.Resources.conOK;
            }
            else
            {
                this.toolStripStatusLabel_connection.Text = "Connection failed";
                this.toolStripStatusLabel_connection.Image = Properties.Resources.conLOST;
            }

            foreach (DictionaryEntry quote in Quotes)
            {
                try
                {
                    Data df = new Data();
                    df.getDataFromGoogle_Async("", quote.Key.ToString(), "3d", 60);

                }
                catch
                {
                }
            }
        }

        private void defaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileVertical);
        }

        private void newsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_LiveNews newMDIchild = new frm_LiveNews();
            newMDIchild.MdiParent = this;
            newMDIchild.Show();
            newsToolStripMenuItem.Enabled = false;
        }

        private void alertsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Alerts newMDIchild = new frm_Alerts();
            newMDIchild.MdiParent = this;
            newMDIchild.Show();
            alertsToolStripMenuItem.Enabled = false;
        }

        private void liveQuotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_LiveQuotes newMDIchild = new frm_LiveQuotes();
            newMDIchild.MdiParent = this;
            newMDIchild.Show();
            liveQuotesToolStripMenuItem.Enabled = false;
        }

        public void enbaleAlerts()
        {
            alertsToolStripMenuItem.Enabled = true;
        }

        public void enbaleNews()
        {
            newsToolStripMenuItem.Enabled = true;
        }

        public void enbaleQuotes()
        {
            liveQuotesToolStripMenuItem.Enabled = true;
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void ChartManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_chartManager frm = new frm_chartManager();
            frm.ShowDialog();
        }

        private void restorePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_changePassword frm = new frm_changePassword();
            frm.ShowDialog();
        }
    }
}
