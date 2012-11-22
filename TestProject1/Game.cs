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
        public int GameID { get; set; }
        public int BlackPlayerID { get; set; }
        public int WhitePlayerID { get; set; }
        public int Kome { get; set; }
        public eResult Result { get; set; }

        public Game()
        {
        }

        public Game(int game, int black, int white, int kome, eResult result)
        {
            GameID = game;
            BlackPlayerID = black;
            WhitePlayerID = white;
            Kome = kome;
            Result = result;
        }
    }
}
