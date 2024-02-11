namespace TicTacToe;

public partial class TicTacToeButton : UserControl
{
    bool hasBeenClicked;
    public TicTacToeButton() => InitializeComponent();
    public char Symbol => MainButton.Text[0];

    private void MainButton_Click(object sender, EventArgs e)
    {
        if (hasBeenClicked)
            return;
        MainButton.Text      = TurnManager.ActivePlayer.Symbol.ToString();
        MainButton.ForeColor = Color.White;
        MainButton.BackColor = TurnManager.ActivePlayer.Color;
        hasBeenClicked       = true;

        TicTacToeForm.CheckForWin();
    }

    private void TicTacToeButton_Load(object sender, EventArgs e) { }

    private void MainButton_MouseLeave(object sender, EventArgs e) => UpdateButton(" ", Color.Black);
    private void MainButton_MouseHover(object sender, EventArgs e) => UpdateButton(TurnManager.ActivePlayer.Symbol.ToString(), TurnManager.ActivePlayer.Color);

    private void UpdateButton(string buttonText, Color textColor)
    {
        if (!hasBeenClicked)
            (MainButton.Text, MainButton.ForeColor) = (buttonText, textColor);
    }
    public void ResetButton() => 
        (MainButton.Text, MainButton.ForeColor, MainButton.BackColor, hasBeenClicked, Enabled) = 
        (" ", Color.Black, Color.White, false, true);   
}
