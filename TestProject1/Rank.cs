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
        rungPositionMiddle,
        rungPositionBottom,
        rungPositionBottom2
    }
    
    public class Rank
    {
        eRankNumber myRankNumber;
        eRungPosition myRungPosition;

        public Rank()
        {
            myRankNumber = eRankNumber.rank36kyu;
            myRungPosition = eRungPosition.rungPositionMiddle;
        }

        public Rank(eRankNumber rank)
        {
            myRankNumber = rank;
            myRungPosition = eRungPosition.rungPositionMiddle;
        }

        public Rank(eRankNumber rank, eRungPosition rung)
        {
            myRankNumber = rank;
            myRungPosition = rung;
        }

        public void set_RankNumber(eRankNumber rank)
        {
            myRankNumber = rank;
        }

        public eRankNumber get_RankNumber()
        {
            return myRankNumber;
        }

        public void set_RungPosition(eRungPosition rung)
        {
            myRungPosition = rung;
        }

        public eRungPosition get_RungPosition()
        {
            return myRungPosition;
        }

        public void MoveUp()
        {
            if (myRungPosition == eRungPosition.rungPositionTop)
            {
                if (myRankNumber != eRankNumber.rank9Dan)
                {
                    myRankNumber--;

                    if (myRankNumber < eRankNumber.rank1kyu)
                        myRungPosition = eRungPosition.rungPositionBottom2;
                    else if (myRankNumber < eRankNumber.rank19kyu)
                        myRungPosition = eRungPosition.rungPositionBottom;
                    else
                        myRungPosition = eRungPosition.rungPositionMiddle;
                }
            }
            else
                myRungPosition--;
        }

        public void MoveDown()
        {
            if ((myRankNumber == eRankNumber.rank36kyu)
                && (myRungPosition == eRungPosition.rungPositionMiddle))
                return;

            if (myRankNumber > eRankNumber.rank18kyu)
            {
                if (myRungPosition == eRungPosition.rungPositionMiddle)
                    myRungPosition = eRungPosition.rungPositionTop;
                else
                    myRungPosition++;
            }
            else if (myRankNumber > eRankNumber.rank1Dan)
            {
                if (myRungPosition == eRungPosition.rungPositionBottom)
                    myRungPosition = eRungPosition.rungPositionTop;
                else
                    myRungPosition++;
            }
            else
            {
                if (myRungPosition == eRungPosition.rungPositionBottom2)
                    myRungPosition = eRungPosition.rungPositionTop;
                else
                    myRungPosition++;
            }

            if (myRungPosition == eRungPosition.rungPositionTop)
                myRankNumber++;
        }
    }
    
}
