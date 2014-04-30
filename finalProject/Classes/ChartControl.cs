using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;

namespace groupAssignment
{
    public class ChartControl
    {


        public ChartControl() 
        {
            ChartType = SeriesChartType.Candlestick;
            BackgroundColor = Color.Black;
            PriceUpColor = Color.Black;
            PriceDownColor = Color.Yellow;
            HistoryFrom = new DateTime(2001,1,1);
            HistoryTo = DateTime.Now;
            ShowLastPrice = true;
            Path = "";
            Exchange = "NYSE";
            Period = "3d";
            Interval = 60;
            Online = false;
            Symbol = "";           
        }


        private MovingAverage[] movingAverages = new MovingAverage[3] 
        {
            new MovingAverage(25, Color.Red, FinancialFormula.MovingAverage, "price:Y4", true),
            new MovingAverage(20, Color.Green, FinancialFormula.MovingAverage, "price:Y4", false),
            new MovingAverage(15, Color.Blue, FinancialFormula.MovingAverage, "price:Y4", false)
        };

        internal MovingAverage[] MovingAverages
        {
            get { return movingAverages; }
            set { movingAverages = value; }
        }

        private DateTime lastCandleTime;

        public DateTime LastCandleTime
        {
            get { return lastCandleTime; }
            set { lastCandleTime = value; }
        }


        private String symbol;

        public String Symbol
        {
            get { return symbol; }
            set { symbol = value; }
        }

        private bool online;

        public bool Online
        {
            get { return online; }
            set { online = value; }
        }
        private String exchange;

        public String Exchange
        {
            get { return exchange; }
            set { exchange = value; }
        }
        private String period;

        public String Period
        {
            get { return period; }
            set { period = value; }
        }
        private int interval;

        public int Interval
        {
            get { return interval; }
            set { interval = value; }
        }

        private String path;

        public String Path
        {
            get { return path; }
            set { path = value; }
        }

        private SeriesChartType chartType;

        public SeriesChartType ChartType
        {
            get { return chartType; }
            set { chartType = value; }
        }
        private Color backgroundColor;

        public Color BackgroundColor
        {
            get { return backgroundColor; }
            set { backgroundColor = value; }
        }
        private Color priceUpColor;

        public Color PriceUpColor
        {
            get { return priceUpColor; }
            set { priceUpColor = value; }
        }
        private Color priceDownColor;

        public Color PriceDownColor
        {
            get { return priceDownColor; }
            set { priceDownColor = value; }
        }
        private DateTime historyFrom;

        public DateTime HistoryFrom
        {
            get { return historyFrom; }
            set { historyFrom = value; }
        }
        private DateTime historyTo;

        public DateTime HistoryTo
        {
            get { return historyTo; }
            set { historyTo = value; }
        }
        private Boolean showLastPrice;

        public Boolean ShowLastPrice
        {
            get { return showLastPrice; }
            set { showLastPrice = value; }
        }
    }
}
