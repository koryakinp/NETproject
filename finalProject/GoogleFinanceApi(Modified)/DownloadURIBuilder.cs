using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace groupAssignment {

    public class DownloadURIBuilder {
              
        public DownloadURIBuilder() {            
        }
       
        public string getGetPricesUri(String ticker, String exchange, String period, int interval) {
            string START_GET_PRICES_URI = "http://www.google.com/finance/getprices";
            string formatURI = START_GET_PRICES_URI + "?q={0}&x={1}&i={2}&p={3}&f=d,c,h,l,o,v";
            return String.Format(formatURI, ticker, exchange, interval, period);
        }
    }
}
