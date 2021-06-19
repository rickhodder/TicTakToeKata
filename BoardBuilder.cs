using System;
using System.Collections.Generic;
using System.Linq;

namespace TicTakToeKata
{
    public class BoardBuilder
    {
        private readonly Board _board = new Board();

        public Board Build(string board)
        {
            var rows = board.Split(new[] {'\r', '\n'}, StringSplitOptions.RemoveEmptyEntries).ToList();
            var r = 0;

            foreach (var row in rows)
            {
                var c = 0;

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