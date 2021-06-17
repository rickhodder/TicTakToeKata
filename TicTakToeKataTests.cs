using System;
using Xunit;

namespace TicTakToeKata
{
    public class TicTakToeKataTests
    {
        [Fact]
        public void EmptyBoard_NotSolved()
        {
            var board = new Board();

            Assert.Equal(-1, board.Evaluate());
        }
    }
}
