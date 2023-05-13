namespace PolymorphismChallange;

//Sealed key implies that this class can't be inherit
sealed class Audi : Car
{
    public int HP { get; set; }
    public string Color { get; set; }
  
    public string Model { get; set; }

    private string brand = "AUDI";
  
    //Constructor
    public Audi(int hp, string color, string model) : base(hp,color)
    {
        this.Model = model;
    }
  
    public override void ShowDetails()
    {
        Console.WriteLine("Car HP: {0}| Car color: {1} | Car Model: {2} | Brand: {3}", HP, Color, Model, brand);
    }

    public override void Repair()
    {
        Console.WriteLine("Audi was repaired!");
    }
}
