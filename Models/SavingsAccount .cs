namespace ATM_System.Models
{
    public class SavingsAccount : Account
    {
        private decimal interestRate;

        public SavingsAccount(string accountNumber, string accountHolderName, decimal balance, decimal interestRate)
            : base(accountNumber, accountHolderName, balance)
        {
            this.interestRate = interestRate;
        }

        public override void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                SetBalance(GetBalance() + amount);
                Console.WriteLine($"Successfully deposited {amount:C} to savings account.");
            }
            else
            {
                Console.WriteLine("Invalid deposit amount.");
            }
        }

        public override bool Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= GetBalance())
            {
                SetBalance(GetBalance() - amount);
                Console.WriteLine($"Successfully withdrew {amount:C} from savings account.");
                return true;
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount or insufficient funds.");
                return false;
            }
        }

        public void ApplyInterest()
        {
            decimal interest = GetBalance() * interestRate;
            SetBalance(GetBalance() + interest);
            Console.WriteLine($"Interest of {interest:C} applied to savings account.");
        }
    }
}
