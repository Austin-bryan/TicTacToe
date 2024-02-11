namespace TicTacToe;

public static class TurnManager
{
    private static readonly List<Player> Players;
    public static Player ActivePlayer { get; private set; }
    public static Player PlayerX => Players[0];
    public static Player PlayerO => Players[1];
    private static int playerIndex = 1;

    static TurnManager()
    {
        Players = new List<Player>
        {
            new('X', Color.Red),
            new('O', Color.Blue)
        };
        ActivePlayer = Players[0];
    }
    public static void NextTurn()
    {
        ActivePlayer = Players[playerIndex++ % 2];
        TicTacToeForm.ChangeTurnDisplay(ActivePlayer);
    }
}
