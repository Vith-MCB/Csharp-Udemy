namespace AbstractClassesChallenge;

public class Cube : Shape
{
    public double Lenght { get; set; }

    public Cube(double lenght)
    {
        this.Lenght = lenght;
        Name = "Cube";
    }
    public override void GetInfo()
    {
        base.GetInfo();
        Console.WriteLine($"This cube has a Lenght of: {Lenght}");
    }

    public override double Volume()
    {
        GetInfo();
        return Math.Pow(Lenght, 3);
    }
}