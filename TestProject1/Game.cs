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
        public uint GameID { get; set; }
        public uint BlackPlayerID { get; set; }
        public uint WhitePlayerID { get; set; }
        public uint Kome { get; set; }
        public eResult Result { get; set; }

        public Game()
        {
        }

        public Game(uint game, uint black, uint white, uint kome, eResult result)
        {
            GameID = game;
            BlackPlayerID = black;
            WhitePlayerID = white;
            Kome = kome;
            Result = result;
        }
    }
}
