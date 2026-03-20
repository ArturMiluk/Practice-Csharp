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
            double[] side = {5.0};

            foreach (var a in side)
            {
                TrianglePS(a, out var p, out var s);

                Console.WriteLine($"Треугольник со стороной a = {a}:");
                Console.WriteLine($"Периметр P = {p:F2}");
                Console.WriteLine($"Площадь S = {s:F2}");
            }

            Console.ReadKey();
        }

        static void TrianglePS(double a, out double p, out double s)
        {
            p = 3 * a;
            s = Math.Sqrt(3) / 4 * Math.Pow(a, 2);
        }
    }
}
