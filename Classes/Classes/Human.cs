using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Human
    {
        private string firstName;
        private string lastName;
        private int age;

        //Default Constructor
        public Human()
        {
            Console.WriteLine("Constructor called. Object Created");
        }



        //Parameterized constructor
        public Human(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        public void IntroduceMyself()
        {
            Console.WriteLine("Hi, my name is {0} {1}, nice to meet you! I'm {2}yo.", firstName, lastName, age);
        }
    }
}
