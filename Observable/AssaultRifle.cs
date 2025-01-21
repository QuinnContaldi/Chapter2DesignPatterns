namespace ObservableDesignPattern;

public class AssaultRifle: Gun
{
    public AssaultRifle(string name, IFire fire)
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