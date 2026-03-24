using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main()
        {
            DatabaseManager manager = new DatabaseManager();

            try
            {
                manager.Initialize("InvalidConfig");
            }
            catch (DatabaseConnectionException ex)
            {
                Console.WriteLine($"Сообщение: {ex.Message}");

                if (ex.InnerException != null)
                {
                    Console.WriteLine($"Первопричина: {ex.InnerException.Message}");
                    Console.WriteLine($"Тип первопричины: {ex.InnerException.GetType().Name}");
                }
                Console.WriteLine("\nСтек вызовов:");
                Console.WriteLine(ex.StackTrace);
            }

            Console.ReadKey();
        }
    }
}
