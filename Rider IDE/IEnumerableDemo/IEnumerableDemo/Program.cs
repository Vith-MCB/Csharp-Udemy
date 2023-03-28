using System.Collections;
using System.Collections.Generic;

// 1. IEnumerable <T> for generic collections
// 2. IEnumerable for non generic collections

DogShelter shelter = new DogShelter();
foreach (Dog dog in shelter)
{
    if (!dog.IsNaughtyDog)
    {
        dog.GiveTreat(2);
    }
    else
    {
        dog.GiveTreat(0);
    }
}


class Dog
{
    public string Name { get; set; }
    
    public bool IsNaughtyDog { get; set; }

    public Dog(string name, bool isNaughty)
    {
        this.Name = name;
        this.IsNaughtyDog = isNaughty;
    }

    public void GiveTreat(int numberOfTreats)
    {
        Console.WriteLine("Dog: {0} said woof {1} times!", Name,numberOfTreats);
    }
}

class DogShelter : IEnumerable<Dog>
{
    public List<Dog> dogs;

    public DogShelter()
    {
        dogs = new List<Dog>()
        {
            new Dog("David", false),
            new Dog("Michael", true),
            new Dog("Sif", false)
        };
    }

    public IEnumerator<Dog> GetEnumerator()
    {
        return dogs.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}