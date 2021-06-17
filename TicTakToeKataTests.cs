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
        [Fact]
        public void RowOfOs_OWins()
        {
            _sut.SetCell(0,0,2);
            _sut.SetCell(0,1,2);
            _sut.SetCell(0,2,2);

            Assert.Equal(2, _sut.Evaluate());
        }

        [Fact]
        public void ColumnOfXs_XWins()
        {
            _sut.SetCell(0,0,1);
            _sut.SetCell(1,0,1);
            _sut.SetCell(2,0,1);

            Assert.Equal(1, _sut.Evaluate());
        }

        [Fact]
        public void ColumnOfOs_OWins()
        {
            _sut.SetCell(0,0,2);
            _sut.SetCell(1,0,2);
            _sut.SetCell(2,0,2);

            Assert.Equal(2, _sut.Evaluate());
        }

        [Fact]
        public void DiagonalXs_XWins()
        {
            _sut.SetCell(0,0,1);
            _sut.SetCell(1,1,1);
            _sut.SetCell(2,2,1);

            Assert.Equal(1, _sut.Evaluate());
        }

        [Fact]
        public void DiagonalOs_OWins()
        {
            _sut.SetCell(0,0,2);
            _sut.SetCell(1,1,2);
            _sut.SetCell(2,2,2);

            Assert.Equal(2, _sut.Evaluate());
        }

        [Fact]
        public void ReverseDiagonalXs_XWins()
        {
            _sut.SetCell(0,2,1);
            _sut.SetCell(1,1,1);
            _sut.SetCell(2,1,1);

            Assert.Equal(1, _sut.Evaluate());
        }

        [Fact]
        public void ReverseDiagonalOs_OWins()
        {
            _sut.SetCell(0,0,2);
            _sut.SetCell(1,1,2);
            _sut.SetCell(2,2,2);

            Assert.Equal(2, _sut.Evaluate());
        }

    }
}
