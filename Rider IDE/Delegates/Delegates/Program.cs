/*Using Delegates

List<string> names = new List<string>() {"Aiden", "Sif", "Walter", "Anatoli", "Ion"};

Console.WriteLine("----Before the Delegate----");
foreach (string name in names)
{
    Console.WriteLine(name);
}

names.RemoveAll(Filter);

static bool Filter(string str)
{
    //Return whether the string 'str' contains the letter 'i'
    //The '.Contains' method will return a bool which will be return
    string filterStr = "i";
    return str.ToLower().Contains(filterStr);

}

Console.WriteLine("----After the Delegate----");
foreach (string name in names)
{
    Console.WriteLine(name);
}
*/

//Creating Delegates

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}


public delegate bool FilterDelegate(Person p);

internal class Program
{
    public static void Main(string[] args)
    {
        Person p1 = new Person() {Name = "Vitor", Age = 21};
        Person p2 = new Person() {Name = "Luiz Pobre", Age = 17};
        Person p3 = new Person() {Name = "Luiz Rico", Age = 16};
        Person p4 = new Person() {Name = "Juninho", Age = 14};

        List<Person> people = new List<Person>() {p1,p2,p3,p4};

        Console.WriteLine("Minors:");
        DisplayPeople(people, IsMinor);
        
        Console.WriteLine("\nAdults:");
        DisplayPeople(people, IsAdult);
        

        void DisplayPeople(List<Person> people, FilterDelegate filter)
        {
            Console.WriteLine("Lista jogadores da Rua:");
            foreach (Person person in people)
            {
                if (filter(person))
                {
                    Console.WriteLine("{0}, {1}yo", person.Name, person.Age);
                }
            }
        }

        static bool IsMinor(Person per)
        {
            return per.Age < 18;
        }
        static bool IsAdult(Person per)
        {
            return per.Age >= 18;
        }
    }
}