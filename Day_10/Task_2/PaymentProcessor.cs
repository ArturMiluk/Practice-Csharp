using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class PaymentProcessor
    {
        private IPaymentStrategy _strategy;

        public void SetPaymentStrategy(IPaymentStrategy strategy)
        {
            _strategy = strategy;
        }

        public void ProcessOrder(double amount)
        {
            if (_strategy == null)
            {
                System.Console.WriteLine("Ошибка: способ оплаты не выбран!");
                return;
            }
            _strategy.Pay(amount);
        }
    }
}

