using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class EmailNotifier
    {
        public void SendEmail(string message)
        {
            Console.WriteLine($"Email - Отправка сообщения: {message}");
        }
    }
}

