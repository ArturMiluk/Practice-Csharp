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
            int number = 776;

            int firstDigit = number / 100;
            int lastDigit = number % 10;

            Console.WriteLine($"Первая цифра: {firstDigit}");
            Console.WriteLine($"Последняя цифра: {lastDigit}");

            Console.ReadKey();
        }
    }
}