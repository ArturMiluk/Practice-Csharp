using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите возраст: ");
            int age = int.Parse(Console.ReadLine());

            string category;

            if (age < 1)
            {
                category = "младенец";
            }
            else if (age >= 1 && age <= 11)
            {
                category = "ребёнок";
            }
            else if (age >= 12 && age <= 15)
            {
                category = "подросток";
            }
            else if (age >= 16 && age <= 25)
            {
                category = "юноша";
            }
            else if (age >= 26 && age <= 70)
            {
                category = "мужчина";
            }
            else
            {
                category = "старик";
            }

            Console.WriteLine($"Возрастная категория: {category}");

            Console.ReadKey();
        }
    }
}
