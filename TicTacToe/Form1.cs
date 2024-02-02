using System.Data.Common;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        private static Form1 instance;
        private static TicTacToeButton[] topRowButtons;
        private static TicTacToeButton[] middleRowButtons;
        private static TicTacToeButton[] bottomRowButtons;

        public Form1()
        {
            instance = this;
            InitializeComponent();
            ChangeTurnDisplay(TurnManager.ActivePlayer);//sets the turn display when it starts

            //Get each row of buttons
            (topRowButtons, middleRowButtons, bottomRowButtons) = (GetRowButtons(instance.topRow), GetRowButtons(instance.middleRow), GetRowButtons(instance.bottomRow));
        }

        private void Form1_Load(object sender, EventArgs e) { }

        public static void CheckForWin()
        {
            if (HasWon())
                MessageBox.Show(TurnManager.ActivePlayer.Symbol + " has won!");
        }

        private static bool HasWon()
        {
            return CheckRow(instance.topRow) || CheckRow(instance.middleRow) || CheckRow(instance.bottomRow) ||
                   CheckColumn(0) || CheckColumn(1) || CheckColumn(2) ||
                   CheckDiagonal(0, 1, 2) || CheckDiagonal(2, 1, 0);
        }

        private static bool CheckRow(FlowLayoutPanel row)
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

        private static bool CheckColumn(int column) => CheckDiagonal(column, column, column);
        private static TicTacToeButton[] GetRowButtons(FlowLayoutPanel row) => row.Controls.Cast<TicTacToeButton>().ToArray();

        private static bool CheckDiagonal(int topCorner, int middle, int bottomCorner)
        {
            if (topRowButtons[topCorner].Symbol == '-')
                return false;
            if (topRowButtons[topCorner].Symbol == middleRowButtons[middle].Symbol &&
                topRowButtons[topCorner].Symbol == bottomRowButtons[bottomCorner].Symbol)
                return true;
            return false;
        }
        public static void ChangeTurnDisplay(Player activePlayer)
        {
            instance.TurnDisplayLabel.Text = activePlayer.Symbol.ToString();
            instance.TurnDisplayLabel.ForeColor = Color.White;
            instance.TurnDisplayLabel.BackColor = activePlayer.Color;

        }
    }
}
