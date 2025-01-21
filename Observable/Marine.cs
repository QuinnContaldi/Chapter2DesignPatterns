namespace ObservableDesignPattern;

public class Marine: Soldier
{
    public string SoldierType = "Marine";
    public Marine(string name, int age, string gender, string combatID, string rank, string position, Gun gun)
        : base(name, age, gender, combatID, rank, position, gun)
    {
        //Custom logic if you want!
    }

    public override void DisplayInfo()
    {
        Console.WriteLine(
            $"Branch: {SoldierType} \n" +
            $"Marine: {Name} \n" +
            $"Age: {Age} \n" +
            $"Gender: {Gender} \n" +
            $"CombatID: {CombatID} \n" +
            $"Rank: {Rank} \n" +
            $"Position: {Position} \n" +
            $"Status: {Status} \n" +
            $"Order: {Order} \n" +
            $"Gun:"  + Gun.name + "\n" 
        );
    }
    
}