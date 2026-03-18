using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class Program
    {
        private static void Main()
        {
            int[][] numbers =
            [
            [5, 1, 2],
            [10, 20],
            [1, 1, 1, 1, 1],
            [15]
            ];

            Console.WriteLine("Исходный массив:");
            PrintJaggedArray(numbers);

            var sortedNumbers = numbers
                .OrderByDescending(row => row.Sum())
                .ToArray();

            Console.WriteLine("\nМассив после сортировки строк по убыванию суммы:");
            PrintJaggedArray(sortedNumbers);
        }

        private static void PrintJaggedArray(int[][] array)
        {
            foreach (var row in array)
            {
                int rowSum = row.Sum();
                Console.WriteLine($"{string.Join(", ", row)} \t| Сумма: {rowSum}");
            }

            Console.ReadKey();
        }
    }
}
