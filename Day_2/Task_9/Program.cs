using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9
{
    class Program
    {
        private static void Main()
        {
            var mainString = new StringBuilder("StringBuilder");
            Console.WriteLine($"Исходная строка: {mainString}");

            string textToInsert = "123";

            int middleIndex = mainString.Length / 2;

            mainString.Insert(middleIndex, textToInsert);

            Console.WriteLine($"Результат вставки в середину: {mainString}");
            Console.WriteLine($"Новая длина: {mainString.Length}");

            Console.ReadKey();
        }
    }
}
