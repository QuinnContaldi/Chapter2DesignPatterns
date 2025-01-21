namespace ObservableDesignPattern;

public interface ISubject
{
    public void RegistorObserver(IObserver observer);
    public void RemoveObserver(IObserver observer);
    public void NotifyObserver(string Order);
}