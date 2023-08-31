namespace DesignPatterns.Observer
{
    public interface ISubject
    {
        void AttachObserver(IObserver observer);
        void DettachObserver(IObserver observer);
        void Notify();
    }
}
