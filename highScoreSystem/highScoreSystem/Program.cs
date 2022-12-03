public class Machine
{
    public int globalHighScore = 0; // Variable that will be used to store global High Score
    public string playerNameHighScore = "MACHINE";

    public class Player {
        public string playerName = "";
    }
    

    public static void Main(String[] args)
    {
        int score = 0; //Defining local score
        string scoreString = "", askContinue = "";
        bool wantContinue = true;

        Player player = new Player(); //Creating new Player
        Machine game = new Machine(); //Inicializing game


        while (wantContinue)
        { 
            //Program will define a new player
            Console.WriteLine("------ CREATING PLAYER ------");
            Console.WriteLine();
            Console.WriteLine("Player name:");
            player.playerName = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("--------- GAME DATA ---------");
            Console.WriteLine();
            Console.WriteLine("Score:");
            scoreString = Console.ReadLine();

            //Parsing the value
            bool sucess = int.TryParse(scoreString, out score);
            if (sucess)
            {
                Console.WriteLine();
                Console.WriteLine("The value is beeing compared!");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("The Value is invalid!");
            }

            Console.WriteLine();

            //Checking Score Data
            Console.WriteLine("--------- SCORE DATA ---------");
            Console.WriteLine();
            if (CheckScore(score, game.globalHighScore)) // If actual player got the 
            {
                SetNewHighScore(score, game, player);
                Console.WriteLine("Congratulations! {0} is the new record!", score);
            }
            else
            {
                Console.WriteLine("The actual record is {0}, from player {1}", game.globalHighScore, game.playerNameHighScore);
            }
            Console.WriteLine();
            Console.WriteLine("------------------------------");
            Console.WriteLine();

            Console.WriteLine("Do you wanna continue? [Y/N]");
            askContinue = Console.ReadLine().ToLower();
            
            if(askContinue == "y") { continue; }
            else{ break; }


        }
    }

    //Function used to return if actual score is great than global score
    public static bool CheckScore(int actualScore, int globalScore) => actualScore > globalScore;

    //Function used to set new global score and player name
    public static void SetNewHighScore(int actualScore, Machine machine, Player player)
    {
        machine.globalHighScore = actualScore;
        if(player.playerName!= null) { machine.playerNameHighScore = player.playerName; }
        else { machine.playerNameHighScore = "XXX"; }
    }


}
