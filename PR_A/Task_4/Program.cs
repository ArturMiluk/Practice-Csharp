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
            Console.WriteLine("Введите первое целое число: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе целое число: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите третье целое число: ");
            int c = int.Parse(Console.ReadLine());

            int sum = a + b + c;

            Console.WriteLine($"{a} + {b} + {c} = {sum}");

            Console.ReadKey();
        }
    }
}