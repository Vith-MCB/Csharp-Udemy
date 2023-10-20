namespace Employees_Bosses_and_Trainees;

public class Boss : Employee
{
    public int WorkingHours { get; set; }
    
    protected bool UsesCompanyCar { get; set; }
    
    public Boss(){}

    public Boss(string name, double salary, int workingHours, bool usesCompanyCar)
    {
        this.Name = name;
        this.FirstName = SplitName(name);
        this.Salary = salary;
        this.WorkingHours = workingHours;
        this.UsesCompanyCar = usesCompanyCar;
    }

    public void GoHome()
    {
        if (UsesCompanyCar)
        {
            Console.WriteLine("Going home like a boss!");
        }
        else
        {
            Console.WriteLine("Is boss on the bus?");
        }
    }
    
    public override void Work()
    {
        base.Work();
        Console.WriteLine("Boss will work for {0} hours!", WorkingHours);
    }

    public void Lead()
    {
        Console.WriteLine("Leading the group!");
    }
    
}