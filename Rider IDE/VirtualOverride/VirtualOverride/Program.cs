using System;

namespace VirtualOverride
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Creating a new ANIMAL
            Animal dog = new Animal("Dog",2,true);

            Console.WriteLine("{0} class!", dog.GetType());
            
            dog.MakeSound();
            dog.Play();
            dog.Eat();
            dog.CalculateAge();
            dog.Play();

            //Creating a new DOG (Dog is a class that stents from Animal class)
            Dog dog2 = new Dog("Carlos", 12, true);
            
            Console.WriteLine("\n{0} class!", dog2.GetType());
            
            dog2.MakeSound();
            dog2.Eat();
            dog2.CalculateAge();
            dog2.Play();
        }
    }
}