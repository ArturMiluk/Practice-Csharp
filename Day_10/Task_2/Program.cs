using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            PaymentProcessor processor = new PaymentProcessor();
            double orderSum = 776;

            processor.SetPaymentStrategy(new CreditCardPayment());
            processor.ProcessOrder(orderSum);

            processor.SetPaymentStrategy(new PayPalPayment());
            processor.ProcessOrder(orderSum);

            processor.SetPaymentStrategy(new BitcoinPayment());
            processor.ProcessOrder(orderSum);

            Console.ReadLine();
        }
    }
}
