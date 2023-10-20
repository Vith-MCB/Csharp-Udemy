namespace InterfaceDemo2;

public class Chair : Furniture, IDestroyable
{
    public string DestructionSound { get; set; }
    public void Destroy()
    {
        Console.WriteLine($"The {Color} chair was destroyed");
        Console.WriteLine("Playing: {0}", DestructionSound);
        Console.WriteLine("Spawning chair parts");
    }
    
    public Chair(string color, string material)
    {
        DestructionSound = "ChairDestructionSound.mp3";
        this.Color = color;
        this.Material = material;
    }
}