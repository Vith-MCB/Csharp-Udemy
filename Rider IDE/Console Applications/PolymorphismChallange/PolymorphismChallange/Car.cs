namespace PolymorphismChallange;

public class Car
{
    #region Has a Relationship
    protected CarIDInfo carIdInfo = new CarIDInfo();

    public void SetCarIDInfo(int idNum, string owner)
    {
        carIdInfo.IDNum = idNum;
        carIdInfo.Owner = owner;
    }

    public void GetIDInfo()
    {
        Console.WriteLine("The car has the ID of {0} and is owned by {1}.", carIdInfo.IDNum, carIdInfo.Owner);
    }

    #endregion Has a ralationship
    
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