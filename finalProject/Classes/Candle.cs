using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace groupAssignment
{
    //this class represent a candle to be ploted on the chart
    public class Candle
    {
        public Candle()
        {
        }

        public Candle(DateTime dateTime, double high, double low, double open, double close)
        {
            this.dateTime = dateTime;
            this.high = high;
            this.low = low;
            this.open = open;
            this.close = close;
        }

        private DateTime dateTime;

        public DateTime DateTime
        {
            get { return dateTime; }
            set { dateTime = value; }
        }
        private double open;

        public double Open
        {
            get { return open; }
            set { open = value; }
        }
        private double high;

        public double High
        {
            get { return high; }
            set { high = value; }
        }
        private double low;

        public double Low
        {
            get { return low; }
            set { low = value; }
        }
        private double close;

        public double Close
        {
            get { return close; }
            set { close = value; }
        }
        private double vol;

        public double Vol
        {
            get { return vol; }
            set { vol = value; }
        }
    }
}
