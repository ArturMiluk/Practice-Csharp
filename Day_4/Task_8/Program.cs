using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8
{
    class Program
    {
        static void Main()
        {
            double d1 = 3.5;
            double d2 = 2.5;
            CompareNumbers(in d1, in d2, out string res1);
            Console.WriteLine($"Результат сравнения {d1} и {d2}: {res1}");

            int i1 = 4;
            int i2 = 4;
            CompareNumbers(in i1, in i2, out string res2);
            Console.WriteLine($"Результат сравнения {i1} и {i2}: {res2}");

            Console.ReadKey();
        }

        static void CompareNumbers(in double a, in double b, out string result)
        {
            if (a > b)
            {
                result = "больше";
            }
            else if (a < b)
            {
                result = "меньше";
            }
            else
            {
                result = "равно";
            }
        }

        static void CompareNumbers(in int a, in int b, out string result)
        {
            if (a > b)
            {
                result = "больше";
            }
            else if (a < b)
            {
                result = "меньше";
            }
            else
            {
                result = "равно";
            }
        }
    }
}
