using System.Data.Common;

namespace TicTacToe
{
    public partial class TicTacToe : Form
    {
        private static TicTacToe instance;
        private static TicTacToeButton[] topRowButtons;
        private static TicTacToeButton[] middleRowButtons;
        private static TicTacToeButton[] bottomRowButtons;

        public TicTacToe()
        {
            instance = this;
            InitializeComponent();

            // Get each row of buttons
            (topRowButtons, middleRowButtons, bottomRowButtons) = (GetRowButtons(instance.topRow), GetRowButtons(instance.middleRow), GetRowButtons(instance.bottomRow));
        }

        private void Form1_Load(object sender, EventArgs e) { }

        public static void CheckForWin()
        {
            if (HasWon())
            {
                DialogResult dialogResult = MessageBox.Show("Play Again?", $"Player {TurnManager.ActivePlayer.Symbol} has won!", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    topRowButtons.ToList().ForEach(b => b.ResetButton());
                    middleRowButtons.ToList().ForEach(b => b.ResetButton());
                    bottomRowButtons.ToList().ForEach(b => b.ResetButton());
                }
            }
            else TurnManager.NextTurn();
        }

        private static bool HasWon()
        {
            return IsRowWon(instance.topRow) || IsRowWon(instance.middleRow) || IsRowWon(instance.bottomRow) ||
                   IsColWon(0) || IsColWon(1) || IsColWon(2) ||
                   IsDiagonalWon(0, 1, 2) || IsDiagonalWon(2, 1, 0);
        }

        private static bool IsRowWon(FlowLayoutPanel row)
        {
            TicTacToeButton[] rowButtons = GetRowButtons(row);
            if (rowButtons[0].Symbol == '-')
                return false;

            char targetSymbol = rowButtons[0].Symbol;

            foreach (var item in rowButtons)
                if (item.Symbol != targetSymbol) 
                    return false;
            return true;
        }

        private static bool IsColWon(int column) => IsDiagonalWon(column, column, column);
        private static TicTacToeButton[] GetRowButtons(FlowLayoutPanel row) => row.Controls.Cast<TicTacToeButton>().ToArray();
        
        private static bool IsDiagonalWon(int topCorner, int middle, int bottomCorner)
        {
            if (topRowButtons[topCorner].Symbol == '-')
                return false;
            if (topRowButtons[topCorner].Symbol == middleRowButtons[middle].Symbol &&
                topRowButtons[topCorner].Symbol == bottomRowButtons[bottomCorner].Symbol)
                return true;
            return false;
        }

    }
}
