using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Введите значение x: ");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double part1, part2, y;

            if (x < 1.3)
            {
                if (Math.Abs(x) < 1e-10)
                {
                    Console.WriteLine("Ошибка: деление на ноль.");
                }
                else
                {
                    part1 = Math.PI * Math.Pow(x, 2);
                    part2 = 7 / Math.Sqrt(Math.Abs(x));
                    y = part1 - part2;

                    Console.WriteLine($"Промежуточные значения: {part1:f4}, {part2:f4}");
                    Console.WriteLine($"Итоговое y = {y:f4}");
                }
            }
            else if (Math.Abs(x - 1.3) < 0.0001)
            {
                part1 = 3 * x;
                part2 = Math.Pow(Math.Cos(x), 2);
                y = part1 - part2;

                Console.WriteLine($"Промежуточные значения: {part1:f4}, {part2:f4}");
                Console.WriteLine($"Итоговое y = {y:f4}");
            }
            else
            {
                Console.WriteLine("Для (x > 1.3) функция не задана.");
            }

            Console.ReadKey();
        }
    }
}
