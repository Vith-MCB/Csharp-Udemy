﻿/* 
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

using System;

namespace Coding.Exercise
{
    public class Method
    {
        // Place for your methods


        string LowUpper(string s)
        {
            string sumString = s.ToLower + s.ToUpper;
            return sumString;
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
    }
}

