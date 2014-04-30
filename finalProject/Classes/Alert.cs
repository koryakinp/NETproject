using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace groupAssignment
{
    class Alert
    {
        public Alert(String symbol, double target)
        {
            this.Symbol = symbol;
            this.Target = target;
        }

        private String symbol;

        public String Symbol
        {
            get { return symbol; }
            set { symbol = value; }
        }
        private double target;

        public double Target
        {
            get { return target; }
            set { target = value; }
        }
    }
}
