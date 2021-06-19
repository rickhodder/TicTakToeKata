using System.Collections.Generic;
using Xunit;

namespace TicTakToeKata
{
    public class TicTakToeKataTests
    {
        private Board _sut;
        private readonly BoardBuilder _builder = new();

        [Fact]
        public void EmptyBoard_NotSolved()
        {
            _sut = _builder.Build("");
            Assert.Equal(Board.Unsolved, _sut.Evaluate());
        }

        [Fact]
        public void RowOfXs_XWins()
        {
            _sut = _builder.Build("XXX");

            Assert.Equal(Board.X, _sut.Evaluate());
        }

        [Fact]
        public void RowOfOs_OWins()
        {
            _sut = _builder.Build("OOO");

            Assert.Equal(Board.O, _sut.Evaluate());
        }

        [Fact]
        public void ColumnOfXs_XWins()
        {
            _sut = _builder.Build(
                                    "X\n" +
                                          "X\n" +
                                          "X\n");

            Assert.Equal(Board.X, _sut.Evaluate());
        }

        [Fact]
        public void ColumnOfOs_OWins()
        {
            _sut = _builder.Build(
                                    "O\n" +
                                         "O\n" +
                                         "O");

            Assert.Equal(Board.O, _sut.Evaluate());
        }

        [Fact]
        public void DiagonalXs_XWins()
        {
            _sut = _builder.Build(
                                "X\n" +
                                      " X\n" +
                                      "  X");

            Assert.Equal(Board.X, _sut.Evaluate());
        }

        [Fact]
        public void DiagonalOs_OWins()
        {
            _sut = _builder.Build(
                "O\n" +
                " O\n" +
                "  O");

            Assert.Equal(Board.O, _sut.Evaluate());
        }

        [Fact]
        public void ReverseDiagonalXs_XWins()
        {
            _sut = _builder.Build(
                                   "  X\n" +
                                        " X\n" +
                                        "X");

            Assert.Equal(Board.X, _sut.Evaluate());
        }

        [Fact]
        public void ReverseDiagonalOs_OWins()
        {
            _sut = _builder.Build(
                                  "  O\n" +
                                        " O\n" +
                                        "O" );

            Assert.Equal(Board.O, _sut.Evaluate());
        }

        [Fact]
        public void NonWinningWithEmptyCell_IsNotSolved()
        {
            _sut = _builder.Build("O");

            Assert.Equal(Board.Unsolved, _sut.Evaluate());
        }

        [Fact]
        public void Unsolvable_IsUnsolvable()
        {
            _sut = _builder.Build(

                "XOX\n" +
                      "OOX\n" +
                      "OXO"
            );

            Assert.Equal(Board.Draw, _sut.Evaluate());
        }

        
    }

}
