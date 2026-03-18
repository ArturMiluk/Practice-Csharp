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
            int[] numbers = new int[100];
            Random rnd = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(-50, 51);
            }

            Console.WriteLine("Элементы массива:");
            foreach (var x in numbers.Where(n => n < 0)) Console.Write(x + " ");
            foreach (var x in numbers.Where(n => n >= 0)) Console.Write(x + " ");
            Console.WriteLine("\n");

            Array.Sort(numbers);
            Console.WriteLine("бинарного поиска:");
            Console.WriteLine(string.Join(" ", numbers));
            Console.WriteLine();

            Console.Write("Введите число k для поиска: ");
            if (int.TryParse(Console.ReadLine(), out int k))
            {
                int index = BinarySearch(numbers, k);

                if (index != -1)
                    Console.WriteLine($"Число {k} найдено на позиции: {index}");
                else
                    Console.WriteLine($"Число {k} в массиве не найдено.");
            }
            else
            {
                Console.WriteLine("Ошибка: введено не целое число.");
            }

            Console.ReadKey();
        }

        static int BinarySearch(int[] array, int target)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (array[mid] == target)
                    return mid;

                if (array[mid] < target)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            return -1;
        }
    }
}
