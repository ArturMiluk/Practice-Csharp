using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main()
        {
            int[] numbers = {10, 15, 22, 33, 45, 12, 7, 8};

            Console.Write("Порядковые номера нечёетных элементов: ");

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    Console.Write((i + 1) + " ");
                }
            }

            Console.ReadKey();
        }
    }
}
