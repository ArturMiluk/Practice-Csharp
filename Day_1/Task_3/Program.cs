using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите A: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите B: ");
            int b = int.Parse(Console.ReadLine());

            int count = 0;

            for (int i = b - 1; i > a; i--)
            {
                Console.WriteLine(i + " ");
                count++;
            }

            Console.WriteLine($"\nКоличество N чисел: {count}");

            Console.ReadKey();
        }
    }
}