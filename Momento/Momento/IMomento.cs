namespace Momento
{
    public interface IMomento<T>
    {
        T GetState();
        void SetState(T state);
    }
}
