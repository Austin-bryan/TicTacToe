using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal static class TurnManager
    {
        private static Board _board;
        public static Board Board
        {
            get => _board;
            set
            {
                if (_board is null) _board = value;
            }
        }

        static Player PlayerX = new('X', Color.DarkRed);
        static Player PlayerY = new('Y', Color.Aqua);
    }
}
