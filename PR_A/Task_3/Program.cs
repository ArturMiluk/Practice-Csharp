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
            Console.WriteLine("Введите значение альфа (градусы): ");
            double alphaDegrees = double.Parse(Console.ReadLine());

            double alpha = alphaDegrees * Math.PI / 180;

            double  z1 = (Math.Sin(4 * alpha) / (1 + Math.Cos(4 * alpha))) * (Math.Cos(2 * alpha) / (1 + Math.Cos(2 * alpha)));

            Console.WriteLine($"z1 = {z1}");
                    
            Console.ReadKey();
        }
    }
}