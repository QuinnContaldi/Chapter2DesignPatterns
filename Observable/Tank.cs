using System.Runtime.CompilerServices;

namespace ObservableDesignPattern;

public class Tank : IObserver
{
    public string Name { get; set; }
    public string Order { get; set; }
    public string Status { get; set; }
    public string Type { get; set; }
    public string AmmoCounter { get; set; }
    public string ArmorType { get; set; }

    public Tank(string name, string status, string type, string ammoCounter, string armorType)
    {
        this.Name = name;
        this.Order = "Error Commander Not assigned";
        this.Status = status;
        this.Type = type;
        this.AmmoCounter = ammoCounter;
        this.ArmorType = armorType;
    }
    public void update(string Order)
    {
        this.Order = Order;
    }

    public void ExecuteOrder()
    {
        Console.WriteLine($"{Name} is executing order {Order}");
    }
}