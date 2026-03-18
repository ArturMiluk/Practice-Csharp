using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8
{
    class Program
    {
        private static void Main()
        {
            Console.Write("Введите строку (например, CamelCaseText): ");
            string input = Console.ReadLine(); 

            string result = ConvertToSnakeCase(input);

            Console.WriteLine($"Результат в snake_case: {result}");

            Console.ReadKey();
        }

        private static string ConvertToSnakeCase(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return text;
            }

            var sb = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                char currentChar = text[i];

                if (char.IsUpper(currentChar))
                {
                    if (i > 0)
                    {
                        sb.Append('_');
                    }

                    sb.Append(char.ToLower(currentChar));
                }
                else
                {
                    sb.Append(currentChar);
                }
            }

            return sb.ToString();
        }
    }
}
