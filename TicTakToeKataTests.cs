using System;
using System.Collections.Generic;
using Xunit;

namespace TicTakToeKata
{
    public class TicTakToeKataTests
    {
        private Board _sut = new();
        private BoardBuilder _builder = new();

        [Fact]
        public void EmptyBoard_NotSolved()
        {
            Assert.Equal(-1, _sut.Evaluate());
        }

        [Fact]
        public void RowOfXs_XWins()
        {
            _sut = _builder.Build(new List<string> { "XXX" });

            Assert.Equal(Board.X, _sut.Evaluate());
        }

        [Fact]
        public void RowOfOs_OWins()
        {
            _sut = _builder.Build(new List<string> { "OOO" });

            Assert.Equal(Board.O, _sut.Evaluate());
        }

        [Fact]
        public void ColumnOfXs_XWins()
        {
            _sut = _builder.Build(new List<string> { "X",
                                                          "X",
                                                          "X" });

            Assert.Equal(Board.X, _sut.Evaluate());
        }

        [Fact]
        public void ColumnOfOs_OWins()
        {
            _sut = _builder.Build(new List<string> { "O",
                                                          "O",
                                                          "O" });

            Assert.Equal(Board.O, _sut.Evaluate());
        }

        [Fact]
        public void DiagonalXs_XWins()
        {
            _sut = _builder.Build(
                new List<string> { "X",
                                        " X",
                                        "  X" });

            Assert.Equal(Board.X, _sut.Evaluate());
        }

        [Fact]
        public void DiagonalOs_OWins()
        {
            _sut = _builder.Build(
                new List<string> { "O",
                                        " O",
                                        "  O" });

            Assert.Equal(Board.O, _sut.Evaluate());
        }

        [Fact]
        public void ReverseDiagonalXs_XWins()
        {
            _sut = _builder.Build(
                new List<string> { "  X",
                                        " X",
                                        "X" });

            Assert.Equal(Board.X, _sut.Evaluate());
        }

        [Fact]
        public void ReverseDiagonalOs_OWins()
        {
            _sut = _builder.Build(
                new List<string> { "  O",
                                        " O",
                                        "O" });

            Assert.Equal(Board.O, _sut.Evaluate());
        }

        [Fact]
        public void NonWinningWithEmptyCell_IsNotSolved()
        {
            _sut = _builder.Build(new List<string> {"O"});

            Assert.Equal(Board.Unsolved, _sut.Evaluate());
        }

        [Fact]
        public void Unsolvable_IsUnsolvable()
        {
            _sut = _builder.Build(new List<string>
            {
                "XOX",
                "OOX",
                "OXO" 
            });

            Assert.Equal(Board.Unsolved, _sut.Evaluate());
        }

    }
}
