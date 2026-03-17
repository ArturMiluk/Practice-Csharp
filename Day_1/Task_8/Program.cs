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
            Console.Write("Введите целое число N (1 <= N <= 10): ");
            int n = int.Parse(Console.ReadLine());

            int currentSum = 0;

            for (int i = 1; i <= n; i++)
            {
                int term = 2 * i - 1;
                currentSum += term;

                Console.WriteLine($"{i}: сумма = {currentSum} (это {i}^2)");
            }

            Console.ReadKey();
        }
    }
}
