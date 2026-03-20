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
            var word = "шалаш";
            var result = StringHelper.IsPalindrome(word);

            Console.WriteLine($"'{word}' - {result}");

            Console.ReadKey();
        }
    }
}

