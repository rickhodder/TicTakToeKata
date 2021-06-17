namespace TicTakToeKata
{
    public class Board
    {
        private int[,] _cells = new int[3, 3];

        public int Evaluate()
        {
            if(_cells[0,0]==1 && _cells[0,1]==1 && _cells[0,2]==1)
                return 1;
                
            return -1;
        }

        public void SetCell(int row, int column, int value)
        {
            _cells[row, column] = value;
        }
    }
}