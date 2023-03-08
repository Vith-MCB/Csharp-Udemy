namespace Employees_Bosses_and_Trainees;

public class Employee
{
    public string Name { get; set; }
    public string FirstName { get; set; }
    protected float Salary { get; set; }
    
    //Generic constructor
    
    

    protected bool IsWorking = false;

    public void Work()
    {
        if (!IsWorking)
        {
            IsWorking = true;
            Console.WriteLine("Working!");
        }
        else
        {
            Console.WriteLine("Employee is already working!");
        }
    }

    public void Pause()
    {
        if (IsWorking)
        {
            IsWorking = false;
            Console.WriteLine("Working!");
        }
    }
}