using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = -1;

            double y = 7 * Math.Pow(Math.Atan(Math.Sqrt(Math.Exp(x) + 1)), 2) + Math.Abs(x);

            Console.WriteLine($"y = {y}");

            Console.ReadKey();
        }
    }
}