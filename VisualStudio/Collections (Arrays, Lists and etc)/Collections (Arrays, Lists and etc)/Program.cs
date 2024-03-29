﻿/*Defining arrays

float[] grades = new float[5]; //Defining int array with 5 positions
float sumGrades = 0, grade;

string gradeString;

//Here, the program saves every grade in a array pos (not worthit bc of 2 for loops usage)
for(int i = 0; i < grades.Length; i++)
{
    Console.WriteLine("Grade: ");
    gradeString = Console.ReadLine();

    bool sucess = float.TryParse(gradeString, out grade);
    if (sucess)
    {
        grades[i] = grade;
    }
}

double AverageCalc(int totalOfStudents, float SumOfrades)
{
    return SumOfrades / totalOfStudents;
}

//Sum of grades
for (int i = 0; i < grades.Length; i++)
{
    sumGrades += grades[i];
}

double average = AverageCalc(grades.Length, sumGrades);

Console.WriteLine("Average = {0}", average);

*/

/*FOREACH LOOPS


string[] friends = {"Guto", "Jao", "Usfi", "Mateus", "Alan"};

int counter = 0;
foreach (string name in friends)
{
    Console.WriteLine("Hi, {0}, is nice to meet you!", name);
}

 */

/* CHALLENGE!

using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        public static void GetOdd(int[] Array)
        {
            for(int i = 0; i < Array.Length; i++)
            {
                if (Array[i] % 2 != 0)
                {
                    Console.WriteLine(Array[i]);
                }
            }
        }

        public static void GetEven(int[] Array)
        {
            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i] % 2 == 0)
                {
                    Console.WriteLine(Array[i]);
                }
            }
        }

        public static void Run()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            GetOdd(array);
            GetEven(array);

        }
    }
}
 */

/*MULTI DIMENSIONAL ARRAYS

int[,] array2D = new int[,]
{
    {1,2,3}, // row 0
    {4,5,6}, // row 1
    {7,8,9}  // row 2
};

Console.WriteLine("Central value {0}", array2D[1,1]);

//printing diagonals

for(int i = 0; i <= 2; i++) //Printing principal diagonal
{
    Console.WriteLine("Principal diagonal: {0}", array2D[i,i]);
}


Console.WriteLine();

int count = 0;
for (int j = 2; j >= 0; j--) //Printing inverse diagonal
{
    Console.WriteLine("Inverse diagonal: {0}", array2D[j, count]);
    count++;
}


// ".Rank" can be used to return the number of dimentions of the array

int[] ints= new int[2];
Console.WriteLine("Dimentions: {0}", ints.Rank);

int[,] ints2D = new int[2,2];
Console.WriteLine("Dimentions: {0}", ints2D.Rank);

 */

/* NESTED FOR LOOPS AND 2D ARRAYS


class Program
{
    static int[,] matrix =
    {
        {1,2,3},
        {4,5,6},
        {7,8,9}
    };

    static void Main(string[] args)
    {
        foreach (int item in matrix) // Using froreach to go through every element of "matrix", values can't be changed
        {
            Console.Write(item+" ");
        }

        /*
         * Console.WriteLine("\n\nChanging values of the matrix!\n");
         *

        for (int i = 0; i < matrix.GetLength(0); i++) //Using GetLenght to get the lenght of the first line (0)
        {
            //Inner for loop
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                matrix[i,j] = 0;
            }
        }

        foreach (int item in matrix) // Using froreach to go through every element of "matrix", after the values was changed
        {
            Console.Write(item + " ");
        }
        */

/* Printing odd values of the matrix

Console.WriteLine("\n\nPrinting odd values of the matrix!\n");

for (int i = 0; i < matrix.GetLength(0); i++) //Using GetLenght to get the lenght of the first line (0)
{
    //Inner for loop
    for (int j = 0; j < matrix.GetLength(0); j++)
    {

        if (matrix[i, j] % 2 == 0) { Console.Write(matrix[i, j] + " "); }
    }
}

}
}
*/

/* Jagged arrays (Arrays inside an Array)


//Declair jagged array (first way)
int[][] jaggedArray = new int[3][]; //3 arrays inside of one array

jaggedArray[0] = new int[3]; //Array of 3 elements at the first position
jaggedArray[1] = new int[5]; //Array of 1 elements at the first position
jaggedArray[2] = new int[1]; //Array of 1 element at the first position

jaggedArray[0] = new int[] { 1, 5, 11 };
jaggedArray[1] = new int[] { 4, 15, 1, 2, 1 };
jaggedArray[2] = new int[] { 2 };

//alternative way
int[][] jaggedArray2 = new int[][]
{
    new int[] { 1, 5, 11 },
    new int[] { 4, 15, 1, 2, 1 },
    new int[] { 2 }
};

//Printing the middle value of the first and second input of the array
Console.WriteLine("Middle element: {0}", jaggedArray[0][1]);
Console.WriteLine("Middle element: {0}", jaggedArray2[1][2]);

for(int i = 0; i < jaggedArray.Length; i++) {
    Console.WriteLine("\nElement: {0}\n",i);
    Console.WriteLine("Array: ");
    for(int j = 0; j < jaggedArray[i].Length; j++)
    {
        Console.Write("{0} ", jaggedArray[i][j]);
    }
    Console.WriteLine("\n");
}
 */

