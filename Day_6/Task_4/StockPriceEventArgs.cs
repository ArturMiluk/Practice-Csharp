using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    public class StockPriceEventArgs : EventArgs
    {
        public string StockName {get;}
        public double NewPrice {get;}

        public StockPriceEventArgs(string stockName, double newPrice)
        {
            StockName = stockName;
            NewPrice = newPrice;
        }
    }
}

