using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe;

public class Player
{
    public char Symbol { get; }
    public Color Color { get; }

    public Player(char symbol, Color color) => (Symbol, Color) = (symbol, color);
}
