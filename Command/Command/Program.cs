using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            var bank = new Bank();
            bank.Deposit(50);
            bank.Withdraw(30);
            Console.WriteLine("******");
            bank.CancelLastTransaction();
            Console.WriteLine("///////");
            bank.RedoLastTransaction();
        }
    }
}
