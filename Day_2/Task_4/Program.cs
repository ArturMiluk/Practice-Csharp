using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        private static void Main()
        {
            const int employeesCount = 18;
            const int monthsCount = 12;

            int[,] salary = new int[employeesCount, monthsCount];

            for (int i = 0; i < employeesCount; i++)
            {
                for (int j = 0; j < monthsCount; j++)
                {
                    salary[i, j] = Random.Shared.Next(30000, 100001);
                }
            }

            Console.Write("Введите сумму для сравнения годового дохода: ");
            if (!decimal.TryParse(Console.ReadLine(), out decimal limit))
            {
                Console.WriteLine("Ошибка: введено не число.");
                return;
            }

            long firstPersonAnnualIncome = 0;
            for (int month = 0; month < monthsCount; month++)
            {
                firstPersonAnnualIncome += salary[0, month];
            }

            Console.WriteLine($"\nГодовой доход первого сотрудника: {firstPersonAnnualIncome:N0}");

            if (firstPersonAnnualIncome > (long)limit)
            {
                Console.WriteLine($"Результат: доход больше {limit:N0}.");
            }
            else
            {
                Console.WriteLine($"Результат: доход не превышает {limit:N0}.");
            }

            Console.ReadKey();
        }
    }
}
