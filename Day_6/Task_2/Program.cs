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
            int[] numbers = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            Console.WriteLine("Фильтрация чётных чисел:");
            FilterNumbers(numbers, NumberFilters.IsEven);

            Console.WriteLine("\nФильтрация нечётных чисел:");
            FilterNumbers(numbers, NumberFilters.IsOdd);

            Console.ReadKey();
        }

        static void FilterNumbers(int[] numbers, NumberCheck check)
        {
            foreach (var n in numbers)
            {
                if (check(n))
                {
                    Console.Write($"{n} ");
                }
            }
            Console.WriteLine();
        }
    }
}
