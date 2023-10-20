namespace Events_and_Multicast_Delegates;

public class AudioSystem
{
    public AudioSystem()
    {
        GameEventManager.OnGameStart += StartGame;
        GameEventManager.OnGameOver += GameOver;
    }
    
    private void StartGame()
    {
        Console.WriteLine("Audio System Started");
        Console.WriteLine("Playing Audio...\n");
    }

    private void GameOver()
    {
        Console.WriteLine("Audio System Stopped");
    }
}