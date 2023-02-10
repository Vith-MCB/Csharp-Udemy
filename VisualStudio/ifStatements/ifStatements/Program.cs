/*If statements
 * 
 * if(condition) //if condition mets, the code will be executed
 * {
 *    code;
 * }
 * else if(other condition) //If the condition doesnt match but "at least" matches this one
 * {
 *    code;
 * }
 * else //None of the conditions above were executed
 * {
 *    code;
 * }
 * 
 * EXAMPLE:
 
int temperature = -1;
if(temperature< 0)
{
    Console.WriteLine("It's freezing!");
}
else if(temperature > 0 && temperature < 10)
{
    Console.WriteLine("Take the coat!");
}
else if(temperature >= 10)
{
    Console.WriteLine("It's cozy and warm!");
}

*/

//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++//

/*
 * TryParse function
 * the function returns a bool value
 * 


string numberAsString = "15";
int parsedValue;

bool sucess = int.TryParse(numberAsString, out parsedValue);
if (sucess)
{
    Console.WriteLine("Valid value!");
}
else
{
    Console.WriteLine("The Value is invalid!");
}

 */

//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++//

/*
 * Odd or Even number Challenge


Console.WriteLine("Enter a integer number: ");
string numberAsString = Console.ReadLine();
int parsedValue;

bool sucess = int.TryParse(numberAsString, out parsedValue);
if (sucess)
{
    if (parsedValue % 2 == 0)
    {
        Console.WriteLine("{0} is a Even number!", parsedValue);
    }
    else
    {
        Console.WriteLine("{0} is a Odd number!", parsedValue);
    }
}
else
{
    Console.WriteLine("The Value is invalid! The value must be an int");
}

 */

//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++//

/*
 * Course Challenge


using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        public static void NestedCheck(int number)
        {
            if (number % 3 == 0)
            {
                Console.WriteLine("Divible by 3.");
            }
            else
            {
                if(number % 7==0)
                {
                    Console.WriteLine("Divible by 7.");
                }
                else
                {
                    if(number % 2 == 0)
                    {
                        Console.WriteLine("Even number.");
                    }
                    else
                    {
                        Console.WriteLine("Odd number.");
                    }
                }
            }
        }
    }
}

 */

//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++//

/*
 * Switch Statement
 

int age = 20;
switch (age)
{
    case 0: //If age = 0
        Console.WriteLine("Almost a newborn!");
        break;

    case 5:
        Console.WriteLine("You are a child now!");
        break;

    case 15:
        Console.WriteLine("Almost an adult!");
        break;

    case 20:
        Console.WriteLine("Adult life, here we go!");
        break;

    default: //None of other statements were satisfied
        Console.WriteLine("How old are you then?");
        break;
}

*/

//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++//

/*
 * Ternary operators (If statements)
 * 
 * condition ? first_expression : second_expression;
 * condition has to be either true or false
 * 
 * Ex:


int temperature = -5;
string stateOfMatter;

// if (temperature < 0) { stateOfMatter= "solid"; } else { stateOfMatter = "liquid"; }
//In short:

stateOfMatter = temperature < 0 ? "solid" : "liquid";

Console.WriteLine(stateOfMatter);

stateOfMatter = temperature > 100 ? "gas" : temperature < 0 ? "solid" : "liquid";



//CHALLENGE

string temperatureString = "";
int temperature = 0;

Console.WriteLine("Insert the temperature:");
temperatureString = Console.ReadLine();

bool sucess = int.TryParse(temperatureString, out temperature);
if (sucess)
{
    string message;

    message = temperature <= 15 ? "It's too cold here" : temperature <= 28 ? "it's okay" : "it's hot here!";
    Console.WriteLine(message);
}
else
{
    Console.WriteLine("The Value is invalid!");
}

*/