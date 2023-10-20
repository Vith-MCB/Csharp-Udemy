namespace Events_and_Multicast_Delegates;

public class GameEventManager
{
    public delegate void GameEvent();

    public static GameEvent OnGameStart, OnGameOver;

    public static void TriggerGameStart()
    {
        if (OnGameStart != null)
        {
            Console.WriteLine("Starting game...\n");
            OnGameStart();
        }
    }

    public static void TriggerGameOver()
    {
        if (OnGameOver != null)
        {
            Console.WriteLine("\nStopping game...");
            OnGameOver();
        }
    }
}