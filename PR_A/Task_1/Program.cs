using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус основания (см): ");
            double radius = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите высоту цилиндра (см): ");
            double height = double.Parse(Console.ReadLine());

            double surfaceArea = 2 * Math.PI * radius * (radius + height);

            Console.WriteLine($"Площадь поверхности круга = {surfaceArea}");

            Console.ReadKey();
        }
    }
}