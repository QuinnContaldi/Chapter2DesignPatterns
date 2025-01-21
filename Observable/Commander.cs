namespace ObservableDesignPattern;

public class Commander
{
    List<IObserver> observers = new List<IObserver>();
    public void RegistorObserver(IObserver observer)
    {
        observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        observers.Remove(observer);
    }

    public void NotifyObserver(string Order)
    {
        foreach (var observer in observers)
        {
            observer.update(Order); 
        }
    }


}