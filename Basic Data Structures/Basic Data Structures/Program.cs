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


Dictionary<int, string> myDictionary //This dictionary has a key of int type and the value is a string
    = new Dictionary<int, string>()
    {
        {1,"one" },
        {2,"two"},
        {3,"three"}
    };
 */

/* The values can also be stored this whay
myDictionary.Add(1, "one");
myDictionary.Add(2, "two");
myDictionary.Add(3, "three");


Employee[] employees =
{
    new Employee("CEO", "David",45,200),
    new Employee("Manager", "Michael",35,25),
    new Employee("HR","Toby",32,21)
};

Dictionary<string, Employee> employeesDirectory = new Dictionary<string, Employee>(); //Employeed dictionary

foreach(Employee emp in employees)
{
    employeesDirectory.Add(emp.Role, emp);
}

#region Fetching Data from the dictionary
string key = "CEO";
string keyToRemove = "CEO";

if (employeesDirectory.ContainsKey(key))
{
    Employee CEO = employeesDirectory["CEO"];
    Console.WriteLine("CEO Name {0}, salary: {1}", CEO.Name, CEO.Salary);
}
else
{
    Console.WriteLine("This key does not exists in the dictionary!");
}

//Remove

if (employeesDirectory.Remove(keyToRemove))
{
    Console.WriteLine("\nThe employee ({0}) was removed!", keyToRemove);
}
else
{
    Console.WriteLine("\nNo employee found with this key!");
}

Employee result = null;

if(employeesDirectory.TryGetValue("Manager", out result))
{
    Console.WriteLine("Value retrived!");

    Console.WriteLine("Employee name: {0}", result.Name);
}

for(int i = 0; i < employeesDirectory.Count; i++)
{
    //Using ElementAt(i) to return key-type value stored at i index
    KeyValuePair<string, Employee> keyValuePair = employeesDirectory.ElementAt(i);
    //printing key
    Console.WriteLine("\n");
    Console.WriteLine("Key {0}", keyValuePair.Key);

    Employee employeeValue = keyValuePair.Value;

    //printing the properties of the employee object
    Console.WriteLine("Emp Name: {0}", employeeValue.Name);
}

//Changing data contained in key
string keyToUpdate = "HR";

if (employeesDirectory.ContainsKey(keyToUpdate))
{
    employeesDirectory[keyToUpdate] = new Employee("HR", "Holly", 36, 18);
    Console.WriteLine("\nNEW HR employee: {0}", employeesDirectory[keyToUpdate].Name);
} else
{
    Console.WriteLine("\nNo employee found with this key!");
}


#endregion




class Employee
{
    public string Role { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public float Rate { get; set; }

    //Yearly Salary = rate/h * number of days * number of weeks * number of months
    public float Salary
    {
        get
        {
            return Rate * 8 * 5 * 4 * 12;
        }

    }
    public Employee(string role, string name, int age, float rate) 
    {
        this.Role = role;
        this.Name = name;
        this.Age = age;
        this.Rate = rate;
    }
}
*/

//++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++//

/*
 * Dictionary challange


using System;
using System.Collections.Generic;

namespace Coding.Exercise
{
    public class Speller
    {
        public static string Convert(int i)
        {
            Dictionary<int, string> keyValuePairs = new Dictionary<int, string>()
            {
                {0, "zero" },
                {1,"one" },
                {2,"two"},
                {3,"three"},
                {4, "four" },
                {5, "five" }
            };

            if(keyValuePairs.ContainsKey(i))
            {
                return keyValuePairs[i];
            }
            else
            {
                return "nope";
            }
        }
    }
}
 */

//++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++//

