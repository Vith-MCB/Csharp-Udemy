/*Defining arrays

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

/*
 * MULTI DIMENSIONAL ARRAYS

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

/*
 * NESTED FOR LOOPS AND 2D ARRAYS


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

        /*
         * Printing odd values of the matrix

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