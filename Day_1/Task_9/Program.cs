using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Task_9
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

            double A = Math.PI / 3;
            double B = 2 * Math.PI / 3;
            int M = 20;

            double H = (B - A) / M;
            double x = A;

            Console.WriteLine($"Табулирование функции Cos(x) на отрезке [{A:f4}, {B:f4}]\n");

            for (int i = 1; i <= M; i++)
            {
                double y = Math.Cos(x);

                Console.WriteLine("{0,-5} | {1,-10:F4} | {2,-10:f4}", i, x, y);

                x = x + H;
            }

            Console.ReadKey();
        }
    }
}
