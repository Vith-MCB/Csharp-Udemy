//Anonymous Methods

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
        
        // Using anonymous methods:
        Console.WriteLine("\nAnonymous method (Between 20 and 30):");
        FilterDelegate filter = delegate(Person pers) { return pers.Age >= 20 && pers.Age <= 30;};
        
        DisplayPeople(people, filter);

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

//Lambda Expressions
//Lambda declaration operator: "  =>  "
//EX expression: (input paramethers) => expression
//EX Statement: 
/*
 * (input paramethers) => {
 * <sequence of statements>
 * }
 */

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a list of integers.
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Using a Lambda Expression to filter even numbers.
        List<int> evenNumbers = numbers.FindAll((int number) => number % 2 == 0);

        Console.WriteLine("Even Numbers:");
        foreach (int num in evenNumbers)
        {
            Console.WriteLine(num);
        }

        // Using a Lambda Expression to double each number in the list.
        List<int> doubledNumbers = numbers.ConvertAll((int number) => number * 2);

        Console.WriteLine("Doubled Numbers:");
        foreach (int num in doubledNumbers)
        {
            Console.WriteLine(num);
        }

        // Using a Lambda Expression to find the sum of all numbers in the list.
        int sum = numbers.Aggregate((int accumulator, int number) => accumulator + number);

        Console.WriteLine("Sum of all numbers: " + sum);
    }
}

/*
Lambda expressions
#########################################

Please, avoid changing the source code for the exercise!

(Unless you want to import something)

#########################################



Hey there, it is going to be an advanced challenge related to Lambda expressions!



Subject:

Create a dictionary that will contain <string, Func<>> pairs. The keys will be operation signs "+", "-", "/", "*" and values will be the lambda expressions that will perform the corresponding operation on two floats and return a result with type float.



One more time in detail:

Create and store using static keyword Lambda expressions with names Plus, Minus, Divide and Multiply.

You can store function as follow:

static Func<int, int> Name = (a) => a;

Create a static dictionary called Operators that uses a string as a Key and lambda function as a value.

Example: {"sign", Function}

Create a static method OperationGet that will get as input a string, test if this string is a Key in the dictionary and if positive return function otherwise returns null.

*/

using System;
using System.Collections.Generic;

namespace Coding.Exercise
{
    public class Run
    {
        static Func<float, float, float> Plus = (a,b) => a + b;
        static Func<float, float, float> Minus = (a,b) => a - b;
        static Func<float, float, float> Multiply = (a,b) => a * b;
        static Func<float, float, float> Divide = (a,b) => a / b;
            
        static Dictionary<string, Func<float,float,float>> Operators = new Dictionary<string, Func<float,float,float>>{
            { "+", Plus },
            { "-", Minus },
            { "/", Divide },
            { "*", Multiply }
        };

        public static Func<float, float, float> OperationGet(string operatorSign){
            if (Operators.ContainsKey(operatorSign)){return Operators[operatorSign];}
            else{return null;}
        }
    }
}

