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
using System.IO;

namespace groupAssignment
{
    public partial class frm_chartManager : Form
    {
        public frm_chartManager()
        {
            InitializeComponent();
        }

        private void chartsManager_Load(object sender, EventArgs e)
        {
            ArrayList ImportedCharts = DataBase.getUsersImportedChartList(User.curUsername);
            foreach (String symbolName in ImportedCharts)
            {
                cmbbx_importedCharts.Items.Add(symbolName);
            }
            progressBar1.Hide();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (cmbbx_importedCharts.SelectedIndex == -1) return;
            if (DataBase.deleteChartData(cmbbx_importedCharts.SelectedItem.ToString(), User.curUsername))
            {
                MessageBox.Show(cmbbx_importedCharts.SelectedItem.ToString() + " deleted from the chart list");
                cmbbx_importedCharts.Items.Clear();
                ArrayList ImportedCharts = DataBase.getUsersImportedChartList(User.curUsername);
                foreach (String symbolName in ImportedCharts)
                {
                    cmbbx_importedCharts.Items.Add(symbolName);
                    frm_mainForm frm = ((frm_mainForm)Application.OpenForms["frm_mainForm"]);
                    frm.BuildMenuItems();
                }
            }

            cmbbx_importedCharts.SelectedIndex = -1;
        }

        private void btn_import_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog1.FileName;
                txt_path.Text = filename;                   
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {        
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            try
            {
                string filename = txt_path.Text;
                openFileDialog1.FileName = filename;
                string[] filelines = File.ReadAllLines(filename);
                ArrayList chartData = new ArrayList();
                string[] fileName = openFileDialog1.SafeFileName.Split('.');

                ArrayList usersCharts = DataBase.getUsersChartList(User.curUsername);
                if (usersCharts.Contains(fileName[0]))
                {
                    MessageBox.Show("You allready have " + fileName[0] + " in your chart list!");
                    return;
                }

                foreach (String line in filelines)
                {
                    string[] words = line.Split(',');
                    try
                    {
                        DateTime myDate = DateTime.ParseExact(words[0], "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None);
                        DateTime myTime = DateTime.ParseExact(words[1], "HHmmss", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None);

                        myDate = myDate.Add(myTime.TimeOfDay);

                        Double open = Convert.ToDouble(words[2]);
                        Double high = Convert.ToDouble(words[3]);
                        Double low = Convert.ToDouble(words[4]);
                        Double close = Convert.ToDouble(words[5]);
                        chartData.Add(new Candle(myDate, high, low, open, close));
                    }
                    catch
                    {
                        MessageBox.Show("File format is invalid. Error in line: \n" + line);
                        return;
                    }
                }

                progressBar1.Show();
                if (DataBase.addNewChart(chartData, fileName[0], User.curUsername))
                {
                    cmbbx_importedCharts.Items.Add(fileName[0]);
                    frm_mainForm frm = ((frm_mainForm)Application.OpenForms["frm_mainForm"]);
                    frm.BuildMenuItems();
                }

                progressBar1.Hide(); ;
            }
            catch (Exception ex)
            {
                MessageBox.Show("File error: " + ex.Message);
                progressBar1.Hide();
            }
        }

        public void IncrementProgressBar()
        {
            this.progressBar1.Value++;
        }
    }
}
