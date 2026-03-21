using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main()
        {
            Instrument[] orchestra =
            {
                new Guitar("Акустическая гитара"),
                new Drum("Бас-барабан"),
                new Guitar("Электрогитара"),
                new Drum("Малый барабан")
            };

            Console.WriteLine("Поиск только струнных инструментов:");

            foreach (var instrument in orchestra)
            {
                if (instrument is IStringInstrument stringInstrument)
                {
                    Console.WriteLine($"Найден инструмент: {instrument.Name}");
                    stringInstrument.PlayStrings();
                }
            }

            Console.ReadKey();
        }
    }
}