/*
 * Stacks:
 * 
 * Data can be added and removed from top
 * can't access the elements in the middle
 * first come last out or last in, first out (Last in is first out - LIFO)
 * 
 * Examples of uses:
 * Reversin data
 * web browser "back" button
 * Undo/Redo buttons
 * 
 * Operations:
 * Push(Object object)
 * Pop()
 * Peek()


class Program
{
    static void Main(string[] args)
    {
        //Defining a new stack
        Stack<int> stack = new Stack<int>(); //Integer stack

        stack.Push(42);
        stack.Push(13);

        //Peek() will return the element at the top of the stack without removing it
        Console.WriteLine("Top value: {0}", stack.Peek());

        //Pop() will remove the value of the top
        if(stack.Count > 0) //Assuring that the stack is not empty
        {
            int removedItem = stack.Pop();
            Console.WriteLine("After removing {0}, the new top value is: {1}", removedItem, stack.Peek());
        }

        //Clear() removes all the elements of the stack
        stack.Clear();


        Console.WriteLine("\n_________________________________________________\n");

        int count = 0;
        while (count <= 10)
        {
            stack.Push(count);
            count++;
        }

        //Example:
        while (stack.Count > 1)
        {
            int removedItem = stack.Pop();
            Console.WriteLine("After removing {0}, the new top value is: {1}", removedItem, stack.Peek());
        }

        //Clear() removes all the elements of the stack
        stack.Clear();


        Console.WriteLine("\n_________________________________________________\n");

        //Reversing an array of integers
        int[] numbers = new int[] {1,2,3,4,5};

        Console.WriteLine("Array: ");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");

            stack.Push(number);
        }

        Console.WriteLine("\n\nReversed Array: ");
        foreach (int number in stack)
        {
            Console.Write(number + " ");
        }

        stack.Clear();

        Console.WriteLine("\n_________________________________________________\n");
    }
}
 */


//++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++//

/*
 * Queues
 * 
 * Data can be added from the rear (back) and removed from the front
 * Can't access the elements in the middle
 * first in first out (FIFO)
 * 
 * Examples of Using:
 * OS requests
 * Managing web requests in a server
 * Queuing input in a video game
 * 
 * Operations:
 * Enqueue(Object object)
 * Object Dequeue()
 * Object Peek()


class Program
{
    public static void Main(string[] args)
    {
        //Defining a Queue
        Queue<int> queue = new Queue<int>();

        //Adding data to the queue
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        queue.Enqueue(4);

        //Printing the front of the queue
        Console.WriteLine("Queue first item: {0}", queue.Peek());

        //removing the item from the queue
        int item = queue.Dequeue();
        Console.WriteLine("{0} was removed from the queue! Next item is: {1}",item, queue.Peek());

        //Removing all the items from the queue
        queue.Clear();

        Console.WriteLine("\n_________________________________________________\n");

        int count = 0;
        while(count <= 10)
        {
            queue.Enqueue(count);
            count++;
        }

        while(queue.Count > 0) //While queue is not empty
        {
            item = queue.Dequeue();
            Console.Write("{0} was removed from the queue! ", item);
            if(queue.Count > 0)
            {
                Console.Write("Next item is {0}", queue.Peek());
            }
            else
            {
                Console.WriteLine("The queue is now empty!");
            }
            Console.WriteLine();
        }

        queue.Clear();

        Console.WriteLine("\n_________________________________________________\n");


        static Order[] ReciveOrdersFromBranch1()
        {
            Order[] orders = new Order[]
            {
                new Order(1,5),
                new Order(2,6),
                new Order(3,7)
            };
            return orders;
        }

        static Order[] ReciveOrdersFromBranch2()
        {
            Order[] orders = new Order[]
            {
                new Order(3,5),
                new Order(4,4),
                new Order(5,10)
            };
            return orders;
        }
        
        Queue<Order> ordersQueue = new Queue<Order>();

        Console.WriteLine("Processing first branch:\n");

        foreach (Order or in ReciveOrdersFromBranch1())
        {
            ordersQueue.Enqueue(or);
        }

        while(ordersQueue.Count > 0){
            Order processedOrder = ordersQueue.Dequeue();
            processedOrder.ProcessOrder();
        }


        if(ordersQueue.Count == 0) 
        {
            Console.WriteLine("\nProcessing second branch:\n");

            foreach (Order or in ReciveOrdersFromBranch2())
            {
                ordersQueue.Enqueue(or);
            }
        }


        while (ordersQueue.Count > 0)
        {
            Order processedOrder = ordersQueue.Dequeue();
            processedOrder.ProcessOrder();
        }
    }

    class Order
    {
        //order ID
        public int OrderId { get; set; }

        //quantity of the order
        public int OrderQuantity { get; set; }

        //Order Constructor
        public Order(int id, int orderQuantity)
        {
            this.OrderId = id;
            this.OrderQuantity = orderQuantity;
        }

        //printing message that the order was processed
        public void ProcessOrder()
        {
            Console.WriteLine($"Order {OrderId} processed! The quantity was: {OrderQuantity}");
        }
    }
}
*/