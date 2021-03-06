﻿/*
ChessLib, a chess data structure library

MIT License

Copyright (c) 2017-2019 Rudy Alex Kohn

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/

namespace Chess.Test.Material
{
    using Xunit;

    public sealed class MaterialTests
    {
        //TODO : Implement the RIGHT way

        [Fact]
        public void MaterialValueTest()
        {
            Assert.True(true);
            //Game game = new Game();
            //game.NewGame();

            //int startMaterial = game.State.Material.MaterialValueTotal;

            //// generate moves
            //IList<Move> moves = new List<Move>(12) {
            //                                          new Move(EPieces.WhitePawn, ESquare.f2, ESquare.f4, EMoveType.Doublepush, EPieces.NoPiece),
            //                                          new Move(EPieces.BlackPawn, ESquare.e7, ESquare.e5, EMoveType.Doublepush, EPieces.NoPiece),
            //                                          new Move(EPieces.WhitePawn, EPieces.BlackPawn, ESquare.f4, ESquare.e5, EMoveType.Capture),
            //                                          new Move(EPieces.BlackPawn, ESquare.d7, ESquare.d5, EMoveType.Doublepush, EPieces.NoPiece),
            //                                          new Move(EPieces.WhitePawn, ESquare.f5, ESquare.d6, EMoveType.Epcapture, EPieces.NoPiece)
            //                                      };

            //IList<int> lostMaterial = new List<int>(12)
            //{
            //    0,
            //    0,
            //    100,
            //    100,
            //    200
            //};

            //IList<int> stepMaterial = new List<int>(12)
            //{
            //    startMaterial,
            //    startMaterial,
            //    startMaterial - 100,
            //    startMaterial - 100,
            //    startMaterial - 200
            //};

            //for (int i = 0; i < moves.Count; i++)
            //{
            //    Assert.True(game.MakeMove(moves[i]));
            //    Assert.Equal(lostMaterial[i], Math.Abs(game.State.Material.MaterialValueTotal));
            //}
        }
    }
}