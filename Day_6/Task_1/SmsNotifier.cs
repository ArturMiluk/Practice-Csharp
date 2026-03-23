using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class SmsNotifier
    {
        public void SendSms(string message)
        {
            Console.WriteLine($"SMS - Отправка сообщения: {message}");
        }
    }
}

