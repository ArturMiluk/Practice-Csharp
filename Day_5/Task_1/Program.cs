using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main()
        {
            Shape[] shapes =
            {
                new Circle(5),
                new Rectangle(4, 6),
                new Triangle(3, 4, 5)
            };

            Console.WriteLine("Площади фигур в массиве:");

            foreach (var shape in shapes)
            {
                var area = shape.GetArea();
                var typeName = shape.GetType().Name;
                Console.WriteLine($"Фигура: {typeName,-10} | Площадь: {area:F2}");
            }

            Console.ReadKey();
        }
    }
}
