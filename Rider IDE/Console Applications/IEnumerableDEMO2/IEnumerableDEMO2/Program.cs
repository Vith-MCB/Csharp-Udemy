using System.Collections.Generic;

//Creating a generic variable that will be used to store collections
IEnumerable<int> unknownCollection = GetCollection(3);

//Printing the numbers inside of the variable
foreach (int num in unknownCollection)
{
    Console.Write(num + " ");
}

static IEnumerable<int> GetCollection(int option)
{
    //Creating a List of type integer
    List<int> numbersList = new List<int>() { 1, 2, 3, 4, 5 };

    //Creating a Queue of type integer
    Queue<int> numbersQueue = new Queue<int>();
    //Add values to the queue
    numbersQueue.Enqueue(6);
    numbersQueue.Enqueue(7);
    numbersQueue.Enqueue(8);
    numbersQueue.Enqueue(9);
    numbersQueue.Enqueue(10);

    if (option == 1)
    {
        return numbersList;
    }
    else if (option == 2)
    {
        return numbersQueue;
    }
    else
    {
        return new int[] { 11, 12, 13, 14, 15 };
    }
}