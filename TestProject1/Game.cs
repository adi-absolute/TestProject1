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
        UInt16 myGameID;
        UInt16 myBlackPlayerID;
        UInt16 myWhitePlayerID;
        UInt16 myKome;
        eResult myResult;

        public Game()
        {
        }

        public Game(UInt16 game, UInt16 black, UInt16 white, UInt16 kome, eResult result)
        {
            myGameID = game;
            myBlackPlayerID = black;
            myWhitePlayerID = white;
            myKome = kome;
            myResult = result;
        }

        public void set_BlackPlayerID(UInt16 id)
        {
            myBlackPlayerID = id;
        }
        public UInt16 get_BlackPlayerID()
        {
            return myBlackPlayerID;
        }

        public void set_WhitePlayerID(UInt16 id)
        {
            myWhitePlayerID = id;
        }
        public UInt16 get_WhitePlayerID()
        {
            return myWhitePlayerID;
        }

        public void set_GameID(UInt16 id)
        {
            myGameID = id;
        }
        public UInt16 get_GameID()
        {
            return myGameID;
        }

        public void set_Kome(UInt16 kome)
        {
            myKome = kome;
        }
        public UInt16 get_Kome()
        {
            return myKome;
        }

        public void set_Result(eResult result)
        {
            myResult = result;
        }
        public eResult get_Result()
        {
            return myResult;
        }
    }
}
