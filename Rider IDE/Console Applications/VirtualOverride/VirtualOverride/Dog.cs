using System;

namespace VirtualOverride
{
    public class Dog : Animal
    {
        public bool IsHappy { get; set; }
        public Dog(string AnimalName, int AnimalAge, bool isHungry) : base(AnimalName, AnimalAge, isHungry)
        {
            IsHappy = false;
        }
        public override void MakeSound()
        {
            Console.WriteLine("Wolf wolf!");
        }

        public override void CalculateAge()
        {
            Console.WriteLine($"{Name} age in dog years is: {Age*7}");
        }

        public override void Play()
        {
            if (Age < 10)
            {
                Console.WriteLine($"{Name} is playing!");
                IsHappy = true;
            }
            else
            {
                Console.WriteLine("This dog is too old to play! :(");
            }
        }
    }
}