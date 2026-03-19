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
            Employee[] staff =
            [
            new Manager("Роман", 23, 220000),
            new Developer("Артур", 22, 7000),
            new Developer("Егор", 21, 190000),
            new Manager("Ярослав", 21, 140000)
            ];

            Company myCompany = new Company(staff);

            Console.WriteLine("Список сотрудников компании:");
            myCompany.ShowAllEmployees();

            var boss = myCompany.GetHighestPaidEmployee();
            Console.WriteLine($"\nСамая высокая зарплата: {boss.Name} ({boss.Salary:C0})");

            double avgAge = myCompany.GetAverageAge();
            Console.WriteLine($"Средний возраст коллектива: {avgAge:F1} лет");

            Console.ReadKey();
        }
    }
}
