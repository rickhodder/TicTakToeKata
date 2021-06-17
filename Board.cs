namespace TicTakToeKata
{
    public class Board
    {
        private int[,] _cells = new int[3, 3];

        public int Evaluate()
        {
            return CheckRow(0);
        }

        public int CheckRow(int row)
        {
            if(_cells[row,0]==1 && _cells[row,1]==1 && _cells[row,2]==1)
                return 1;

            return -1;
        }

        public void SetCell(int row, int column, int value)
        {
            _cells[row, column] = value;
        }
    }
}