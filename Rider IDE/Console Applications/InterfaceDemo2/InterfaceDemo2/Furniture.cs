namespace InterfaceDemo2;

public class Furniture
{
    public string Color { get; set; }
    public string Material { get; set; }

    //Default Constructor
    public Furniture()
    {
        Color = "White";
        Material = "Wood";
    }

    public Furniture(string color, string material)
    {
        this.Color = color;
        this.Material = material;
    }
}