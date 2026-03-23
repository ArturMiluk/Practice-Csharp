using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    public class StockMarket
    {
        public event EventHandler<StockPriceEventArgs> StockPriceUpdated;

        public void UpdatePrice(string stockName, double price)
        {
            Console.WriteLine($"Котировка {stockName} изменилась на {price:F2}.");

            StockPriceUpdated?.Invoke(this, new StockPriceEventArgs(stockName, price));
        }
    }
}

