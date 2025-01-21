namespace ObservableDesignPattern;

public class SpecOps : Soldier
{
    public string SoldierType = "Classified";
    public string Designation;
    // Constructor for SpecOps, calling the base constructor
    public SpecOps(string name, int age, string gender, string combatID, string rank, string position, Gun gun, string designation )
        : base(name, age, gender, combatID, rank, position, gun)
    {
        // We have some custom logic here! that is specific to SpecOps class OOP is super cool! we extended our parameterized constructor. 
        this.Designation = designation;
    }

    // Override the DisplayInfo method to include SpecOps-specific details
    public override void DisplayInfo()
    {
        Console.WriteLine(
            $"Branch: {SoldierType} \n" +
            $"{Designation} \n " + 
            $"Name: {Name} \n" +
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
    public override void Attack()
    {
        Gun.FireGun();
    }
    
}