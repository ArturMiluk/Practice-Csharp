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
            Console.WriteLine("Введите x: ");
            double x = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите y: ");
            double y = double.Parse(Console.ReadLine());

            bool result = (x > 0 && y > 0) || (x < 0 && y < 0);

            Console.WriteLine($"Точка лежит в первой или третьей четверти: {result}");

            Console.ReadKey();
        }
    }
}