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
            Console.WriteLine("{0,-10} | {1,-10}", "Фунты", "Килограммы");

            double kgPerPound = 0.453;

            for (int lbs = 1; lbs <= 100; lbs++)
            {
                double kg = lbs * kgPerPound;

                Console.WriteLine("{0,-10} | {1,-10:f3}", lbs, kg);
            }

            Console.ReadKey();
        }
    }
}
