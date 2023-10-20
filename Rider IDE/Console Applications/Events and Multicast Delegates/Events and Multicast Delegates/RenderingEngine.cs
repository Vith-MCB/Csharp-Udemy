namespace Events_and_Multicast_Delegates;

public class RenderingEngine
{
    public RenderingEngine()
    {
        GameEventManager.OnGameStart += StartGame;
        GameEventManager.OnGameOver += GameOver;
    }

    private void StartGame()
    {
        Console.WriteLine("Rendering Engine Started");
        Console.WriteLine("Drawing Visuals...\n");
    }

    private void GameOver()
    {
        Console.WriteLine("Rendering Engine Stopped");
    }
}