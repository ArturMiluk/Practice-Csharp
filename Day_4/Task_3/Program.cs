using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main()
        {
            string[] tests = {"racecar"};

            foreach (var word in tests)
            {
                var cleanWord = word.Replace(" ", "").ToLower();
                var result = IsPalindrome(cleanWord);

                Console.WriteLine($"\"{word}\" — {result}");
            }

            Console.ReadKey();
        }

        static bool IsPalindrome(string text)
        {
            if (text.Length <= 1)
            {
                return true;
            }

            if (text[0] != text[text.Length - 1])
            {
                return false;
            }

            return IsPalindrome(text.Substring(1, text.Length - 2));
        }
    }
}
