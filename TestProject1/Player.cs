using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Project1
{
    public class Player
    {
        public string myName { get; set; }
        public UInt16 myID { get; set; }
        Rank myRank = new Rank();

        public Player()
        {
            myRank.RankNumber = eRankNumber.rank36kyu;
            myRank.RungPosition = eRungPosition.rungPositionMiddle;
        }

        public Player(string name, eRankNumber rank, eRungPosition rung)
        {
            myName = name;
            myRank.RankNumber = rank;
            myRank.RungPosition = rung;
        }

        public eRankNumber GetRankNumber()
        {
            return myRank.RankNumber;
        }

        public eRungPosition GetRungPosition()
        {
            return myRank.RungPosition;
        }
    }


    
}
