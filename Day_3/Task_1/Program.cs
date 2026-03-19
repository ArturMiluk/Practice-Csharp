using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Program
    {
        private static void Main()
        {
            var myCalculator = new Calculator(5, 16);

            Console.WriteLine($"Входные данные: a = {myCalculator.AValue}, b = {myCalculator.BValue}");

            long product = myCalculator.CalculateProduct();
            Console.WriteLine($"Произведение a * b: {product}");

            double result = myCalculator.CalculateExpression();

            if (!double.IsNaN(result))
            {
                Console.WriteLine($"Результат (sqrt(b) / 2a): {result:F4}");
            }
            else
            {
                Console.WriteLine("Ошибка: некорректные входные данные для выражения.");
            }

            Console.ReadKey();
        }
    }
}
