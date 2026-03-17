using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Task_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Числа, сумма квадратов цифр которых кратна 13:\n");

            for (int i = 10; i <= 99; i++)
            {
                int d1 = i / 10;
                int d2 = i % 10;

                int sumSquares = (d1 * d1) + (d2 * d2);

                if (sumSquares % 13 == 0)
                {
                    Console.WriteLine($"{i} ({d1}^2 + {d2}^2 = {sumSquares})");
                }
            }

            Console.ReadKey();
        }
    }
}
