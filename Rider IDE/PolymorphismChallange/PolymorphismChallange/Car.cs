namespace PolymorphismChallange;

public class Car
{
    public int HP { get; set; }
    public string Color { get; set; }
    
    // default constructor
    protected Car()
    {
    }
    
    public Car(int hp, string color)
    {
        this.HP = hp;
        this.Color = color;
    }


    public virtual void ShowDetails()
    {
        Console.WriteLine("Car HP: {0}| Car color: {1}", HP, Color);
    }

    public virtual void Repair()
    {
        Console.WriteLine("Car was repaired!");
    }
}