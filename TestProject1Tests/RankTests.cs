﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Project1;
using NUnit.Framework;

namespace Project1
{
    [TestFixture]
    public class RankTests
    {
        [Test]
        public void SetAndGetRankNumber()
        {
            Rank r = new Rank();

            r.RankNumber = eRankNumber.rank11kyu;
            eRankNumber getRank = r.RankNumber;

            Assert.AreEqual(eRankNumber.rank11kyu, getRank);
        }

        [Test]
        public void SetAndGetRungPosition()
        {
            Rank r = new Rank();

            r.RungPosition = eRungPosition.rungPositionSecond;
            eRungPosition getRung = r.RungPosition;

            Assert.AreEqual(eRungPosition.rungPositionSecond, getRung);
        }

        [Test]
        public void DefaultRankAndRungPositionForNoRank()
        {
            Rank r = new Rank();

            eRankNumber getRank = r.RankNumber;
            eRungPosition getRung = r.RungPosition;

            Assert.AreEqual(eRankNumber.rank36kyu, getRank);
            Assert.AreEqual(eRungPosition.rungPositionFirst, getRung);
        }

        [Test]
        public void SetRankThroughConstructor()
        {
            Rank r = new Rank(eRankNumber.rank4Dan);

            eRankNumber getRank = r.RankNumber;
            eRungPosition getRung = r.RungPosition;

            Assert.AreEqual(eRankNumber.rank4Dan, getRank);
            Assert.AreEqual(eRungPosition.rungPositionFirst, getRung);
        }

        [Test]
        public void SetRankAndRungThroughConstructor()
        {
            Rank r = new Rank(eRankNumber.rank1Dan, eRungPosition.rungPositionTop);

            eRankNumber getRank = r.RankNumber;
            eRungPosition getRung = r.RungPosition;

            Assert.AreEqual(eRankNumber.rank1Dan, getRank);
            Assert.AreEqual(eRungPosition.rungPositionTop, getRung);
        }

        [Test]
        public void MoveUpLadderLowRankSameRung()
        {
            Rank r = new Rank(eRankNumber.rank30kyu, eRungPosition.rungPositionFirst);

            r.MoveUp();

            eRankNumber getRank = r.RankNumber;
            eRungPosition getRung = r.RungPosition;

            Assert.AreEqual(eRankNumber.rank30kyu, getRank);
            Assert.AreEqual(eRungPosition.rungPositionTop, getRung);
        }

        [Test]
        public void MoveUpLadderLowRankUpARung()
        {
            Rank r = new Rank(eRankNumber.rank25kyu, eRungPosition.rungPositionTop);

            r.MoveUp();

            eRankNumber getRank = r.RankNumber;
            eRungPosition getRung = r.RungPosition;

            Assert.AreEqual(eRankNumber.rank24kyu, getRank);
            Assert.AreEqual(eRungPosition.rungPositionFirst, getRung);
        }

        [Test]
        public void MoveUpLadderMiddleRankUpARung()
        {
            Rank r = new Rank(eRankNumber.rank19kyu, eRungPosition.rungPositionTop);

            r.MoveUp();

            eRankNumber getRank = r.RankNumber;
            eRungPosition getRung = r.RungPosition;

            Assert.AreEqual(eRankNumber.rank18kyu, getRank);
            Assert.AreEqual(eRungPosition.rungPositionSecond, getRung);
        }

        [Test]
        public void MoveUpLadderMiddleRankSameRung()
        {
            Rank r = new Rank(eRankNumber.rank19kyu, eRungPosition.rungPositionSecond);

            r.MoveUp();

            eRankNumber getRank = r.RankNumber;
            eRungPosition getRung = r.RungPosition;

            Assert.AreEqual(eRankNumber.rank19kyu, getRank);
            Assert.AreEqual(eRungPosition.rungPositionFirst, getRung);

            // Second Move on same rung
            r.MoveUp();

            getRank = r.RankNumber;
            getRung = r.RungPosition;

            Assert.AreEqual(eRankNumber.rank19kyu, getRank);
            Assert.AreEqual(eRungPosition.rungPositionTop, getRung);
        }

        [Test]
        public void MoveUpLadderHighRankUpARung()
        {
            Rank r = new Rank(eRankNumber.rank1kyu, eRungPosition.rungPositionTop);

            r.MoveUp();

            eRankNumber getRank = r.RankNumber;
            eRungPosition getRung = r.RungPosition;

            Assert.AreEqual(eRankNumber.rank1Dan, getRank);
            Assert.AreEqual(eRungPosition.rungPositionThird, getRung);
        }

        [Test]
        public void MoveUpLadderHighRankSameRung()
        {
            Rank r = new Rank(eRankNumber.rank4Dan, eRungPosition.rungPositionThird);

            r.MoveUp();

            eRankNumber getRank = r.RankNumber;
            eRungPosition getRung = r.RungPosition;

            Assert.AreEqual(eRankNumber.rank4Dan, getRank);
            Assert.AreEqual(eRungPosition.rungPositionSecond, getRung);

            // Second Move on same rung
            r.MoveUp();

            getRank = r.RankNumber;
            getRung = r.RungPosition;

            Assert.AreEqual(eRankNumber.rank4Dan, getRank);
            Assert.AreEqual(eRungPosition.rungPositionFirst, getRung);

            // Third Move on same rung
            r.MoveUp();

            getRank = r.RankNumber;
            getRung = r.RungPosition;

            Assert.AreEqual(eRankNumber.rank4Dan, getRank);
            Assert.AreEqual(eRungPosition.rungPositionTop, getRung);
        }

