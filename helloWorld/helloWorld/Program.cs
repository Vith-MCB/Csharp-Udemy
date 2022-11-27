/*+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++*/


/* Simple Hello World code
 * 
Console.WriteLine("Enter your name: ");
string name = Console.ReadLine(); //Here the user type his name (at console)
Console.WriteLine("Hello, {0}", name); //Printing message using the user name
*/


/*+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++*/


/*
//Data types

//Integers
sbyte ex1 = 120; // -128 up to 127
short ex2 = 200; // -32767 up to 32767
int ex3 = 200; // -2147483648 up to 2147483647
long ex4 = 212; // -9...bil up to 9...bil

//Float
float ex1 = 9.9f; // 7-digit precision
double ex2 = 5.1;  // 15-digit precision
decimal ex3 = 1.5;  // 28-digit precision

//Logic
bool switch = false; //True or False

//Char and Strings
char ex1 = 'a';    //Single char or unicode
string ex2 = "abcd"; //Multiple letters and unicodes
*/



/*+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++*/


/* Implicit and Explicit conversion
 * 
 * Explicit:
 * A variable type can be converter
 * for an example, we will cast a double value into a integer variable

double myDouble = 13.45;
int myInt;
myInt = (int)myDouble; //Here, the double value is casted into myInt variable
Console.WriteLine(myInt);

//Implicit conversion:
int num = 12123;
long myNewNum = num;
// or
float myFloat = 13.23f;
double myNewFloatNumber = myFloat;
string myDoubleToString = myDouble.ToString(); //Using C# function to convert types: Dbl -> Str

string myIntString = "15";
int numOfString = Int32.Parse(myIntString); //Using C# function to convert types: Str -> Int
 */


/*+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++*/

/*
 * String Manipulation
 * 
int age = 20;
string name = "Vitor Ribeiro";
float heigh = 1.81f;

//String Concatenation
Console.WriteLine("Hello, my name is "+name+", and i'm "+age+"yo."); 

//String Manipulation
Console.WriteLine("\nHello, my name is {0}, and I'm {1}yo. My heigh is {2}.", name, age, heigh);

//String Interpolation (Use the '$')
Console.WriteLine($"\nHello, my name is {name}, and I'm {age}yo. My heigh is {heigh}.");

 */

/*+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++*/

/* 
 * String Methods
 * 
string firstName = "Vitor";
string lastName = "Lacerda";
string fullName = string.Concat(" ",firstName, lastName); //Concatenating the names with blank space at the start

Console.WriteLine(firstName.Substring(2)); //Splits the name || Output: "tor"
Console.WriteLine(firstName.ToLower()); //Output: "vitor"
Console.WriteLine(firstName.ToUpper()); //Output: "VITOR"
Console.WriteLine(fullName.Trim()); //Removes the blank spaces ||Input: "  Vitor Ribeiro" Output: "Vitor Ribeiro"
Console.WriteLine(firstName.IndexOf("i"); //Output: 1

 */

/*+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++*/

/*
 * CHALLENGE
 * String Methods
 * / -----------------------------------------------------------------------------------------------------/
 * Challenge 1:

string userName;
Console.WriteLine("Please, enter your name and press 'enter'\n");
userName= Console.ReadLine();
if (userName != "")
{
    Console.WriteLine("User name to Uppercase: {0}", userName.ToUpper());
    Console.WriteLine("User name to Lowecase: {0}", userName.ToLower());
    Console.WriteLine("User name without spaces: {0}", userName.Trim());
}
else
{
    Console.WriteLine("Insert a name!");
}
 */



/*
 * / -----------------------------------------------------------------------------------------------------/
 * Callenge 2:


string userInput;
string charToFind;
string firstName;
string lastName;

Console.WriteLine("Enter a string:");
userInput = Console.ReadLine();
Console.WriteLine("Wich char do you wanna know the index? ");
charToFind = Console.ReadLine();

int charIndex = userInput.ToLower().IndexOf(charToFind.ToLower());

if(charIndex != -1) //checking if the char exists in the string
{
    Console.WriteLine("The char is on the intex: {0}", charIndex);
}
else { Console.WriteLine("The char isn't in the string"); }


Console.WriteLine("|-----------------------------------------------------------------------|");

Console.WriteLine("Enter your first name:");
firstName = Console.ReadLine();
Console.WriteLine("Enter your last name:");
lastName = Console.ReadLine();
Console.WriteLine("Full Name: {0} {1}",firstName,lastName);

 */

/*+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++*/

/* Using constants
 * 
 * use the word "const" + data type to declair a const:

const double PI = 3.131592;
const int weeks = 52, months = 12, days = 365;

*/

/*+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++*/