/* JAGGED ARRAY CHALLENGE


//Create a jagged array which contains 3 "friends arrays", in wich 2 family members should be stored
//Describe family

string[][] friendsArray = new string[3][]
{
    new string[] {"Joe", "Peter", "Jan"},
    new string[] {"Chloe", "Jordan", "Camille"},
    new string[] {"Noah", "Gabriel", "Alex"}
};

for(int i = 0; i< friendsArray.Length; i++)
{
    Console.WriteLine("{0}'s family: ", friendsArray[i][0]);
    for(int j = 0; j < friendsArray[i].Length; j++)
    {
        if (j == 1) { Console.Write(" Dad: {0}  ||", friendsArray[i][j]); } 
        else if(j == 2) { Console.Write(" Mom: {0}\n", friendsArray[i][j]); }
        else {Console.Write("Child: {0}  ||", friendsArray[i][j]); }
    }
    Console.WriteLine("\n");
}
 */

/* USING ARRAYS AS PARAMETHERS


static double GetAverage(int[] gradesArray)
{
    double sumOfGrades = 0;
    for(int i = 0; i < gradesArray.Length; i++)
    {
        sumOfGrades += gradesArray[i];
    }
    return sumOfGrades/gradesArray.Length;
}

int[] grades = new int[6];
grades[0] = 15;
grades[1] = 13;
grades[2] = 8;
grades[3] = 12;
grades[4] = 6;
grades[5] = 16;

Console.WriteLine(GetAverage(grades));

 */

/* USING ARRAYS AS PARAMETHERS CHALLANGE (HAPPINESS)


static void IncreaseHapiness(int[] happinessArray)
{
    for(int i = 0; i < happinessArray.Length; i++)
    {
        happinessArray[i] += 2;
    }
}

int[] happiness = new int[] {12,13,19,1,4};
IncreaseHapiness(happiness);

foreach (int happyGrade in happiness)
{
    Console.WriteLine("The New happy grade is: {0}",happyGrade);
}
 
 */

/*Creating Min function


static int MinV2(params int[] values)
{
    int minValue = int.MaxValue;
    foreach (var number in values)
    {
        if(number < minValue) { minValue = number; }
    }
    return minValue;
}

Console.WriteLine("The minimum number is: {0}",MinV2(2,4,5,-8,2,1));

 */

/*
 * COLLECTIONS


//___________________________________________________________________________________________//
// ARRAYLISTS


using System.Collections;

//Declaring an ArrayList (System.Collections must be used)
ArrayList myArrayListUnd = new ArrayList(); //undefined amount of objects
ArrayList myArrayList2Def = new ArrayList(10); //defined amount of objects (10)

myArrayListUnd.Add("Test");
myArrayListUnd.Add(1.3);
myArrayListUnd.Add("Vitor");

myArrayListUnd.Remove("Test"); //Remove element with specific value
myArrayListUnd.RemoveAt(0);

foreach(object obj in myArrayListUnd)
{
   Console.WriteLine(obj);
}
//___________________________________________________________________________________________//

//LISTS



var numbers = new List<int>(); //Undefined Integer list
var numbers2 = new List<int> { 5,4,3,6,3}; //Defined Integer list

numbers.Add(1);
numbers2.Add(2);
numbers.Clear(); // Clears the entire list

//Looping through the list 
foreach(int element in numbers2) 
{
    Console.WriteLine(element);
}

for(int i = 0; i < numbers2.Count; i++) //.Count returns the size of the list
{
    Console.WriteLine(numbers2[i]);
}

 */

/*
 * LIST CHALLENGE


//Write a method that returns a list of even integer numbers between 100 and 170 (inclusive).

using System;
using System.Collections.Generic;
namespace Coding.Exercise
{
    public class ListsExercise
    {

        public static List<int> Solution()
        {
            var list = new List<int> { 100, 101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 165, 166, 167, 168, 169, 170 };
            var result = new List<int>();
            foreach(int element in list)
            {
                if (element % 2 == 0)
                {
                    result.Add(element);
                }
            }
            return result;
        }

    }
}
 */