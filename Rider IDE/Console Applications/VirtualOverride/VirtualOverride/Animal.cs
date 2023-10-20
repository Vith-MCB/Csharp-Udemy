using System;

namespace VirtualOverride
{
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsHungry { get; set; }

        /// <summary>
        /// Animal Constructor
        /// </summary>
        /// <param name="string AnimalName"></param>
        /// <param name="int AnimalAge"></param>
        /// <param name="bool isHungry"></param>
        public Animal(string AnimalName, int AnimalAge, bool isHungry)
        {
            this.Name = AnimalName;
            this.Age = AnimalAge;
            this.IsHungry = isHungry;
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("Animal noises!");
        }

        /// <summary>
        /// This function is used to make the animal eat if it is hungry.
        /// </summary>
        public void Eat()
        {
            if (IsHungry)
            {
                Console.WriteLine("{0} ate!", this.Name);
                IsHungry = false;
            }
            else
            {
                Console.WriteLine("Animal is not hungry!");
            }
        }

        public virtual void Play()
        {
            Console.WriteLine("Playing!");
        }

        public virtual void CalculateAge()
        {
            Console.WriteLine($"Animal age is: {Age}");
        }
    }
}