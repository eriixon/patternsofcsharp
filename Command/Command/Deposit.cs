using System;

namespace Command
{
    public class Deposit : ITransaction
    {
        public decimal amount { get; }
        public IAccount account { get; private set; }
        public bool Completed { get; set; }

        public Deposit(IAccount account, decimal amount)
        {
           this.amount = amount;
           this.account = account;
        }

        public void Execute()
        {
            account.Balance += amount;
            Console.WriteLine($"Balance: {account.Balance}");
            Completed = true;
        }

        public void Undo()
        {
            if (Completed)
            {
                account.Balance -= amount;
                Console.WriteLine($"Balance: {account.Balance}");
            }
        }

        public ITransaction Clone()
        {
            return new Deposit(account, amount);
        }
    }
}
