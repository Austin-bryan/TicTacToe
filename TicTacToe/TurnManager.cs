namespace TicTacToe;

public static class TurnManager
{
    private static readonly List<Player> Players;               // List of all players
    public static Player ActivePlayer { get; private set; }     // Player who's turn it is
    public static Player PlayerX => Players[0];
    public static Player PlayerO => Players[1];
    private static int playerIndex = 1;

    static TurnManager()
    {
        // Generate players
        Players = new List<Player>
        {
            new('X', Color.Red),
            new('O', Color.Blue)
        };
        ActivePlayer = Players[0];
    }
    public static void NextTurn()
    {
        ActivePlayer = Players[playerIndex++ % 2];   // Get next active player
        TicTacToeForm.ChangeTurnDisplay(ActivePlayer);
    }
}
