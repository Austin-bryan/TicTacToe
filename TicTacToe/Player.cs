namespace TicTacToe;

public class Player
{
    public char Symbol { get; }     // Either X or O
    public Color Color { get; }     // Used for graphical displays

    public Player(char symbol, Color color) => (Symbol, Color) = (symbol, color);   // Init vars
}