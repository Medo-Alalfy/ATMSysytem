using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_System.Models
{
    public class Account
    {
        private string accountNumber;
        private string accountHolderName;
        private decimal balance;

        // Constructor
        public Account(string accountNumber, string accountHolderName, decimal balance)
        {
            this.accountNumber = accountNumber;
            this.accountHolderName = accountHolderName;
            this.balance = balance;
        }

        // Encapsulation: Public methods for accessing private fields
        public string GetAccountNumber() => accountNumber;
        public string GetAccountHolderName() => accountHolderName;
        public decimal GetBalance() => balance;

        protected void SetBalance(decimal newBalance)
        {
            balance = newBalance;
        }

        // Abstract methods for deposit and withdrawal
        public abstract void Deposit(decimal amount);
        public abstract bool Withdraw(decimal amount);
    }
}

