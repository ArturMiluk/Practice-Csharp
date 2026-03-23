using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    public class Investor
    {
        public void OnPriceChanged(object sender, StockPriceEventArgs e)
        {
            Console.WriteLine($"Инвестор - Анализ {e.StockName}. Цена {e.NewPrice:F2}.");
        }
    }
}

