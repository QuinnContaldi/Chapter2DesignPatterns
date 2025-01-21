namespace ObservableDesignPattern;

public class ArmorPiercingRounds : IFire
{
    public string AmmunitionType { get; set; } = "Armor Piercing Rounds";

    public void FireGun()
    {
        Console.Write($"{AmmunitionType}!");
    }
}