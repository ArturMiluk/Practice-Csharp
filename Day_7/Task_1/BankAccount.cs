using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class BankAccount
    {
        public decimal Balance {get; private set;}

        public BankAccount(decimal initialBalance)
        {
            Balance = initialBalance;
        }

        public void Withdraw(decimal amount)
        {
            if (amount > Balance)
            {
                throw new InsufficientFundsException($"Ошибка: Попытка снять {amount}, текущий баланс: {Balance}.");
            }

            Balance -= amount;
        }
    }
}

