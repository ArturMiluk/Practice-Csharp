using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<LogEntry> allLogs = LogFileReader.ReadLogs();
            Console.WriteLine($"Загружено записей: {allLogs.Count}");

            DateTime start = DateTime.Now.Date;
            DateTime end = DateTime.Now.AddDays(1).Date;

            List<LogEntry> filtered = LogProcessor.FilterLogsByDate(allLogs, start, end);

            Console.WriteLine($"\nНайдено записей за период с {start:d} по {end:d}:");
            foreach (var log in filtered)
            {
                Console.WriteLine($"{log.Date:G} -> {log.Message}");
            }

            Console.ReadKey();
        }
    }
}
