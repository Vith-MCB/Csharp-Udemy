namespace Employees_Bosses_and_Trainees;

public class Trainee : Employee
{
    public int WorkingHours { get; set; }
    public int SchoolHours { get; set; }
    
    public Trainee(){}
    
    //Constructor
    public Trainee(string name, double salary, int workingHours, int schoolHours )
    {
        this.Name = name;
        this.FirstName = SplitName(name);
        this.Salary = salary;
        this.WorkingHours = workingHours;
        this.SchoolHours = schoolHours;
    }

    public void Learn()
    {
        Console.WriteLine("Treinee is learning!");
    }

    public override void Work()
    {
        base.Work();
        Console.WriteLine("The treinee will work for {0} hours and go to school for {1} hours", WorkingHours, SchoolHours);
    }
}