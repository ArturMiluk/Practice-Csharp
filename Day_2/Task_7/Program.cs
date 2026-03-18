using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7
{
    class Program
    {
        private static void Main()
        {
            Console.Write("Введите основную строку: ");
            string mainString = Console.ReadLine();

            Console.Write("Введите подстроку для поиска: ");
            string subString = Console.ReadLine();

            int foundIndex = FindFirstOccurrence(mainString, subString);

            if (foundIndex != -1)
            {
                Console.WriteLine($"Подстрока найдена. Индекс первого вхождения: {foundIndex}");
            }
            else
            {
                Console.WriteLine("Подстрока не найдена.");
            }

            Console.ReadKey();
        }

        private static int FindFirstOccurrence(string text, string sub)
        {
            if (sub.Length > text.Length)
            {
                return -1;
            }

            for (int i = 0; i <= text.Length - sub.Length; i++)
            {
                bool isMatch = true;

                for (int j = 0; j < sub.Length; j++)
                {
                    if (text[i + j] != sub[j])
                    {
                        isMatch = false;
                        break;
                    }
                }

                if (isMatch)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
