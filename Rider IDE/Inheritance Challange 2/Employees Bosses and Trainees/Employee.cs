namespace Employees_Bosses_and_Trainees;

public class Employee
{
    public string Name { get; set; }
    public string FirstName { get; set; }
    protected double Salary { get; set; }
    
    //Generic constructor
    public Employee(){}
    
    //Constructor
    public Employee(string name, double salary)
    {
        this.Name = name;
        this.FirstName = SplitName(name);
        this.Salary = salary;
    }

    public string SplitName(string name)
    {
        string[] splitedName;
        splitedName = name.Split(" ");
        return splitedName[0];
    }

    public bool IsWorking = false;

    public virtual void Work()
    {
        if (!IsWorking)
        {
            IsWorking = true;
            Console.WriteLine("({0}) is Working!", FirstName);
        }
        else
        {
            Console.WriteLine("Employee ({0}) is already working!", FirstName);
        }
    }

    public void Pause()
    {
        if (IsWorking)
        {
            IsWorking = false;
            Console.WriteLine("({0}) Stoped working!", FirstName);
        }
        else
        {
            Console.WriteLine("Employee ({0}) is not working!", FirstName);
        }
    }
}