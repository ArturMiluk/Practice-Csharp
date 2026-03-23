using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    public class MarketObserver
    {
        public void RegisterParticipants(StockMarket market, Investor investor, NewsPublisher news)
        {
            market.StockPriceUpdated += investor.OnPriceChanged;
            market.StockPriceUpdated += news.OnPriceChanged;
        }
    }
}

