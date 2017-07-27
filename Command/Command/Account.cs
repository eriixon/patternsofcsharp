namespace Command
{
    public class Account: IAccount
    {
        public decimal Balance { get; set; }
        public Account(decimal balance)
        {
            Balance = balance;
        }
        public Account(): this(0)
        {
        }
    }
}
