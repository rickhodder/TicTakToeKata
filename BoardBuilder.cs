using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTakToeKata
{
    public class BoardBuilder
    {
        private Board _board = new Board();

        public Board Build(List<string> rows)
        {
            int r = 0;
            int c = 0;

            foreach (var row in rows)
            {
                c = 0;
                foreach (var column in row.ToUpper())
                {
                    switch (column)
                    {
                        case 'X':
                            _board.SetCell(r,c,Board.X);
                            break;
                        case 'O':
                            _board.SetCell(r, c, Board.O);
                            break;
                    }

                    c++;
                }

                r++;
            }

            return _board;
        }
    }
}

