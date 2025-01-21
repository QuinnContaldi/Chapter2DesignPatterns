namespace ObservableDesignPattern;

public class Squad : IObserver
{
    List<Soldier> soldiers = new List<Soldier>();
    public string name { get; set; }
    public string company { get; set; }
    public int Size { get; set; }
    
    public Squad(string name, string company, int Size)
    {
        this.name = name;
        this.company = company;
        this.Size = Size;
    }
    
    public void AddSoldier(Soldier soldier)
    {
        soldiers.Add(soldier);
    }
    public void update(string Order)
    {
        foreach (var soldier in soldiers)
        {
            soldier.Order = Order;            
        }
        Console.WriteLine($"{name} of {company} receiving your order to {Order} \n");
    }

    public void SquadInformation()
    {
        foreach (var soldier in soldiers)
        {
            soldier.DisplayInfo();            
        }
    }

    public void ExecuteOrders()
    {
        Console.WriteLine($"{name} squad of {company} executing orders with {Size} Marines");
        Console.WriteLine("--------------------------------");
        foreach (var soldier in soldiers)
        {
            soldier.Attack();
        }
    }

    public void ChangeAttack(IFire fire)
    {
        foreach (var soldier in soldiers)
        {
            soldier.Gun.Fire = fire;
        }
    }
}