using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Project1
{
    public class Player
    {
        string myName;
        UInt16 myID;
        Rank myRank = new Rank();

        public Player()
        {
            myRank.set_RankNumber(eRankNumber.rank36kyu);
            myRank.set_RungPosition(eRungPosition.rungPositionMiddle);
        }

        public Player(eRankNumber rank, eRungPosition rung)
        {
            myRank.set_RankNumber(rank);
            myRank.set_RungPosition(rung);
        }


        public string get_name()
        {
            return myName;
        }

        public void set_name(string name)
        {
            myName = name;
        }

        public UInt16 get_ID()
        {
            return myID;
        }

        public void set_ID(UInt16 id)
        {
            myID = id;
        }

        public eRankNumber GetRankNumber()
        {
            return myRank.get_RankNumber();
        }

        public eRungPosition GetRungPosition()
        {
            return myRank.get_RungPosition();
        }
    }


    
}
