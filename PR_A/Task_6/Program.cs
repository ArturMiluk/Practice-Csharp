using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 0.7;

            double y = 20 * Math.Log(Math.Abs(Math.Cos(Math.Exp(x)))) - 2 / Math.Sqrt(Math.Pow(Math.Sin(Math.PI), 3) + Math.Abs(1 - x * x));

            Console.WriteLine($"y = {y}");

            Console.ReadKey();
        }
    }
}