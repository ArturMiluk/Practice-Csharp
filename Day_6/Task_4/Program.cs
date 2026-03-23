using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static void Main()
        {
            var market = new StockMarket();
            var investor = new Investor();
            var news = new NewsPublisher();
            var observer = new MarketObserver();

            observer.RegisterParticipants(market, investor, news);

            market.UpdatePrice("Apple", 185.50);
            Console.WriteLine();
            market.UpdatePrice("Tesla", 240.15);

            Console.ReadKey();
        }
    }
}
