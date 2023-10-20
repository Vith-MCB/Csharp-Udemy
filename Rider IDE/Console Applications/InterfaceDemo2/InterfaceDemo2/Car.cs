namespace InterfaceDemo2;

public class Car : Vehicle, IDestroyable
{
    public string DestructionSound { get; set; }

    //Creating a new property to store the destroyable objects nearby
    public List<IDestroyable> DestroyablesNearby;
    
    public Car(float speed, string color) : base(speed, color)
    {
        this.Speed = speed;
        this.Color = color;
        DestructionSound = "CarExplosionSound.mp3";
        DestroyablesNearby = new List<IDestroyable>();
    }
    
    public void Destroy()
    {
        Console.WriteLine("Playing destruction sound {0}", DestructionSound);
        Console.WriteLine("Create fire!");
        foreach (IDestroyable destroyable in DestroyablesNearby)
        {
            destroyable.Destroy();
        }
    }
}