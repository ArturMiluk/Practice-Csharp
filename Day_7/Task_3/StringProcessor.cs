using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class StringProcessor
    {
        public void ValidateInput(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                throw new EmptyStringException("Ошибка: Передана пустая строка или null в метод ValidateInput.");
            }

            Console.WriteLine($"Ввод успешно прошел валидацию: '{input}'");
        }
    }
}

