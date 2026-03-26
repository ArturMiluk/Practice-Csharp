using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            LogEntry log1 = new LogEntry("Запуск");
            LogEntry log2 = new LogEntry("Выполнено");

            LogFileWriter.AppendLogEntry(log1);
            LogFileWriter.AppendLogEntry(log2);

            if (File.Exists("milukaa.data"))
            {
                Console.WriteLine("\nСодержимое milukaa.data:");
                Console.WriteLine(File.ReadAllText("milukaa.data"));
            }

            Console.ReadKey();
        }
    }
}
