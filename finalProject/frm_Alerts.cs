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

namespace groupAssignment
{
    public partial class frm_Alerts : Form
    {
        public frm_Alerts()
        {
            InitializeComponent();
        }

        private void Alerts_Load(object sender, EventArgs e)
        {
            System.Collections.ICollection Quotes = frm_mainForm.Quotes.Keys;
            foreach(String str in Quotes)
                cmbbx_symbol.Items.Add(str);
            this.Name = "frm_Alerts";
            this.AcceptButton = btn_addalert;

            ArrayList AlertList = DataBase.getUserAlerts(User.curUsername);
            double lastPrice;

            foreach (Alert alert in AlertList)
            {
                ArrayList candles = Data.getDataFromGoogle("", alert.Symbol, "10d", 86400);
                lastPrice = ((Candle)candles[candles.Count - 2]).Close;
                dataGridView1.Rows.Add(alert.Symbol, lastPrice, alert.Target);
            }


        }

        public void update(String symbol, Candle lastCandle)
        {

            double prev = 0;
            double next = 0;
            double target = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
                if (row.Cells[0].Value == symbol)
                {
                    prev = Convert.ToDouble(row.Cells[1].Value);
                    next = lastCandle.Close;
                    target = Convert.ToDouble(row.Cells[2].Value);
                    row.SetValues(row.Cells[0].Value, lastCandle.Close, row.Cells[2].Value);
                }


            if ((prev <= target) && (next > target) || (prev >= target) && (next < target))
            {
                MessageBox.Show(symbol + " has reached target price " + target);
                foreach (DataGridViewRow rowToDelete in dataGridView1.Rows)
                    if (rowToDelete.Cells[0].Value.ToString() == symbol)
                    {    
                        dataGridView1.Rows.Remove(rowToDelete);
                        return;
                    }
               }
        }

        private void btn_addalert_Click(object sender, EventArgs e)
        {
            if (cmbbx_symbol.SelectedIndex == -1) return;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (cmbbx_symbol.SelectedItem.ToString() == row.Cells[0].Value.ToString())
                return;
            }

            if(cmbbx_symbol.SelectedIndex == -1)
                return;

            if (txt_targetPrice.Text == "")
                return;

            string result = "";
            foreach(Form form in this.MdiParent.MdiChildren)
                if (form.Name == "frm_LiveQuotes")
                {
                    frm_LiveQuotes frm = (frm_LiveQuotes)form;
                    result = frm.getQuote(cmbbx_symbol.SelectedItem.ToString());
                    break;
                }

            DataBase.addNewAlert(User.curUsername, cmbbx_symbol.SelectedItem.ToString(), Convert.ToDouble(txt_targetPrice.Text));
            dataGridView1.Rows.Add(cmbbx_symbol.SelectedItem, result, txt_targetPrice.Text);
            txt_targetPrice.Clear();
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

                    MenuItem deleteAlert = new MenuItem("Remove Alert " + curCellValue);

                    deleteAlert.Click += deleteAlert_Click;
                    deleteAlert.Tag = curCellValue;

                    m.MenuItems.Add(deleteAlert);
                }
                m.Show(dataGridView1, new Point(e.X, e.Y));
            }
        }

        public bool deleteAlert(String SymbolToDelete)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
                if (row.Cells[0].Value.ToString() == SymbolToDelete)
                {
                    dataGridView1.Rows.Remove(row);
                    return true;
                }
            return false;
        }

        private void deleteAlert_Click(object sender, EventArgs e)
        {
            MenuItem mi = (MenuItem)sender;
            String SymbolToDelete = (String)mi.Tag;
            deleteAlert(SymbolToDelete);
            DataBase.deleteAlert(User.curUsername, SymbolToDelete);
        }

        private void cmbbx_symbol_MouseClick(object sender, MouseEventArgs e)
        {
            System.Collections.ICollection Quotes = frm_mainForm.Quotes.Keys;
            if (Quotes.Count != cmbbx_symbol.Items.Count)
            {
                cmbbx_symbol.Items.Clear();
                foreach (String str in Quotes)
                    cmbbx_symbol.Items.Add(str);
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

        private void frm_Alerts_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm_mainForm frm = (frm_mainForm)Application.OpenForms["frm_mainForm"];
            frm.enbaleAlerts();
        }
    }
}
