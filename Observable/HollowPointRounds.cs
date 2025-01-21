namespace ObservableDesignPattern;

public class HollowPointRounds: IFire
{
    public string AmmunitionType { get; set; } = "Hollow Point Rounds";

    public void FireGun()
    {
        Console.WriteLine($"{AmmunitionType}!");
    }
}