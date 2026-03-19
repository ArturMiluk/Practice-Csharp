using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public static class PersonProcessor
    {
        public static Person[] FilterByAge(Person[] people)
        {
            return people.Where(p => p.Age > 30).ToArray();
        }

        public static Person[] GenerateData(int count)
        {
            string[] names = { "Роман", "Артур", "Егор", "Мирослав", "Артём", "Ярослав" };
            var result = new Person[count];

            for (int i = 0; i < count; i++)
            {
                string randomName = names[Random.Shared.Next(names.Length)];
                int randomAge = Random.Shared.Next(18, 60);
                result[i] = new Person(randomName, randomAge);
            }

            return result;
        }

        public static double CalculateAverageAge(Person[] people)
        {
            if (people.Length == 0) return 0;
            return people.Average(p => p.Age);
        }
    }
}


