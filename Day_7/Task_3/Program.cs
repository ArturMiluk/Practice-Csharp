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
            StringProcessor processor = new StringProcessor();

            // Массив тестовых данных
            string[] testInputs = { "Привет, мир!", "", null, "   " };

            foreach (var test in testInputs)
            {
                try
                {
                    Console.WriteLine($"\nТестирование значения: '{(test ?? "null")}'");
                    processor.ValidateInput(test);
                }
                catch (EmptyStringException ex)
                {
                    Console.WriteLine($"{ex.Message}");
                }
            }

            Console.ReadKey();
        }
    }
}
