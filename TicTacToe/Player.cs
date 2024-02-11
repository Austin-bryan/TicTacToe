namespace TicTacToe;

public class Player
{
    public char Symbol { get; }
    public Color Color { get; }

    public Player(char symbol, Color color) => (Symbol, Color) = (symbol, color);
}
