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
