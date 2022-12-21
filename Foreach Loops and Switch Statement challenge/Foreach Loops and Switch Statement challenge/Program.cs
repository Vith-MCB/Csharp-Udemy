/*

Create an application that takes 2 input values.

Any input value (1st input)

Asks the data type of the input value. (2nd input)

It will print to the console the options like below to take input for the 2nd input value:

Press 1 for String
Press 2 for integer
Press 3 for Boolean

If the input value for the 2nd input is 1 then the application should check that if the entered 1st input is a valid string or not. Hereby we even want to check, if it is a complete alphabetic entry (so no numbers accepted)

If the input value for the 2nd input is 2 then the application should check if the entered 1st input is a valid integer or not.

Based on the input the 1st value and the selection of data type using the 2nd input, the application should return whether the entered 1st value is of data type selected by the user or not.

Please make sure to use a switch statement. To check the valid string you can write your custom logic.

For example:

Enter a value: { here you can enter any value}

Select the Data type to validate the input you have entered.

Press 1 for String

Press 2 for Integer

Press 3 for Boolean

Here, if you enter 1 it should return below message

You have entered a value: Denis Panjuta

It is a valid: String

Here, if you enter 2 it should return below message

You have entered a value: Denis Panjuta

It is an invalid: Integer
*/

internal class Program
{
    private static void Main(string[] args)
    {

        //Showing options to user
        Console.WriteLine("Select a data type to insert\n");
        Console.WriteLine("Press 1 for String");
        Console.WriteLine("Press 2 for integer");
        Console.WriteLine("Press 3 for Boolean\n");

        string stringValue = Console.ReadLine();
        int value;
        if (stringValue != null) { value = int.Parse(stringValue); }
        else { throw new Exception("Invalid value! Insert a value between 1 and 3."); }

        Console.WriteLine("\nNow, insert a value or string\n");
        string input = Console.ReadLine();//Reading user input
        if (input == null) { throw new Exception("Invalid input!"); }

        int count = 0;
        bool printMessage = false;

        switch (value)
        {
            case 1:
                printMessage = true;
                foreach (char element in input)
                {
                    if (!(Char.IsLetter(input, count)))
                    {
                        Console.WriteLine("\n'{0}' is a invalid string!", input);
                        return;
                    }
                    else { printMessage = false; }

                    count++;
                }
                if (!printMessage){ Console.WriteLine("\n'{0}' is a valid string!", input); }
                break;

            case 2:
                foreach (char element in input)
                {
                    if (Char.IsLetter(input, count))
                    { 
                        Console.WriteLine("\n'{0}' is a invalid int!", input);
                        return;
                    }
                    else { printMessage = true; }
                    count++;
                }
                if (printMessage) { Console.WriteLine("\n'{0}' is a valid int!", input); }

                break;

            case 3:
                if (input.Equals("true"))
                {
                    Console.WriteLine("\n'{0}' is a valid boolean", input);
                }
                else if(input.Equals("false"))
                {
                    Console.WriteLine("\n'{0}' is a valid boolean", input);
                }
                else { Console.WriteLine("\n'{0}' is a invalid boolean", input); }
                break;
        }
    }
}