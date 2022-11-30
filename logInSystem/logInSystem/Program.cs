public class User
{
    public string userName, passWord = null; //User paramethers

    public static void Main(string[] args)
    {
        User newUser = new User(); //Creating user

        Console.WriteLine("-------- Register --------");

        Console.WriteLine("Enter a user name: ");
        newUser.userName = Console.ReadLine();

        Console.WriteLine("Enter a password: ");
        while (true) //Password invisible typing
        {
            var key = System.Console.ReadKey(true);
            if (key.Key == ConsoleKey.Enter)
                break;
            newUser.passWord += key.KeyChar;
        }


        Console.WriteLine("-------- Log-In --------");

        string userNewString, passWordNewString = null;

        Console.WriteLine("Enter a user name: ");
        userNewString = Console.ReadLine();

        if (CheckUserNameData(userNewString))//Checking if user name is equal
        {
            //Password screen will be acessible only if user already exists
            Console.WriteLine("Enter the password: ");

            while (true) //Password invisible typing
            {
                var key = System.Console.ReadKey(true);
                if (key.Key == ConsoleKey.Enter)
                    break;
                passWordNewString += key.KeyChar;
            }

            if(CheckUserPassWordData(passWordNewString))//Checking if user name is equal
            {
                Console.WriteLine("Welcome back, {0}!", newUser.userName);
            }
            else { Console.WriteLine("Worng password!"); }

        } else
        {
            Console.WriteLine("User isn't on data bank!");
        }
        

        // Functions that will check user name and password at login screen
        bool CheckUserNameData(string userNameLogInInput) => userNameLogInInput.Equals(newUser.userName);
        bool CheckUserPassWordData( string passWordLogInInput) => passWordLogInInput.Equals(newUser.passWord);
    }

    
}
