using ATM_System.Models;

namespace ATM_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SavingsAccount savings = new SavingsAccount("123456", "John Doe", 1000, 0.05m);
            CurrentAccount current = new CurrentAccount("789101", "Jane Smith", 500, 200);

            // Create ATM
            ATM atm = new ATM();

            // Simulate login and transactions
            atm.Login(savings);
            atm.DepositMoney(200);
            atm.CheckBalance();
            atm.WithdrawMoney(100);
            atm.CheckBalance();

            Console.WriteLine("\nSwitching to another account...\n");

            atm.Login(current);
            atm.DepositMoney(300);
            atm.CheckBalance();
            atm.WithdrawMoney(700); // overdraft case
            atm.CheckBalance();
        }
    }
}
