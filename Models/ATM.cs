using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_System.Models
{
    public class ATM
    {
        private Account currentAccount;

        // ATM login for selecting the account
        public void Login(Account account)
        {
            currentAccount = account;
            Console.WriteLine($"Logged in as {account.GetAccountHolderName()}.");
        }

        // Deposit money into the account
        public void DepositMoney(decimal amount)
        {
            if (currentAccount != null)
            {
                currentAccount.Deposit(amount);
            }
            else
            {
                Console.WriteLine("Please log in to an account first.");
            }
        }

        // Withdraw money from the account
        public void WithdrawMoney(decimal amount)
        {
            if (currentAccount != null)
            {
                currentAccount.Withdraw(amount);
            }
            else
            {
                Console.WriteLine("Please log in to an account first.");
            }
        }

        // Check balance of the account
        public void CheckBalance()
        {
            if (currentAccount != null)
            {
                Console.WriteLine($"Your current balance is {currentAccount.GetBalance():C}.");
            }
            else
            {
                Console.WriteLine("Please log in to an account first.");
            }
        }
    }
}