        [Test]
        public void DontMoveUpLadderMaxRankAndRung()
        {
            Rank r = new Rank(eRankNumber.rank9Dan, eRungPosition.rungPositionTop);

            r.MoveUp();

            eRankNumber getRank = r.RankNumber;
            eRungPosition getRung = r.RungPosition;

            Assert.AreEqual(eRankNumber.rank9Dan, getRank);
            Assert.AreEqual(eRungPosition.rungPositionTop, getRung);
        }

        //----------------------------
        // Move Down
        //----------------------------



        [Test]
        public void MoveDownLowRankSameRung()
        {
            Rank r = new Rank(eRankNumber.rank30kyu, eRungPosition.rungPositionTop);

            r.MoveDown();

            eRankNumber getRank = r.RankNumber;
            eRungPosition getRung = r.RungPosition;

            Assert.AreEqual(eRankNumber.rank30kyu, getRank);
            Assert.AreEqual(eRungPosition.rungPositionFirst, getRung);
        }

        [Test]
        public void MoveDownLowRankDownARung()
        {
            Rank r = new Rank(eRankNumber.rank30kyu, eRungPosition.rungPositionFirst);

            r.MoveDown();

            eRankNumber getRank = r.RankNumber;
            eRungPosition getRung = r.RungPosition;

            Assert.AreEqual(eRankNumber.rank31kyu, getRank);
            Assert.AreEqual(eRungPosition.rungPositionTop, getRung);
        }

        [Test]
        public void MoveDownMidRankSameRung()
        {
            Rank r = new Rank(eRankNumber.rank10kyu, eRungPosition.rungPositionTop);

            r.MoveDown();

            eRankNumber getRank = r.RankNumber;
            eRungPosition getRung = r.RungPosition;

            Assert.AreEqual(eRankNumber.rank10kyu, getRank);
            Assert.AreEqual(eRungPosition.rungPositionFirst, getRung);

            // Move Down Second Time
            r.MoveDown();

            getRank = r.RankNumber;
            getRung = r.RungPosition;

            Assert.AreEqual(eRankNumber.rank10kyu, getRank);
            Assert.AreEqual(eRungPosition.rungPositionSecond, getRung);
        }

        [Test]
        public void MoveDownMidRankDownARung()
        {
            Rank r = new Rank(eRankNumber.rank30kyu, eRungPosition.rungPositionFirst);

            r.MoveDown();

            eRankNumber getRank = r.RankNumber;
            eRungPosition getRung = r.RungPosition;

            Assert.AreEqual(eRankNumber.rank31kyu, getRank);
            Assert.AreEqual(eRungPosition.rungPositionTop, getRung);
        }

        [Test]
        public void MoveDownHighRankSameRung()
        {
            Rank r = new Rank(eRankNumber.rank1Dan, eRungPosition.rungPositionTop);

            r.MoveDown();

            eRankNumber getRank = r.RankNumber;
            eRungPosition getRung = r.RungPosition;

            Assert.AreEqual(eRankNumber.rank1Dan, getRank);
            Assert.AreEqual(eRungPosition.rungPositionFirst, getRung);

            // Move Down Second Time
            r.MoveDown();

            getRank = r.RankNumber;
            getRung = r.RungPosition;

            Assert.AreEqual(eRankNumber.rank1Dan, getRank);
            Assert.AreEqual(eRungPosition.rungPositionSecond, getRung);

            // Move Down Third Time
            r.MoveDown();

            getRank = r.RankNumber;
            getRung = r.RungPosition;

            Assert.AreEqual(eRankNumber.rank1Dan, getRank);
            Assert.AreEqual(eRungPosition.rungPositionThird, getRung);
        }

        [Test]
        public void MoveDownHighRankDownARung()
        {
            Rank r = new Rank(eRankNumber.rank1Dan, eRungPosition.rungPositionThird);

            r.MoveDown();

            eRankNumber getRank = r.RankNumber;
            eRungPosition getRung = r.RungPosition;

            Assert.AreEqual(eRankNumber.rank1kyu, getRank);
            Assert.AreEqual(eRungPosition.rungPositionTop, getRung);
        }

        [Test]
        public void DontMoveDownWhenAtBottomOfRank()
        {
            Rank r = new Rank(eRankNumber.rank36kyu, eRungPosition.rungPositionFirst);

            r.MoveDown();

            eRankNumber getRank = r.RankNumber;
            eRungPosition getRung = r.RungPosition;

            Assert.AreEqual(eRankNumber.rank36kyu, getRank);
            Assert.AreEqual(eRungPosition.rungPositionFirst, getRung);
        }
    }
}
