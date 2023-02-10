using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembersC
{
    internal class Members
    {
        public int age;

        private string memberName;
        private string jobTitle;
        private int salary;


        public string JobTitle { 
            get { return jobTitle; } 
            set { jobTitle = value; } 
        }

        public Members(string name, string job, int age, int salary)
        {
            this.memberName = name;
            this.jobTitle = job;
            this.salary = salary;
            this.age = age;
            
        }

        public void IntroduceYourself(bool isFriend)
        {
            if (isFriend)
            {
                Console.WriteLine("Hy, my name is {0}, my salary is {1} dollars!", memberName, salary);
            }
            else {
                Console.WriteLine("Hy, my name is {0}, is nice to meet you!",memberName);
            }
        }

        ~Members()
        {
            Console.WriteLine();
            Debug.Write("Desconstruction of Members object!");
        }

    }
}
