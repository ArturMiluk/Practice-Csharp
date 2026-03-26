using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathForWatch = "WatchFolder";

            FileWatcher watcher = new FileWatcher(pathForWatch);

            Console.WriteLine("\nМониторинг:");
            Console.WriteLine("Можно создать, изменить или удалить файл в папке 'WatchFolder'.");

            Console.ReadKey();
        }
    }
}
