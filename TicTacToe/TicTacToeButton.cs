using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe;

public partial class TicTacToeButton : UserControl
{
    private char symbol = '-';

    public TicTacToeButton() => InitializeComponent();

    private void MainButton_Click(object sender, EventArgs e)
    {

    }

    private void TicTacToeButton_Load(object sender, EventArgs e) => ShowSymbol();
    private void ShowSymbol() => MainButton.Text = symbol.ToString();
}
