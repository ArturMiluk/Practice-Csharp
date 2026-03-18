using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task_10
{
    class Program
    {
        private static void Main()
        {
            string dateString = "Нулевой день практики: 16.03.2026, первый день 17.03.2006, второй день 18.03.2006.";

            string datePattern = @"\b\d{2}\.\d{2}\.\d{4}\b";

            Console.WriteLine($"Строка с датами: {dateString}\n");

            MatchCollection foundMatches = Regex.Matches(dateString, datePattern);

            if (foundMatches.Count > 0)
            {
                Console.WriteLine("Найденные даты:");
                foreach (Match match in foundMatches)
                {
                    Console.WriteLine($"{match.Value}");
                }
            }
            else
            {
                Console.WriteLine("Даты в формате дд.мм.гггг не найдены.");
            }

            Console.ReadKey();
        }
    }
}
