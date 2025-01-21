namespace ObservableDesignPattern;

public class Shotgun : Gun
{
    public Shotgun(string name, IFire fire)
    {
        this.name = name;
        this.Fire = fire;
    }

    public override void GunName()
    {
        Console.WriteLine("My current gun is " + name);
    }

    public override void FireGun()
    {
        Console.Write($"{name} which fires ");
        Fire.FireGun();
        Console.WriteLine(" ");
    }
}