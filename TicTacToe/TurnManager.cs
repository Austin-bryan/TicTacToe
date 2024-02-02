using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe;

public static class TurnManager
{
    private static List<Player> Players;
    public static Player ActivePlayer;
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
        Form1.ChangeTurnDisplay(ActivePlayer);
    }
}
