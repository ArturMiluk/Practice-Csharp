using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        private static void Main()
        {
            Console.Write("Введите размер квадратной матрицы N (N < 10): ");
            if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0 || n >= 10)
            {
                Console.WriteLine("Ошибка: N должно быть целым числом от 1 до 9.");
                return;
            }

            Console.Write("Введите начало диапазона a: ");
            int a = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Введите конец диапазона b: ");
            int b = int.Parse(Console.ReadLine() ?? "10");

            int[,] matrix = new int[n, n];
            Console.WriteLine("\nИсходная матрица:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = Random.Shared.Next(a, b + 1);
                    Console.Write($"{matrix[i, j],4} ");
                }
                Console.WriteLine();
            }

            Console.Write("\nВведите начало промежутка C: ");
            int c = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Введите конец промежутка D: ");
            int d = int.Parse(Console.ReadLine() ?? "10");

            long product = 1;
            bool found = false;
            foreach (int value in matrix)
            {
                if (value >= c && value <= d)
                {
                    product *= value;
                    found = true;
                }
            }

            if (found)
            {
                Console.WriteLine($"Произведение чисел из промежутка [{c}, {d}]: {product}");
            }
            else
            {
                Console.WriteLine($"В матрице нет чисел принадлежащих промежутку [{c}, {d}].");
            }

            Console.WriteLine("\nСумма элементов каждого столбца:");
            for (int j = 0; j < n; j++)
            {
                int columnSum = 0;
                for (int i = 0; i < n; i++)
                {
                    columnSum += matrix[i, j];
                }
                Console.WriteLine($"Столбец {j + 1}: {columnSum}");
            }

            Console.ReadKey();
        }
    }
}
