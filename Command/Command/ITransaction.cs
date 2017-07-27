namespace Command
{
    public interface ITransaction: IPrototype<ITransaction>
    {
        IAccount account { get; }
        decimal amount { get; }
        void Execute();
        void Undo();
        bool Completed { get; set; }
    }
}
