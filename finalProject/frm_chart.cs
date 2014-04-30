using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace groupAssignment
{
    public partial class frm_chart : Form
    {
        private ChartControl chartControl;

        public ChartControl ChartControl
        {
            get { return chartControl; }
            set { chartControl = value; }
        }
    
        public frm_chart(ChartControl cc)
        {
            this.ChartControl = cc;
            InitializeComponent();
        }

        private void frm_chart_Load(object sender, EventArgs e)
        {

            if (chartControl.Online)
            {
                this.Text = chartControl.Symbol + " live";
                this.Name = chartControl.Symbol;
            }
            else
            {
                this.Text = chartControl.Symbol + " History";
                this.Name = chartControl.Symbol + "_history";
            }

            Data df = new Data();
            if (ChartControl.Online) df.getDataFromGoogle_Async("", this.Name, "2d", 60);
            else dispayChart(ChartControl, DataBase.getChartData(chartControl.Symbol));
        }
        
        public void updateChart(Candle lastPrice)
        {
            dispayChart(chartControl, getChartData());
        }

        private ArrayList getChartData()
        {
            if (!chartControl.Online)
                return DataBase.getChartData(chartControl.Symbol);
            else
                return Data.getDataFromGoogle("", this.Name, "2d", 60);
        }

        public void dispayChart(ChartControl chartControl, ArrayList chartSource)
        { 
            chart1.Series.Clear();
            chart1.ChartAreas.Clear();

            #region calculating min and max
            double maxHigh = 0;
            double minLow = 99999999;

            if (this.ChartControl.Online)
            {
                ArrayList liveChartSource = chartSource.GetRange(chartSource.Count - 200, 200);
                chartSource = liveChartSource;
            }

            foreach (Candle curCandle in chartSource)
            {
                if (curCandle.High > maxHigh) maxHigh = curCandle.High;
                if (curCandle.Low < minLow) minLow = curCandle.Low;
            }

            double delta = maxHigh - minLow;
            #endregion

            #region chart settings
            ChartArea chartArea = new ChartArea("ChartArea");
            Series line = new Series("line");
            Series price = new Series("price");
            chart1.ChartAreas.Add(chartArea);
            chart1.Series.Add(price);
            chart1.Series.Add(line);
            price.YValuesPerPoint = 4;
            chart1.Series["price"].ChartType = chartControl.ChartType;
            chart1.Series["line"].ChartType = SeriesChartType.Line;
            chart1.Series["price"].XValueType = ChartValueType.DateTime;
            chart1.Series["line"].XValueType = ChartValueType.DateTime;

            chartArea.AxisY.LabelStyle.Format = "F2";
            chartArea.AxisY.Maximum = maxHigh;
            chartArea.AxisY.Minimum = minLow;
            chartArea.AxisY.IntervalAutoMode = IntervalAutoMode.FixedCount;

            price["PriceUpColor"] = chartControl.PriceUpColor.ToArgb().ToString();
            price["PriceDownColor"] = chartControl.PriceDownColor.ToArgb().ToString();
            chart1.BackColor = chartControl.BackgroundColor;
            chartArea.BackColor = chartControl.BackgroundColor;
            price.Color = Color.Yellow;
            price.BorderColor = Color.Yellow;
            chart1.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.Yellow;
            chart1.ChartAreas[0].AxisX.LineColor = Color.Yellow;
            chart1.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.Yellow;
            chart1.ChartAreas[0].AxisY.LineColor = Color.Yellow;
            chart1.ChartAreas[0].AxisX.MajorTickMark.LineColor = Color.Yellow;
            chart1.ChartAreas[0].AxisY.MajorTickMark.LineColor = Color.Yellow;
            chart1.ChartAreas[0].AxisY.MinorTickMark.LineColor = Color.Yellow;
            chart1.ChartAreas[0].AxisX.MinorTickMark.LineColor = Color.Yellow;
            chart1.ChartAreas[0].AxisY.MajorTickMark.Size = 2;
            chart1.ChartAreas[0].AxisY.MinorTickMark.Size = 1;
            chart1.ChartAreas[0].AxisX.MajorTickMark.Size = 1;
            chart1.ChartAreas[0].AxisX.MajorTickMark.Interval = 50;

            //enable user to zoom selected part of the graph 
            if (this.ChartControl.Online)
            {
                chartArea.CursorX.IsUserEnabled = false;
                chartArea.CursorX.IsUserSelectionEnabled = false;
            }
            else
            {
                chartArea.CursorX.IsUserEnabled = true;
                chartArea.CursorX.IsUserSelectionEnabled = true;
            }

            chartArea.AxisX.ScrollBar.IsPositionedInside = false;

            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;

            price.IsXValueIndexed = true;
            line.IsXValueIndexed = true;
            #endregion

            #region displaying price chart
            for (int i = 0; i < chartSource.Count; i++)
            {
                Candle curCandle = (Candle)chartSource[i];
                if (i == chartSource.Count - 1) chartControl.LastCandleTime = curCandle.DateTime;
                if ((curCandle.DateTime > chartControl.HistoryFrom) && (curCandle.DateTime < chartControl.HistoryTo.AddDays(1)))
                    price.Points.AddXY(curCandle.DateTime, curCandle.High, curCandle.Low, curCandle.Open, curCandle.Close);
            }
            #endregion

            #region displaying moving averages
            try
            {
                if (this.ChartControl.MovingAverages[0].IsShown)
                {
                    Series ma1 = new Series("ma1");
                    ma1.Name = "ma1";
                    chart1.Series.Add(ma1);
                    ma1.IsXValueIndexed = true;
                    chart1.Series["ma1"].ChartType = SeriesChartType.Line;
                    ma1.Color = ChartControl.MovingAverages[0].Color;
                    ma1.BorderWidth = 2;

                    chart1.DataManipulator.FinancialFormula(
                        ChartControl.MovingAverages[0].Type,
                        ChartControl.MovingAverages[0].Period.ToString(),
                        ChartControl.MovingAverages[0].Price, "ma1:Y");

                    for (int i = 0; i < ChartControl.MovingAverages[0].Period - 1; i++)
                        ma1.Points.InsertXY(i, price.Points[i].XValue, price.Points[i].YValues[2]);
                }

                if (this.ChartControl.MovingAverages[1].IsShown == true)
                {
                    Series ma2 = new Series("ma2");
                    ma2.Name = "ma2";
                    chart1.Series.Add(ma2);
                    ma2.IsXValueIndexed = true;
                    chart1.Series["ma2"].ChartType = SeriesChartType.Line;
                    ma2.Color = ChartControl.MovingAverages[1].Color;
                    ma2.BorderWidth = 2;

                    chart1.DataManipulator.FinancialFormula(
                        ChartControl.MovingAverages[1].Type,
                        ChartControl.MovingAverages[1].Period.ToString(),
                        ChartControl.MovingAverages[1].Price, "ma2:Y");

                    for (int i = 0; i < ChartControl.MovingAverages[1].Period - 1; i++)
                        ma2.Points.InsertXY(i, price.Points[i].XValue, price.Points[i].YValues[2]);
                }

                if (this.ChartControl.MovingAverages[2].IsShown == true)
                {
                    Series ma3 = new Series("ma3");
                    ma3.Name = "ma3";
                    chart1.Series.Add(ma3);
                    ma3.IsXValueIndexed = true;
                    chart1.Series["ma3"].ChartType = SeriesChartType.Line;
                    ma3.Color = ChartControl.MovingAverages[2].Color;
                    ma3.BorderWidth = 2;

                    chart1.DataManipulator.FinancialFormula(
                        ChartControl.MovingAverages[2].Type,
                        ChartControl.MovingAverages[2].Period.ToString(),
                        ChartControl.MovingAverages[2].Price, "ma3:Y");

                    for (int i = 0; i < ChartControl.MovingAverages[2].Period - 1; i++)
                        ma3.Points.InsertXY(i, price.Points[i].XValue, price.Points[i].YValues[2]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            #endregion

            #region displaying last price line
            if (chartControl.ShowLastPrice)
            {
                //this loop adds line which represents last price
                for (int i = 0; i < price.Points.Count; i++)
                    line.Points.AddXY(price.Points[i].XValue, price.Points[price.Points.Count - 1].YValues[3]);

                //displaying lastprice label
                if (price.Points.Count > 0)
                {
                    line.Points[line.Points.Count - 1].IsValueShownAsLabel = true;
                    line.Points[line.Points.Count - 1].LabelBackColor = Color.Red;
                    line.SmartLabelStyle.Enabled = true;
                }
            }
            #endregion

            #region displaying titles
            try
            {
                DataPoint dp = price.Points[price.Points.Count - 1];

                foreach (Title title in chart1.Titles)
                {
                    if (title.Name == "close") title.Text = "close " + dp.YValues[3];
                    if (title.Name == "open") title.Text = "open " + dp.YValues[2];
                    if (title.Name == "high") title.Text = "high " + dp.YValues[0];
                    if (title.Name == "low") title.Text = "low " + dp.YValues[1];
                    String dt = DateTime.FromOADate(dp.XValue).ToShortTimeString();
                    if (title.Name == "time") title.Text = dt;
                    dt = DateTime.FromOADate(dp.XValue).ToShortDateString();
                    if (title.Name == "date") title.Text = dt;
                }
            }
            catch { };
            #endregion
        }

        private void panel_background_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = panel_background.BackColor;
            colorDialog1.SolidColorOnly = true;
            colorDialog1.AllowFullOpen = false;
            colorDialog1.ShowDialog();
            panel_background.BackColor = colorDialog1.Color;
        }

        private void panel_up_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = panel_up.BackColor;
            colorDialog1.SolidColorOnly = true;
            colorDialog1.AllowFullOpen = false;
            colorDialog1.ShowDialog();
            panel_down.BackColor = colorDialog1.Color;
        }

        private void panel_down_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = panel_down.BackColor;
            colorDialog1.SolidColorOnly = true;
            colorDialog1.AllowFullOpen = false;
            colorDialog1.ShowDialog();
            panel_down.BackColor = colorDialog1.Color;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (dateTime_from.Value.ToOADate() > chart1.Series["price"].Points[chart1.Series["price"].Points.Count - 1].XValue)
            {
                MessageBox.Show("Interval to display is out of range!");
                return;
            }

            if (dateTime_to.Value.ToOADate() < chart1.Series["price"].Points[0].XValue)
            {
                MessageBox.Show("Interval to display is out of range!");
                return;
            }

            this.ChartControl.HistoryFrom = dateTime_from.Value;
            this.ChartControl.HistoryTo = dateTime_to.Value;
            
            this.ChartControl.BackgroundColor = panel_background.BackColor;
            this.ChartControl.PriceUpColor = panel_up.BackColor;
            this.ChartControl.PriceDownColor = panel_down.BackColor;

            if (cmbbx_chartType.SelectedIndex == 0) 
                this.ChartControl.ChartType = SeriesChartType.Candlestick;
            else chartControl.ChartType = SeriesChartType.Stock;

            if (checkbx_showLastPrice.CheckState == CheckState.Checked)
                this.ChartControl.ShowLastPrice = true;
            else this.ChartControl.ShowLastPrice = false;

            if (cmbbx_ma1type.SelectedIndex != 0)
            {
                this.ChartControl.MovingAverages[0].IsShown = true;
                this.ChartControl.MovingAverages[0].Period = Convert.ToInt32(numeric_ma1period.Value);
                this.ChartControl.MovingAverages[0].Color = panel_ma1.BackColor;

                switch(cmbbx_ma1type.SelectedIndex)
                {
                    case 1:
                        this.ChartControl.MovingAverages[0].Type = FinancialFormula.MovingAverage;
                        break;
                    case 2:
                        this.ChartControl.MovingAverages[0].Type = FinancialFormula.ExponentialMovingAverage;
                        break;
                    case 3:
                        this.ChartControl.MovingAverages[0].Type = FinancialFormula.WeightedMovingAverage;
                        break;
                }

                switch (cmbbx_ma1price.SelectedIndex)
                {
                    case 0:
                        this.ChartControl.MovingAverages[0].Price = "price:Y4";
                        break;
                    case 1:
                        this.ChartControl.MovingAverages[0].Price = "price:Y3";
                        break;
                    case 2:
                        this.ChartControl.MovingAverages[0].Price = "price:Y2";
                        break;
                    case 3:
                        this.ChartControl.MovingAverages[0].Price = "price:Y1";
                        break;
                }

            }
            else this.ChartControl.MovingAverages[0].IsShown = false;

            if (cmbbx_ma2type.SelectedIndex != 0)
            {
                this.ChartControl.MovingAverages[1].IsShown = true;
                this.ChartControl.MovingAverages[1].Period = Convert.ToInt32(numeric_ma2period.Value);
                this.ChartControl.MovingAverages[1].Color = panel_ma2.BackColor;

                switch (cmbbx_ma2type.SelectedIndex)
                {
                    case 1:
                        this.ChartControl.MovingAverages[1].Type = FinancialFormula.MovingAverage;
                        break;
                    case 2:
                        this.ChartControl.MovingAverages[1].Type = FinancialFormula.ExponentialMovingAverage;
                        break;
                    case 3:
                        this.ChartControl.MovingAverages[1].Type = FinancialFormula.WeightedMovingAverage;
                        break;
                }

                switch (cmbbx_ma2price.SelectedIndex)
                {
                    case 0:
                        this.ChartControl.MovingAverages[1].Price = "price:Y4";
                        break;
                    case 1:
                        this.ChartControl.MovingAverages[1].Price = "price:Y3";
                        break;
                    case 2:
                        this.ChartControl.MovingAverages[1].Price = "price:Y2";
                        break;
                    case 3:
                        this.ChartControl.MovingAverages[1].Price = "price:Y1";
                        break;
                }
            }
            else this.ChartControl.MovingAverages[1].IsShown = false;

            if (cmbbx_ma3type.SelectedIndex != 0)
            {
                this.ChartControl.MovingAverages[2].IsShown = true;
                this.ChartControl.MovingAverages[2].Period = Convert.ToInt32(numeric_ma3period.Value);
                this.ChartControl.MovingAverages[2].Color = panel_ma3.BackColor;

                switch (cmbbx_ma3type.SelectedIndex)
                {
                    case 1:
                        this.ChartControl.MovingAverages[2].Type = FinancialFormula.MovingAverage;
                        break;
                    case 2:
                        this.ChartControl.MovingAverages[2].Type = FinancialFormula.ExponentialMovingAverage;
                        break;
                    case 3:
                        this.ChartControl.MovingAverages[2].Type = FinancialFormula.WeightedMovingAverage;
                        break;
                }

                switch (cmbbx_ma3price.SelectedIndex)
                {
                    case 0:
                        this.ChartControl.MovingAverages[2].Price = "price:Y4";
                        break;
                    case 1:
                        this.ChartControl.MovingAverages[2].Price = "price:Y3";
                        break;
                    case 2:
                        this.ChartControl.MovingAverages[2].Price = "price:Y2";
                        break;
                    case 3:
                        this.ChartControl.MovingAverages[2].Price = "price:Y1";
                        break;
                }
            }
            else this.ChartControl.MovingAverages[2].IsShown = false;

            dispayChart(chartControl, getChartData());
            //pnl_info.BackColor = ChartControl.BackgroundColor;
        }

        //on this event we rescaling Y axis in order to show graph in full height (i took this code from stackoverflow)
        private void chart1_AxisViewChanged_1(object sender, ViewEventArgs e)
        {
            if (e.Axis.AxisName == AxisName.X)
            {
                int start = (int)e.Axis.ScaleView.ViewMinimum;
                int end = (int)e.Axis.ScaleView.ViewMaximum;

                double[] tempHighs = chart1.Series[0].Points.Where((x, i) => i >= start && i <= end).Select(x => x.YValues[0]).ToArray();
                double[] tempLows = chart1.Series[0].Points.Where((x, i) => i >= start && i <= end).Select(x => x.YValues[1]).ToArray();
                double ymin = tempLows.Min();
                double ymax = tempHighs.Max();

                chart1.ChartAreas[0].AxisY.ScaleView.Position = ymin;
                chart1.ChartAreas[0].AxisY.ScaleView.Size = ymax - ymin;
            } 
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab.Name == "tabOptionsPage")
            {
                this.panel_background.BackColor = ChartControl.BackgroundColor;
                this.panel_up.BackColor = ChartControl.PriceUpColor;
                this.panel_down.BackColor = ChartControl.PriceDownColor;

                if (ChartControl.ChartType == SeriesChartType.Candlestick)
                    this.cmbbx_chartType.SelectedIndex = 0;
                else 
                    this.cmbbx_chartType.SelectedIndex = 1;

                this.dateTime_from.Value = ChartControl.HistoryFrom;
                this.dateTime_to.Value = ChartControl.HistoryTo;

                if (ChartControl.ShowLastPrice)
                    this.checkbx_showLastPrice.CheckState = CheckState.Checked;
                else
                    this.checkbx_showLastPrice.CheckState = CheckState.Unchecked;

                ComboBox[] maPriceComboBoxes = new ComboBox[3];
                maPriceComboBoxes[0] = cmbbx_ma1price;
                maPriceComboBoxes[1] = cmbbx_ma2price;
                maPriceComboBoxes[2] = cmbbx_ma3price;

                ComboBox[] maTypeComboBoxes = new ComboBox[3];
                maTypeComboBoxes[0] = cmbbx_ma1type;
                maTypeComboBoxes[1] = cmbbx_ma2type;
                maTypeComboBoxes[2] = cmbbx_ma3type;

                Panel[] maColorPanels = new Panel[3];
                maColorPanels[0] = panel_ma1;
                maColorPanels[1] = panel_ma2;
                maColorPanels[2] = panel_ma3;

                NumericUpDown[] maPeriods = new NumericUpDown[3];
                maPeriods[0] = numeric_ma1period;
                maPeriods[1] = numeric_ma2period;
                maPeriods[2] = numeric_ma3period;                

                for(int i = 0; i < ChartControl.MovingAverages.Length; i++)
                {
                    MovingAverage ma = ChartControl.MovingAverages[i];

                    if (ma.Price == "price:Y4") maPriceComboBoxes[i].SelectedIndex = 0;
                    if (ma.Price == "price:Y3") maPriceComboBoxes[i].SelectedIndex = 1;
                    if (ma.Price == "price:Y2") maPriceComboBoxes[i].SelectedIndex = 2;
                    if (ma.Price == "price:Y1") maPriceComboBoxes[i].SelectedIndex = 3;

                    if (ma.IsShown)
                    {
                        if (ma.Type == FinancialFormula.MovingAverage) maTypeComboBoxes[i].SelectedIndex = 1;
                        if (ma.Type == FinancialFormula.ExponentialMovingAverage) maTypeComboBoxes[i].SelectedIndex = 2;
                        if (ma.Type == FinancialFormula.WeightedMovingAverage) maTypeComboBoxes[i].SelectedIndex = 3;
                    }
                    else maTypeComboBoxes[i].SelectedIndex = 0;
                    
                    maColorPanels[i].BackColor = ma.Color;
                    maPeriods[i].Value = ma.Period;
                }
            }
        }

        private void panel_ma1_MouseClick(object sender, MouseEventArgs e)
        {
            colorDialog1.Color = panel_ma1.BackColor;
            colorDialog1.SolidColorOnly = true;
            colorDialog1.AllowFullOpen = false;
            colorDialog1.ShowDialog();
            panel_ma1.BackColor = colorDialog1.Color;
        }

        private void panel_ma2_MouseClick(object sender, MouseEventArgs e)
        {
            colorDialog1.Color = panel_ma2.BackColor;
            colorDialog1.SolidColorOnly = true;
            colorDialog1.AllowFullOpen = false;
            colorDialog1.ShowDialog();
            panel_ma2.BackColor = colorDialog1.Color;
        }

        private void panel_ma3_MouseClick(object sender, MouseEventArgs e)
        {
            colorDialog1.Color = panel_ma3.BackColor;
            colorDialog1.SolidColorOnly = true;
            colorDialog1.AllowFullOpen = false;
            colorDialog1.ShowDialog();
            panel_ma3.BackColor = colorDialog1.Color;
        }

        private void chart1_CursorPositionChanged_1(object sender, CursorEventArgs e)
        {
            if ((e.ChartArea.CursorX.Position - 1) > 0)
            {
                try
                {
                    DataPoint dp = chart1.Series[0].Points[(int)Math.Max(e.ChartArea.CursorX.Position - 1, 0)];

                    foreach (Title title in chart1.Titles)
                    {
                        if (title.Name == "close") title.Text = "close " + dp.YValues[3];
                        if (title.Name == "open") title.Text = "open " + dp.YValues[2];
                        if (title.Name == "high") title.Text = "high " + dp.YValues[0];
                        if (title.Name == "low") title.Text = "low " + dp.YValues[1];
                        String dt = DateTime.FromOADate(dp.XValue).ToShortTimeString();
                        if (title.Name == "time") title.Text = dt;
                        dt = DateTime.FromOADate(dp.XValue).ToShortDateString();
                        if (title.Name == "date") title.Text = dt;
                    }
                }
                catch { };
            }
        }
    }
}
