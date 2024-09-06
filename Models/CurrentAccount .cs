using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_System.Models
{
    public class CurrentAccount:Account
    {
        private decimal overdraftLimit;

        public CurrentAccount(string accountNumber, string accountHolderName, decimal balance, decimal overdraftLimit)
            : base(accountNumber, accountHolderName, balance)
        {
            this.overdraftLimit = overdraftLimit;
        }

        public override void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                SetBalance(GetBalance() + amount);
                Console.WriteLine($"Successfully deposited {amount:C} to current account.");
            }
            else
            {
                Console.WriteLine("Invalid deposit amount.");
            }
        }

        public override bool Withdraw(decimal amount)
        {
            if (amount > 0 && GetBalance() + overdraftLimit >= amount)
            {
                SetBalance(GetBalance() - amount);
                Console.WriteLine($"Successfully withdrew {amount:C} from current account.");
                return true;
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount or overdraft limit exceeded.");
                return false;
            }
        }
    }
}
