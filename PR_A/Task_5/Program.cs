using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 776;

            string reversedNumber = number.ToString();
            char[] chars = reversedNumber.ToCharArray();
            Array.Reverse(chars);

            Console.WriteLine(new string(chars));

            Console.ReadKey();
        }
    }
}