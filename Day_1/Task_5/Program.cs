using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите целое число: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 != 0)
            {
                Console.WriteLine($"Число {number} - нечётное.");
            }
            else
            {
                Console.WriteLine($"Число {number} - чётное.");
            }

            Console.ReadKey();
        }
    }
}
