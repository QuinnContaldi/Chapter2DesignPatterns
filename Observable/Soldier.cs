namespace ObservableDesignPattern;
public abstract class Soldier
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }
    public string CombatID { get; set; }
    public string Rank { get; set; }
    public string Position { get; set; }
    public string Status { get; set; }
    public string Order { get; set; }
    
    public Gun Gun { get; set; }

    public Soldier(string name, int age, string gender, string combatID, string rank, string position, Gun gun)
    {
        Name = name;
        Age = age;
        Gender = gender;
        CombatID = combatID;
        Rank = rank;
        Position = position;
        Status = "Healthy";
        Order = "Error Commander Not assigned";
        Gun = gun;
    }

    // Abstract method to enforce subclass implementation of unique info if needed
    public abstract void DisplayInfo();

    // Common method for all soldiers to perform an attack
    public virtual void Attack()
    {
        Console.Write($"{Name} is attacking with ");
        Gun.FireGun();
    }


}
