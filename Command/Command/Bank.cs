namespace Command
{
    public class Bank
    {
        private Account account;
        private TransactionManager manager;
        public Bank()
        {
            account = new Account();
            manager = new TransactionManager();
        }

        public void Deposit(decimal amount)
        {
            var deposit = new Deposit(account, amount);
            manager.AddTransaction(deposit);
            
        }

        public void Withdraw(decimal amount)
        {
            var withdrawal = new Withdrawal(account, amount);
            manager.AddTransaction(withdrawal);

        }

        public void CancelLastTransaction()
        {
            manager.Undo();
        }

        public void RedoLastTransaction()
        {
            manager.Redo();
        }
    }
}
