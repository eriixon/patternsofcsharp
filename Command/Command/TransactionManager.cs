using System.Collections.Generic;

namespace Command
{
    public class TransactionManager
    {
        private Stack<ITransaction> transactions;
        public TransactionManager()
        {
            transactions = new Stack<ITransaction>();
        }

        public void AddTransaction(ITransaction transaction)
        {
            transactions.Push(transaction);
            transaction.Execute();
        }

        public void Undo()
        {
            var lastTransaction = transactions.Pop();
            lastTransaction.Undo();
        }

        public void Redo()
        {
            var lastTrans = transactions.Peek();
            AddTransaction(lastTrans.Clone());

            //if (lastTrans is Deposit)
            //{
            //    var newTrans = new Deposit(lastTrans.Account, lastTrans.Amount);
            //    AddTransaction(newTrans);
            //}
            //if (lastTrans is Withdrawal)
            //{
            //    var newTrans = new Withdrawal(lastTrans.Account, lastTrans.Amount);
            //    AddTransaction(newTrans);
            //}
        }
    }
}
