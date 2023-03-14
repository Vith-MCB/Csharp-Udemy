namespace InterfaceDemo2;

public class Vehicle
{
    public float Speed { get; set; }
    public string Color { get; set; }
    
    //default constructor
    public Vehicle()
    {
        Speed = 120f;
        Color = "White";
    }

    public Vehicle(float speed, string color)
    {
        this.Speed = speed;
        this.Color = color;
    }
}