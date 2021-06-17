using System;

namespace TicTakToeKata
{
    public class Board
    {
        private int[,] _cells = new int[3, 3];

        public int Evaluate()
        {
            for (int row = 0; row < _cells.GetLength(0); row++)
            {
                var result = CheckRow(row);
                if(result!=-1) return result;
            }

            for (int column = 0; column < _cells.GetLength(1); column++)
            {
                var result = CheckColumn(column);
                if(result!=-1) return result;
            }

            return -1;
        }

        public int CheckRow(int row)
        {
            if(_cells[row,0]==1 && _cells[row,1]==1 && _cells[row,2]==1)
                return 1;

            if(_cells[row,0]==2 && _cells[row,1]==2 && _cells[row,2]==2)
                return 2;
                
            return -1;
        }

       public int CheckColumn(int column)
        {
            if(_cells[0,column]==1 && _cells[1,column]==1 && _cells[2,column]==1)
                return 1;

            if(_cells[0,column]==2 && _cells[1,column]==2 && _cells[2,column]==2)
                return 2;
                
            return -1;
        }

        public void SetCell(int row, int column, int value)
        {
            _cells[row, column] = value;
        }
    }
}