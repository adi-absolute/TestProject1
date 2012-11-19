using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
namespace Project1
{
    public enum eRankNumber
    {
        rank9Dan = 0,
        rank8Dan,
        rank7Dan,
        rank6Dan,
        rank5Dan,
        rank4Dan,
        rank3Dan,
        rank2Dan,
        rank1Dan,
        rank1kyu, rank2kyu, rank3kyu, rank4kyu, rank5kyu, rank6kyu,
        rank7kyu, rank8kyu, rank9kyu, rank10kyu, rank11kyu, rank12kyu,
        rank13kyu, rank14kyu, rank15kyu, rank16kyu, rank17kyu, rank18kyu,
        rank19kyu, rank20kyu, rank21kyu, rank22kyu, rank23kyu, rank24kyu,
        rank25kyu, rank26kyu, rank27kyu, rank28kyu, rank29kyu, rank30kyu,
        rank31kyu, rank32kyu, rank33kyu, rank34kyu, rank35kyu, rank36kyu, 
    }

    public enum eRungPosition
    {
        rungPositionTop,
        rungPositionFirst,
        rungPositionSecond,
        rungPositionThird
    }
    
    public class Rank
    {
        public eRankNumber RankNumber { get; set; }
        public eRungPosition RungPosition { get; set; }

        public Rank()
        {
            RankNumber = eRankNumber.rank36kyu;
            RungPosition = eRungPosition.rungPositionFirst;
        }

        public Rank(eRankNumber rank)
        {
            RankNumber = rank;
            RungPosition = eRungPosition.rungPositionFirst;
        }

        public Rank(eRankNumber rank, eRungPosition rung)
        {
            RankNumber = rank;
            RungPosition = rung;
        }

        public void MoveUp()
        {
            if (RungPosition == eRungPosition.rungPositionTop)
            {
                if (RankNumber != eRankNumber.rank9Dan)
                {
                    RankNumber--;

                    if (RankNumber < eRankNumber.rank1kyu)
                        RungPosition = eRungPosition.rungPositionThird;
                    else if (RankNumber < eRankNumber.rank19kyu)
                        RungPosition = eRungPosition.rungPositionSecond;
                    else
                        RungPosition = eRungPosition.rungPositionFirst;
                }
            }
            else
                RungPosition--;
        }

        public void MoveDown()
        {
            if ((RankNumber == eRankNumber.rank36kyu)
                && (RungPosition == eRungPosition.rungPositionFirst))
                return;

            if (RankNumber > eRankNumber.rank18kyu)
            {
                if (RungPosition == eRungPosition.rungPositionFirst)
                    RungPosition = eRungPosition.rungPositionTop;
                else
                    RungPosition++;
            }
            else if (RankNumber > eRankNumber.rank1Dan)
            {
                if (RungPosition == eRungPosition.rungPositionSecond)
                    RungPosition = eRungPosition.rungPositionTop;
                else
                    RungPosition++;
            }
            else
            {
                if (RungPosition == eRungPosition.rungPositionThird)
                    RungPosition = eRungPosition.rungPositionTop;
                else
                    RungPosition++;
            }

            if (RungPosition == eRungPosition.rungPositionTop)
                RankNumber++;
        }
    }
    
}
