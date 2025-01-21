namespace ObservableDesignPattern;

public abstract class Gun
{
    public string name { get; set;}
    public IFire Fire;
    
    public abstract void GunName();
    public abstract void FireGun();
}