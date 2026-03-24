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
            var account = new BankAccount(1000m);

            try
            {
                Console.WriteLine($"Текущий баланс: {account.Balance}");

                Console.WriteLine("Попытка снять 500...");
                account.Withdraw(500m);
                Console.WriteLine($"Успешно. Остаток: {account.Balance}");

                Console.WriteLine("\nПопытка снять 2000...");
                account.Withdraw(2000m);
            }
            catch (InsufficientFundsException ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Общая ошибка: {ex.Message}");
            }

            Console.ReadKey();
        }
    }
}
