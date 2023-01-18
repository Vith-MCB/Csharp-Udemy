// BASIC DATATYPES
using System.Collections;
using System.Collections.Generic;


//----------------------------------------------------------------------------------------------------------------------//


/* HASHTABLES
namespace Hashtables
{
    class Program
    {
        //Key - Value

        static void Main(string[] args)
        {
            //Creating a students Hashtable
            Hashtable studentsTable = new Hashtable();

            //Creating students
            Student stud1 = new Student(1, "Vitor", 71);
            Student stud2 = new Student(2, "Guto", 83);
            Student stud3 = new Student(3, "Pedro", 42);
            Student stud4 = new Student(4, "Gustavo", 76);
            Student stud5 = new Student(5, "João", 85);

            //Assign students to the table
            studentsTable.Add(stud1.Id, stud1);
            studentsTable.Add(stud2.Id, stud2);
            studentsTable.Add(stud3.Id, stud3);
            studentsTable.Add(stud4.Id, stud4);
            studentsTable.Add(stud5.Id, stud5);

            // Retrive a individual value with known ID
            //Assign a value (Student) from the table to a variable
            Student storedStudent1 = 
            (Student)studentsTable[stud1.Id]; //The casting is needed becouse we want to assign a "Student" type for the variable

            Console.WriteLine("individual value with known ID:");
            Console.WriteLine("Student ID: {0}, Name: {1}, GPA: {2}", storedStudent1.Id, storedStudent1.Name, storedStudent1.GPA);

            //Retrive all values from the hashtable
            Console.WriteLine("\nRetriving all values from the hashtable:");

            //it can be made like this
            foreach (DictionaryEntry entry in studentsTable)
            {
                Student temp = (Student)entry.Value;
                Console.WriteLine("\nStudent ID: {0}", temp.Id);
                Console.WriteLine("Student Name: {0}", temp.Name);
                Console.WriteLine("Student GPA: {0}", temp.GPA);
            }
            

            //or like this:
            foreach (Student value in studentsTable.Values)
            {
                Console.WriteLine("\nStudent ID: {0}", value.Id);
                Console.WriteLine("Student Name: {0}", value.Name);
                Console.WriteLine("Student GPA: {0}", value.GPA);
            }
        }
    }

    class Student //May be created in another file, but for better explanation, is defined here.
    {
        //ID property
        public int Id { get; set; }

        //Name property
        public string Name { get; set; }

        //GPA property
        public float GPA { get; set; }

        public Student(int id, string name, float GPA) //Student Constructor
        {
            this.Id = id;
            this.Name = name;
            this.GPA = GPA;
        }
    }
}

 */


//----------------------------------------------------------------------------------------------------------------------//


/*
 * HASHTABLE CHALLENGE
 * 
 * Write a program that will iterate through each element of the students array and insert them into a hashtable.
 * Is a student with the same ID already exists int the hashtable skip it and display the following error:
 * "Sorry, A student with the same ID already exists".
 * Hint: use the method ContainsKey() to check wether a student with the same IS already exists



class Program
{
    static void Main(string[] args)
    {
        //Students array
        Student[] students = new Student[5];
        students[0] = new Student(1, "Denis", 88);
        students[1] = new Student(2, "Olaf", 97);
        students[2] = new Student(6, "Ozzy", 65);
        students[3] = new Student(1, "Luiz", 73);
        students[4] = new Student(4, "Alex", 58);

        //Creating hashtable
        Hashtable studentsTable = new();

        foreach(Student value in students)
        {
            if (!studentsTable.ContainsKey(value.Id))
            {
                studentsTable.Add(value.Id, value);
                Console.WriteLine("Student with ID {0} was added!", value.Id);
            }
            else { Console.WriteLine("Sorry, A student with the ID [{0}] already exists!",value.Id); }
        }
    }
}

//Student Constructor
class Student //May be created in another file, but for better explanation, is defined here.
{
    //ID property
    public int Id { get; set; }

    //Name property
    public string Name { get; set; }

    //GPA property
    public float GPA { get; set; }

    public Student(int id, string name, float GPA) //Student Constructor
    {
        this.Id = id;
        this.Name = name;
        this.GPA = GPA;
    }
}
 */


//----------------------------------------------------------------------------------------------------------------------//


/*
 * DICTIONARIES
 */

