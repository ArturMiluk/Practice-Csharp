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
            var emailNotifier = new EmailNotifier();
            var smsNotifier = new SmsNotifier();

            NotificationHandler handler = emailNotifier.SendEmail;

            handler += smsNotifier.SendSms;

            Console.WriteLine("Запуск рассылки через делегат:");
            handler("Ваш заказ успешно оформлен.");

            Console.ReadKey();
        }
    }
}
