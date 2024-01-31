using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class TicTacToeButton : UserControl
    {
        public TicTacToeButton() => InitializeComponent();

        /*
         * List of Todos. Tackle each one one at a time
         * 
         * Create enum that has the states Blank, X, and O
         * Create ToString function that converts Blank X and O to "-", "x" and "o"
         * Create a static turn manager class that keeps track of whos turn it is
         *      All members of this class should be static
         * Each click of a button will change whos turn it is
         * Show a label that indicates whos turn it is
         * The button click will automatically make it an x or an o based on who's turn it is
         * If its an X, set the text color to white and background of the button to red
         * If its an O, set the text color to white and background of the button to blue
         * Each button should know which button is adjacent, these should be stored in a list
         * Be able to detect if the game is a win for one player, or a draw.
         * The game should be able to detect if its a draw even if there
         * This should probably require a game manager class who will announce the winner, loser or draw
         * 
         * What might be useful is creating a separate Player class who has an X or O variable as well as a color tied to them, Red for player X and Blue for player O. 
         * 
         * When setting the color of the button, you will use something like button.BackColor = TurnManager.CurrentPlayer.Color
         * 
         * When the player mouse overs an empty button, change the text from "-" to their symbol (button.Text = TurnManager.CurrentPlayer.Symbol)
         * as well as change the color of the text to be the color of the current player, but keep the background white. This provides the player a little bit more feedback as they mouse over. 
         * Make sure to, in the mouse Unhover event, to change the text back to "-" and set the text back to black
         * 
         * Once all this is done, this will be the base game completed and we can start working on generalizing the game, making it procedual, and so on
         */
        private void MainButton_Click(object sender, EventArgs e)
        {

        }
    }
}
