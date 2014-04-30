using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Net;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace groupAssignment
{

    class Data
    {

        public static ArrayList getDataFromGoogle(String exchange, String symbol, String period, int interval)
        {
            DownloadURIBuilder db = new DownloadURIBuilder();
            WebClient wClient = new WebClient();
            String url = db.getGetPricesUri(symbol, exchange, period, interval);
            String downloadedData = wClient.DownloadString(url);
            MemoryStream ms = new MemoryStream(System.Text.Encoding.Default.GetBytes(downloadedData));
            DataProcessor dp = new DataProcessor();
            return dp.getHistory(ms, interval);
        }

        public void getDataFromGoogle_Async(String exchange, String symbol, String period, int interval)
        {
            DownloadURIBuilder db = new DownloadURIBuilder();
            WebClient wClient = new WebClient();
            Uri urlAddress = new Uri(db.getGetPricesUri(symbol, exchange, period, interval));
            wClient.DownloadStringCompleted += new DownloadStringCompletedEventHandler((sender, e) => DownloadComplete(sender, e, symbol));
            wClient.DownloadStringAsync(urlAddress);

            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Name == "frm_mainForm")
                {
                    frm_mainForm form = (frm_mainForm)frm;
                    form.isConnected = false;
                }              
            }

        }

        public void DownloadComplete(Object sender, DownloadStringCompletedEventArgs e, String symbol)
        {
            if (!e.Cancelled && e.Error == null)
            {
                string result = (string)e.Result;
                MemoryStream ms = new MemoryStream(System.Text.Encoding.Default.GetBytes(result));
                DataProcessor dp = new DataProcessor();
                ArrayList candles = dp.getHistory(ms, 60);
                foreach (Form frm in Application.OpenForms)
                {                 
                    if (frm.Name == symbol)
                    {
                        frm_chart form = (frm_chart)frm;
                        form.dispayChart(form.ChartControl, candles);
                    }

                    if (frm.Name == "frm_mainForm")
                    {
                        frm_mainForm form = (frm_mainForm)frm;
                        form.isConnected = true;
                    }

                    if (frm.Name == "frm_LiveQuotes")
                    {
                        frm_LiveQuotes form = (frm_LiveQuotes)frm;
                        form.update(symbol, (Candle)candles[candles.Count - 1]);
                    }

                    if (frm.Name == "frm_Alerts")
                    {
                        frm_Alerts form = (frm_Alerts)frm;
                        form.update(symbol, (Candle)candles[candles.Count - 1]);
                    }
                }
            }
        }
    }
}
