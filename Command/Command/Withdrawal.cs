using System;

namespace Command
{
    public class Withdrawal : ITransaction
    {
        public decimal amount { get; }
        public IAccount account { get; private set; }
        public bool Completed { get; set; }

        public Withdrawal(IAccount account, decimal amount)
        {
            this.amount = amount;
            this.account = account;
        }

        public void Execute()
        {
            account.Balance -= amount;
            Console.WriteLine($"Balance: {account.Balance}");
            Completed = true;
        }

        public void Undo()
        {
            if (Completed)
            {
                account.Balance += amount;
                Console.WriteLine($"Balance: {account.Balance}");
            }
        }

        public ITransaction Clone()
        {
            return new Withdrawal(account, amount);
        }
    }
}
