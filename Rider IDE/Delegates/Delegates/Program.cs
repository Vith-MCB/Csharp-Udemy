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
*/
/* 
Delegates
#########################################

Please, avoid changing the source code for the exercise!

#########################################



Hands-on Delegates!



Subject:

Create a public delegate that will be called OperationDelegate and will get two arguments with float type and return float as well;

Create 4 static public methods called Add, Subtract, Multiply, and Divide. All of them should get 2 arguments and return a float that corresponds to the result of the performed operation;

Create a public static ApplyOperation method that gets 2 floats and one delegate and applies the operation to those values and returns the result as a float;
*/

using System;


namespace Coding.Exercise
{
    public class Run
    {
        public delegate float OperationDelegate(float arg1, float arg2);
        
        public static float Add(float a, float b){return a+b;}
        public static float Subtract(float a, float b){return a-b;}
        public static float Multiply(float a, float b){return a*b;}
        public static float Divide(float a, float b){return a/b;}
        
        public static float ApplyOperation(float opArg1, float opArg2, OperationDelegate filter){
            return filter(opArg1,opArg2);
        }
    }
}