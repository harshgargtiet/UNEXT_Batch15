using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class BankAccount
    {
        private decimal balance;
        private string accountNumber;

        public BankAccount(string accountNumber, decimal initialBalance)
        {
            this.accountNumber = accountNumber;
            this.balance = initialBalance;
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException(MyExceptions.ExceptionMessages[1]);
            }

            balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException(MyExceptions.ExceptionMessages[2]);
            }

            if (balance < amount)
            {
                throw new Exception(MyExceptions.ExceptionMessages[1]);
            }

            balance -= amount;
        }

        public decimal GetBalance()
        {
            return balance;
        }

        public string GetAccountNumber()
        {
            return accountNumber;
        }
    }
}
