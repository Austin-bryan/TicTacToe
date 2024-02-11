namespace TicTacToe;

public partial class TicTacToeButton : UserControl
{
    bool hasBeenClicked;
    public TicTacToeButton() => InitializeComponent();
    public char Symbol => MainButton.Text[0];

    private void MainButton_Click(object sender, EventArgs e)
    {
        if (hasBeenClicked)     // Prevents players from changing buttons already clicked
            return;

        // Updates the color of the button to show its been controlled by a player
        MainButton.Text      = TurnManager.ActivePlayer.Symbol.ToString();
        MainButton.ForeColor = Color.White;
        MainButton.BackColor = TurnManager.ActivePlayer.Color;
        hasBeenClicked       = true;

        TicTacToeForm.FinishTurn();
    }

    private void TicTacToeButton_Load(object sender, EventArgs e) { }

    // Hover and Leave functions are used to display a preview of the symbol change. Hover shows shows a preview, leaving returns the button to blank
    private void MainButton_MouseLeave(object sender, EventArgs e) => UpdateButton(" ", Color.Black);
    private void MainButton_MouseHover(object sender, EventArgs e) => UpdateButton(TurnManager.ActivePlayer.Symbol.ToString(), TurnManager.ActivePlayer.Color);

    private void UpdateButton(string buttonText, Color textColor)
    {
        if (!hasBeenClicked)
            (MainButton.Text, MainButton.ForeColor) = (buttonText, textColor);
    }

    // Resets all variables to default, ready to be used again in the future
    public void ResetButton() => (MainButton.Text, MainButton.ForeColor, MainButton.BackColor, hasBeenClicked, Enabled) = 
                                 (" ", Color.Black, Color.White, false, true);   
}
