using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class DatabaseConnectors
    {
        public void Connect(string connectionString)
        {
            if (string.IsNullOrEmpty(connectionString) || !connectionString.Contains("Server"))
            {
                throw new SqlException("Сетевая ошибка - cервер базы данных не найден.");
            }
            Console.WriteLine("Подключение установлено.");
        }
    }
}

