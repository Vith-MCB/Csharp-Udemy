using Events_and_Multicast_Delegates;

AudioSystem audioSystem = new AudioSystem();
RenderingEngine renderingEngine = new RenderingEngine();

Player player1 = new Player("VFeN");
Player player2 = new Player("Jhonny");

//Using multicast delegates

GameEventManager.TriggerGameStart();
GameEventManager.TriggerGameOver();