/* 
 * Methods examples
 * 
static int Add(int num1, int num2)
{
    return num1 + num2;
}

static int Multiply(int num1, int num2) 
{ 
    return num1 * num2; 
}

static double Divide(double num1, double num2) 
{ 
    return num1 / num2; 
}

*/

//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++//

/*
 * Methods Challenge
 

string friend1 = "Guto", friend2 = "Jão", friend3 = "Juninho";
static void GreetFriend(string friendName) {
    Console.WriteLine("Hi {0}, my friend!",friendName);
}
GreetFriend(friend3);

*/

//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++//

/*
 * Methods Challenge

using System;

namespace Coding.Exercise
{
    public class Method
    {
        // Place for your methods


        static public string LowUpper(string s)
        {
            return s.ToLower() + s.ToUpper();
        }

        static public void Count(string s)
        {
            Console.WriteLine("The amount of characters is {0}.",s.Length);
        }

        public static void Run()
        {
            // We encourage you to test your code with different strings,
            // but don't forget to put the default string back at the end of your testing.
            string s = "HeY ThErE !";

            /// Change nothing down here 
            s = LowUpper(s);
            Console.WriteLine(s);
            Count(s);

        }
        public static void Main(string[] args) { Run(); }
    }
}
*/

//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++//

/*
 * Try, Catch and Finally

Console.WriteLine("Enter a number: ");
string userInput = Console.ReadLine();

try
{
    int userInputAsInt = int.Parse(userInput); //The program tries to transform the string to a int
}

//catch (Exception) is a generic exception, used when you dont know what type of error to expect

catch(FormatException) 
{
    Console.WriteLine("Format exception, please enter a valid type (int)!");
}
catch (OverflowException)
{
    Console.WriteLine("The input is either too long or too short for an int32!");
}
finally
{
    Console.WriteLine("This is called anyways!");
}
 */

//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++//