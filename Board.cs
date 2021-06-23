using System.Linq;

namespace TicTakToeKata
{
    public class Board
    {
        public const int Unsolved = -1;
        public const int Draw = 0;
        public const int X = 1;
        public const int O = 2;

        private readonly int[,] _cells = new int[3, 3];

        public int Evaluate()
        {
            if (FoundWinnerByRow(out var rowWinner)) return rowWinner;

            if (FoundWinnerByColumn(out var columnWinner)) return columnWinner;

            if (FoundWinnerOnDiagonal(out var diagonalWinner)) return diagonalWinner;

            return FoundEmptyCell() ? Unsolved : Draw;
        }

        private bool FoundEmptyCell()
        {
            return _cells.Cast<int>().Any(cell => cell == 0);
        }

        private bool FoundWinnerByColumn(out int columnWinner)
        {
            columnWinner = Unsolved;

            for (var column = 0; column < _cells.GetLength(1); column++)
            {
                var result = CheckColumn(column);
                if (result == Unsolved) continue;

                columnWinner = result;
                return true;
            }

            return false;
        }

        private bool FoundWinnerByRow(out int rowWinner)
        {
            rowWinner = Unsolved;

            for (var row = 0; row < _cells.GetLength(0); row++)
            {
                var result = CheckRow(row);
                if (result == Unsolved) continue;

                rowWinner = result;
                return true;
            }

            return false;
        }

        private bool FoundWinnerOnDiagonal(out int diagonalWinner)
        {
            diagonalWinner = Unsolved;

            if (_cells[0, 0] == _cells[1, 1] &&
                _cells[1, 1] == _cells[2, 2] )
            {
                diagonalWinner = _cells[0, 0];
            }
            
            if (_cells[0, 2] == _cells[1, 1] &&
                _cells[1, 1] == _cells[2, 0])
            {
                diagonalWinner = _cells[0,2];
            }

            return diagonalWinner!=Unsolved && diagonalWinner!=0;
        }

        private int CheckRow(int row)
        {
            if (_cells[row, 0] != 0 &&
                _cells[row, 0] == _cells[row, 1] &&
                _cells[row, 1] == _cells[row, 2])
                return _cells[row, 0];

            return Unsolved;
        }

        private int CheckColumn(int column)
        {
            if (_cells[0, column]!=0 &&
                _cells[0, column] == _cells[1, column] &&
                _cells[1, column] == _cells[2, column] )
                return _cells[0, column];

            return Unsolved;
        }

        public void SetCell(int row, int column, int value)
        {
            _cells[row, column] = value;
        }
    }
}