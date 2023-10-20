namespace Events_and_Multicast_Delegates;

public class Player
{
    public string PlayerName { get; set; }

    public Player(string name)
    {
        this.PlayerName = name;
        
        GameEventManager.OnGameStart += StartGame;
        GameEventManager.OnGameOver += GameOver;

    }

    private void StartGame()
    {
        Console.WriteLine("Spawning Player with the ID: {0}", PlayerName);
    }

    private void GameOver()
    {
        Console.WriteLine("Removing Player with the ID: {0}", PlayerName);
    }
}