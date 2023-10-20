namespace AbstractClassesChallenge;

public class Sphere : Shape
{
    private double _fourTimesPi = 4 * Math.PI;
    public double Radius { get; set; }

    public Sphere(double radius)
    {
        this.Radius = radius;
        Name = "Sphere";
    }
    public override void GetInfo()
    {
        base.GetInfo();
        Console.WriteLine($"This sphere has a Radius of: {Radius}");
    }

    public override double Volume()
    {
        GetInfo();
        return (_fourTimesPi * Math.Pow(Radius, 3)/3);
    }
    
    //(4 pi * r³)/3
}