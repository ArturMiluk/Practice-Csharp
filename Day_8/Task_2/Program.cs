using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main()
        {
            QueueProcessor<string> officeScanner = new QueueProcessor<string>();

            officeScanner.AddTask("Выполнение практического задания");
            officeScanner.AddTask("Составление отчёта");
            officeScanner.AddTask("Отправка заданий");
            officeScanner.ProcessAll();

            Console.ReadKey();
        }
    }
}
