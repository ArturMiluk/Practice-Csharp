using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static void Main()
        {
            int[] numbers = {1, 2, 3, 4, 5};

            var totalSum = numbers.SumElements();

            Console.WriteLine($"Сумма элементов массива: {totalSum}");

            Console.ReadKey();
        }
    }
}
