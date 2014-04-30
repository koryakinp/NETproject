using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.IO;
using System.Globalization;
using System.Threading;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace groupAssignment {
    public class DataProcessor {
        private enum Columns { date = 0, close = 1, high = 2, low = 3, open = 4, volume = 5 };
        private const string COLUMNS_ROW_BEGINNING = "COLUMNS=";
        private const string COLUMNS_ROW = COLUMNS_ROW_BEGINNING + "DATE,CLOSE,HIGH,LOW,OPEN,VOLUME";
        private const int EXPECTED_NUMBER_OF_FIELDS = 6;
        private const string BEGINNING_OF_DATE = "a";
        private const string TIME_ZONE_OFFSET_ROW_BEGINNING = "TIMEZONE_OFFSET=";

        public ArrayList getHistory(Stream str, int interval)
        {

            ArrayList candleList = new ArrayList();
            StringBuilder stringResult = new StringBuilder();
            StreamReader sr = new StreamReader(str);

            string line;
            DateTime lastInterpretedDate = DateTime.MaxValue;
            DateTime previousDate = DateTime.MaxValue;
            bool processingData = false;

            int offset = 0;
            while ((line = sr.ReadLine()) != null)
            {

                if (line.StartsWith(TIME_ZONE_OFFSET_ROW_BEGINNING))
                {
                    offset = Convert.ToInt32(line.Substring(16));
                    continue;
                }

                if (!processingData)
                {
                    if (line.StartsWith(BEGINNING_OF_DATE)) processingData = true;
                    else continue;
                }

                string[] elements = line.Split(',');
                DateTime dt;

                if (elements[(int)Columns.date].StartsWith(BEGINNING_OF_DATE))
                {
                    dt = ConvertFromUnixTimestamp(double.Parse(elements[0].Substring(1)));
                    dt = dt.AddMinutes(offset);
                    lastInterpretedDate = dt;
                }
                else dt = lastInterpretedDate.AddSeconds(interval * int.Parse(elements[0]));

                candleList.Add(new Candle(dt,
                    Convert.ToDouble(elements[(int)Columns.high]),
                    Convert.ToDouble(elements[(int)Columns.low]),
                    Convert.ToDouble(elements[(int)Columns.open]),
                    Convert.ToDouble(elements[(int)Columns.close])));
            }
            return candleList;

        }
      
        delegate bool ExtractValue(Columns columnNumber, out float value, out string localMessage);       
        private DateTime ConvertFromUnixTimestamp(double timestamp) {
            DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            return origin.AddSeconds(timestamp);
        }

        private void checkElements(string[] elements) {
            if (elements == null || elements.Length != EXPECTED_NUMBER_OF_FIELDS)
                throw new ArgumentException("'elements' was null or had an unexpected number of fields.");
        }

        private bool getGoogleDate(string[] elements, out DateTime googleDate, int offset) {
            checkElements(elements);
            googleDate = DateTime.MinValue;

            Regex regexFirstDate = new Regex(@"a\d+");
            if (!regexFirstDate.IsMatch(elements[0])) {
                return false;
            }

            if (offset == int.MinValue) {
                throw new ArgumentException("Invalid value for offset.");
            }

            long value;
            if (!long.TryParse(elements[0].Substring(1), out value)) {
                return false;
            }


            googleDate = new DateTime(ConvertFromUnixTimestamp(value).Ticks).AddMinutes(offset).Date;
            return true;
        }

        /*
        private string formatData<T>(DateTime date, T open, T high, T low, T close, T volume) {
            return String.Format("{0},{1},{2},{3},{4},{5}", date.ToString("yyyy-MM-dd"),
                    open, high, low, close, volume);
        }
         */
    }
}
