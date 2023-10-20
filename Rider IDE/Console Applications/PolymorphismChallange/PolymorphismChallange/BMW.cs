namespace PolymorphismChallange;
public class BMW : Car
{
    public int HP { get; set; }
    public string Color { get; set; }
    public string Model { get; set; }

    private string brand = "BMW";
  
    //Constructor
    public BMW(int hp, string color, string model) : base(hp,color)
    {
        this.Model = model;
    }
  
    public override void ShowDetails()
    {
        Console.WriteLine("Car HP: {0}| Car color: {1} | Car Model: {2} | Brand: {3}", HP, Color, Model, brand);
    }
  
    //Sealed key implies that this method can't be override by classes that inherit from BMW class 
    public sealed override void Repair()
    {
        Console.WriteLine("BMW was repaired!");
    }
}