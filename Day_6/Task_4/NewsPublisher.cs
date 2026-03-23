using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    public class NewsPublisher
    {
        public void OnPriceChanged(object sender, StockPriceEventArgs e)
        {
            Console.WriteLine($"Новости - Акции {e.StockName} достигли отметки {e.NewPrice:F2}!");
        }
    }
}
