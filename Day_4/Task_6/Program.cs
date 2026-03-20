using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    class Program
    {
        static void Main()
        {
            int[] years = {1900, 2000, 2100, 2025, 2026};

            foreach (var y in years)
            {
                bool result = IsLeapYear(y);
                Console.WriteLine($"Год {y} является високосным - {result}");
            }

            Console.ReadKey();
        }

        static bool IsLeapYear(int y)
        {
            if (y % 400 == 0)
            {
                return true;
            }

            if (y % 100 == 0)
            {
                return false;
            }

            return y % 4 == 0;
        }
    }
}
