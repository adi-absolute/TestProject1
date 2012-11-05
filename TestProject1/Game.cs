using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project1
{
    public enum eResult
    {
        blackWin,
        whiteWin,
        abandoned,
    }

    public class Game
    {
        public UInt16 GameID { get; set; }
        public UInt16 BlackPlayerID { get; set; }
        public UInt16 WhitePlayerID { get; set; }
        public UInt16 Kome { get; set; }
        public eResult Result { get; set; }

        public Game()
        {
        }

        public Game(UInt16 game, UInt16 black, UInt16 white, UInt16 kome, eResult result)
        {
            GameID = game;
            BlackPlayerID = black;
            WhitePlayerID = white;
            Kome = kome;
            Result = result;
        }
    }
}
