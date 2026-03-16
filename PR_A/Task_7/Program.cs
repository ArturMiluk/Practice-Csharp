using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину окружности: ");
            double lenth = double.Parse(Console.ReadLine());
            
            double square = Math.Pow(lenth, 2) / (4 * Math.PI);

            Console.WriteLine($"Площадь круга = {square}");
            
            Console.ReadKey();
        }
    }
}