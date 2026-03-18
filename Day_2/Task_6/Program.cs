using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    class Program
    {
        private static void Main()
        {
            Console.Write("Введите строку для поиска: ");
            string input = Console.ReadLine() ?? string.Empty;

            char longestChar = input[0];
            int maxCount = 1;

            char currentChar = input[0];
            int currentCount = 1;

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] == currentChar)
                {
                    currentCount++;
                }
                else
                {
                    if (currentCount > maxCount)
                    {
                        maxCount = currentCount;
                        longestChar = currentChar;
                    }

                    currentChar = input[i];
                    currentCount = 1;
                }
            }

            if (currentCount > maxCount)
            {
                maxCount = currentCount;
                longestChar = currentChar;
            }

            Console.WriteLine($"\nСамая длинная последовательность: '{new string(longestChar, maxCount)}'");
            Console.WriteLine($"Символ: '{longestChar}', Длина: {maxCount}");

            Console.ReadKey();
        }
    }
}
