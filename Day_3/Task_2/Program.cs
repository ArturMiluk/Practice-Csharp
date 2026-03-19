using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Program
    {
        private static void Main()
        {
            Person[] group = PersonProcessor.GenerateData(10);

            Console.WriteLine("Весь список людей:");
            foreach (var person in group)
            {
                Console.WriteLine(person);
            }

            Person[] seniors = PersonProcessor.FilterByAge(group);

            Console.WriteLine("\nЛюди старше 30 лет:");
            if (seniors.Length > 0)
            {
                foreach (var person in seniors)
                {
                    Console.WriteLine(person);
                }
            }
            else
            {
                Console.WriteLine("Таких людей не найдено.");
            }

            double avg = PersonProcessor.CalculateAverageAge(group);
            Console.WriteLine($"\nСредний возраст в группе: {avg:F1}");

            Console.ReadKey();
        }
    }
}
