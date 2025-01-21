namespace ObservableDesignPattern;

public class ExplosiveRounds : IFire
{
    public string AmmunitionType { get; set; } = "Explosive Rounds";

    public void FireGun()
    {
        Console.Write($"{AmmunitionType}!");
    }
}