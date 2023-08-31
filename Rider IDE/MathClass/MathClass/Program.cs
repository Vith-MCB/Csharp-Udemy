/*
//Using the library -> Math.function();
Console.WriteLine("Ceiling: {0}",Math.Ceiling(15.74));
Console.WriteLine("Ceiling: {0}",Math.Floor(15.74));

int higherNumber = Math.Max(13,9); //higherNumber = 13
int lowerNumber = Math.Min(59,3); //lowerNumber = 3
*/

/*
 * Challenge
 * Complete the Run Method with code that will:

 * Pars line into int if it is possible. Otherwise, or if the value is not in the range between 0 and 180, display "Check the input!" on the new line and return;
 * if the parsing was successful, calculate and print:

 * Cosine of this angle in the format "Cos = X", where X is the value;
 * Sine of the angle in the format "Sin = X", where X is the value;
 * Tangent of the angle in the format "Tg = X", where X is the value;
 * Hint: All of those methods expect us to provide radians as input. In order to convert the angle to radians, use the method ConvertToRadians.
 */

public class Exercise
{
    public static double ConvertToRadians(double angle)
    {
        return (Math.PI / 180) * angle;
    }

    public static void CheckUserInput(string userInput)
    {
        if (Int32.TryParse(userInput, out int stringToInt))
        {
            if ((stringToInt > 180 || stringToInt < 0))
            {
                Console.WriteLine("Check the input!");
                return;
            }
            Calculate(ConvertToRadians((double)stringToInt));
        }
        else
        {
            Console.WriteLine("Check the input!");
            return;
        }
    }

    public static void Calculate(double parsedString)
    {
        Console.WriteLine("Cos = {0}",Math.Cos(parsedString));
        Console.WriteLine("Sin = {0}",Math.Sin(parsedString));
        Console.WriteLine("Tg = {0}" ,Math.Tan(parsedString));
    }
        
    public static void Run(string line){
        CheckUserInput(Console.ReadLine());
    }
}