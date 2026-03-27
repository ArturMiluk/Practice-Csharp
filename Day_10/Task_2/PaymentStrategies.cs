using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class CreditCardPayment : IPaymentStrategy
    {
        public void Pay(double amount)
        {
            Console.WriteLine($"Оплачено {amount} BYN с помощью кредитной карты.");
        }
    }

    public class PayPalPayment : IPaymentStrategy
    {
        public void Pay(double amount)
        {
            Console.WriteLine($"Оплачено {amount} BYN через аккаунт PayPal.");
        }
    }

    public class BitcoinPayment : IPaymentStrategy
    {
        public void Pay(double amount)
        {
            Console.WriteLine($"Оплачено {amount} BYN в эквиваленте Bitcoin.");
        }
    }
}

