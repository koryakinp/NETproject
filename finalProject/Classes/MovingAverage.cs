using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;

namespace groupAssignment
{
    class MovingAverage
    {
        public MovingAverage(int period, Color color, FinancialFormula type, String price, Boolean isShown)
        {
            this.Period = period;
            this.Color = color;
            this.Type = type;
            this.Price = price;
            this.IsShown = isShown;
        }

        private Boolean isShown;

        public Boolean IsShown
        {
            get { return isShown; }
            set { isShown = value; }
        }

        private int period;

        public int Period
        {
            get { return period; }
            set { period = value; }
        }
        private FinancialFormula type;

        public FinancialFormula Type
        {
            get { return type; }
            set { type = value; }
        }
        private Color color;

        public Color Color
        {
            get { return color; }
            set { color = value; }
        }
        private String price;

        public String Price
        {
            get { return price; }
            set { price = value; }
        }


    }
}
