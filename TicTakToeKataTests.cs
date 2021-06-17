using System;
using Xunit;

namespace TicTakToeKata
{
    public class TicTakToeKataTests
    {
        private Board _sut = new();

        [Fact]
        public void EmptyBoard_NotSolved()
        {
            Assert.Equal(-1, _sut.Evaluate());
        }

        [Fact]
        public void RowOfXs_XWins()
        {
            _sut.SetCell(0,0,1);
            _sut.SetCell(0,1,1);
            _sut.SetCell(0,2,1);

            Assert.Equal(1, _sut.Evaluate());
        }
    }
}
