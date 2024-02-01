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
    public partial class Board : UserControl
    {
        private const int boardX = 3;
        private const int boardY = 3;
        private int[,] boardArray = new int[boardY, boardX];
        public Board()
        {
            InitializeComponent();
        }
        private void Board_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < boardX; i++)
            {
                // Get the current row
                int[] row = new int[boardArray.GetLength(1)];

                // Use Array.Fill() to fill the row with the specified value
                Array.Fill(row, 0);

                // Copy the filled row to the corresponding row in the 2D array
                Buffer.BlockCopy(row, 0, boardArray, i * row.Length * sizeof(int), row.Length * sizeof(int));
            }
            //PrintArray(boardArray);
        }
        public int[,] BoardStatusArray => boardArray;

        static void PrintArray(int[,] array)
        {
            string tempPrint = "";
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    tempPrint += array[i, j] + " ";
                }
                tempPrint += "\n";
            }
            MessageBox.Show(tempPrint);
        }
    }
}
