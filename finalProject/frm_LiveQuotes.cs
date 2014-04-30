using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic;

namespace groupAssignment
{
    public partial class frm_LiveQuotes : Form
    {
        frm_Alerts alerts = new frm_Alerts();

        public frm_LiveQuotes()
        {
            InitializeComponent();
        }



        public String getChange(double lastPrice, double todaysOpen)
        {
            double value = ((lastPrice - todaysOpen) / todaysOpen) * 100;
            String result;
            if(value >= 0)
                result = String.Format("+{0:0.00}%", value);
            else
                result = String.Format("{0:0.00}%", value);

            return result;
        }


        private void LiveQuotes_Load(object sender, EventArgs e)
        {
            foreach (DictionaryEntry quote in frm_mainForm.Quotes)
            {
                ArrayList candles = Data.getDataFromGoogle("", quote.Key.ToString(), "10d", 86400);
                double todaysOpen = ((Candle)candles[candles.Count - 2]).Close;               
                dataGridView1.Rows.Add(quote.Key.ToString(), null, null, DateTime.Now.ToShortTimeString(), todaysOpen);
            }

            frm_Alerts alerts = new frm_Alerts();
            alerts.Tag = dataGridView1;

            foreach (DataGridViewColumn column in dataGridView1.Columns)
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridView1.AutoResizeRows(DataGridViewAutoSizeRowsMode.DisplayedCells);

            foreach (DictionaryEntry quote in frm_mainForm.Quotes)
            {
                Data df = new Data();
                df.getDataFromGoogle_Async("", quote.Key.ToString(), "3d", 60);
            }

            foreach (DataGridViewRow row in dataGridView1.Rows)
                row.DefaultCellStyle.BackColor = Color.Yellow;
        }

        public void update(String symbol, Candle lastCandle)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
                if (row.Cells[0].Value.ToString() == symbol)
                {
                    double prevPrice = Convert.ToDouble(dataGridView1.Rows[row.Index].Cells[2].Value);

                    double lastPrice = lastCandle.Close;
                    String formatedPrice = String.Format("{0:00.00}", lastPrice);
                    String formatedChange = getChange(lastPrice, Convert.ToDouble(row.Cells[4].Value));
                    dataGridView1.Rows[row.Index].SetValues(row.Cells[0].Value, formatedChange, formatedPrice, DateTime.Now.ToShortTimeString());
                    if ((lastCandle.Close > prevPrice) && (prevPrice != 0))
                        dataGridView1.Rows[row.Index].DefaultCellStyle.BackColor = Color.Green;
                    if (lastCandle.Close < prevPrice)
                        dataGridView1.Rows[row.Index].DefaultCellStyle.BackColor = Color.Red;
                    if (lastCandle.Close == prevPrice)
                        dataGridView1.Rows[row.Index].DefaultCellStyle.BackColor = Color.Yellow;                 
                    return;
                }


        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu m = new ContextMenu();

                int currentMouseOverRow = dataGridView1.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow >= 0)
                {
                    String curCellValue = dataGridView1.Rows[currentMouseOverRow].Cells[0].Value.ToString();

                    MenuItem openChart = new MenuItem("Open Chart " + curCellValue);
                    MenuItem deleteSymbol = new MenuItem("Delete Symbol " + curCellValue);
                    MenuItem addSymbol = new MenuItem("Add Symbol");

                    openChart.Click += openChart_Click;
                    openChart.Tag = curCellValue;
                    deleteSymbol.Click += deleteSymbol_Click;
                    deleteSymbol.Tag = curCellValue;
                    addSymbol.Click += addSymbol_Click;

                    m.MenuItems.Add(openChart);
                    m.MenuItems.Add(deleteSymbol);
                    m.MenuItems.Add(addSymbol);
                }
                m.Show(dataGridView1, new Point(e.X, e.Y));
            }
        }

        void addSymbol_Click(object sender, EventArgs e)
        {
            String NewSymbol = Interaction.InputBox("Enter symbol to be add in the quotes list", "Enter new symbol", string.Empty, -1, -1).ToUpper();
            if(frm_mainForm.Quotes.ContainsKey(NewSymbol)) MessageBox.Show(NewSymbol + "is allready in the quotes list!");
            else
            {
                try
                {
                    ArrayList candles = Data.getDataFromGoogle("", NewSymbol, "10d", 86400);
                    double todaysOpen = ((Candle)candles[candles.Count - 2]).Close;
                    frm_mainForm.Quotes.Add(NewSymbol, new Candle());
                    dataGridView1.Rows.Add(NewSymbol, null, null, DateTime.Now.ToShortTimeString(),todaysOpen);
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Yellow;

                    Data df = new Data();
                    df.getDataFromGoogle_Async("", NewSymbol, "3d", 60);
                    DataBase.addUserQuotes(User.curUsername, NewSymbol);
                }
                catch { MessageBox.Show(NewSymbol + " no such symbol listed!"); }
            }

            dataGridView1.AutoResizeRows(DataGridViewAutoSizeRowsMode.DisplayedCells);
        }

        public String getQuote(String symbol)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
                if (row.Cells[0].Value.ToString() == symbol)
                    return row.Cells[2].Value.ToString();

            return "";
        }

        void deleteSymbol_Click(object sender, EventArgs e)
        {
            MenuItem mi = (MenuItem)sender;
            foreach (Form form in this.MdiParent.MdiChildren)
            {
                if ((form is frm_chart) && (form.Name == mi.Tag.ToString())) form.Close();
                if (form is frm_Alerts) 
                {
                    frm_Alerts frm = (frm_Alerts)form;
                    if(frm.deleteAlert(mi.Tag.ToString()))
                        DataBase.deleteAlert(User.curUsername, mi.Tag.ToString());                   
                }
            }

            foreach (DataGridViewRow row in dataGridView1.Rows)
                if (row.Cells[0].Value.ToString() == mi.Tag.ToString())
                {
                    dataGridView1.Rows.Remove(row);
                    break;
                }

            if (frm_mainForm.Quotes.Contains(mi.Tag.ToString()))
            {
                DataBase.deleteQuote(User.curUsername, mi.Tag.ToString());
                frm_mainForm.Quotes.Remove(mi.Tag.ToString());
            }
            
        }

        void openChart_Click(object sender, EventArgs e)
        {
            MenuItem mi = (MenuItem)sender;

            ChartControl chartControl = new ChartControl();
            chartControl.Online = true;
            chartControl.Symbol = mi.Tag.ToString();
            chartControl.Exchange = "";
            chartControl.Interval = 60;
            chartControl.Period = "1d";
            frm_chart newMDIchild = new frm_chart(chartControl);
            newMDIchild.MdiParent = this.MdiParent;
            newMDIchild.Show();
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

        private void frm_LiveQuotes_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm_mainForm frm = (frm_mainForm)Application.OpenForms["frm_mainForm"];
            frm.enbaleQuotes();
        }
    }
}
