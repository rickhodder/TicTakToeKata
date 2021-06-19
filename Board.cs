using System;
using System.Linq;

namespace TicTakToeKata
{
    public class Board
    {
        public const int Draw = 0;
        public const int Unsolved = -1;
        public const int X = 1;
        public const int O = 2;

        private readonly int[,] _cells = new int[3, 3];

        public int Evaluate()
        {
            var result = Unsolved;

            for (int row = 0; row < _cells.GetLength(0); row++)
            {
                result = CheckRow(row);
                if (result != Unsolved) return result;
            }

            for (int column = 0; column < _cells.GetLength(1); column++)
            {
                result = CheckColumn(column);
                if (result != Unsolved) return result;
            }

            result = CheckDiagonals();
            if (result != Unsolved) return result;

            if (_cells.Cast<int>().Any(cell => cell==0))
            {
                return Unsolved;
            }

            return Draw;
        }

        private int CheckDiagonals()
        {
            if (_cells[0, 0] == X && _cells[1, 1] == X && _cells[2, 2] == X)
                return X;
         
            if (_cells[0, 0] == O && _cells[1, 1] == O && _cells[2, 2] == O)
                return O;

            if (_cells[0, 2] == X && _cells[1, 1] == X && _cells[2, 0] == X)
                return X;
            
            if (_cells[0, 2] == O && _cells[1, 1] == O && _cells[2, 0] == O)
                return O;

            return Unsolved;
        }

        private int CheckRow(int row)
        {
            if (_cells[row, 0] == X && _cells[row, 1] == X && _cells[row, 2] == X)
                return X;

            if (_cells[row, 0] == O && _cells[row, 1] == O && _cells[row, 2] == O)
                return O;

            return Unsolved;
        }

        private int CheckColumn(int column)
        {
            if (_cells[0, column] == X && _cells[1, column] == X && _cells[2, column] == X)
                return X;

            if (_cells[0, column] == O && _cells[1, column] == O && _cells[2, column] == O)
                return O;

            return Unsolved;
        }

        public void SetCell(int row, int column, int value)
        {
            _cells[row, column] = value;
        }
    }
}