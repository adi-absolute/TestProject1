using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Project1;
using NUnit.Framework;

namespace Project1
{
    [TestFixture]
    public class PlayerTests
    {
        [Test]
        public void SetAndGetPlayerName()
        {
            Player p = new Player();

            string tName = "Aditya";
            p.myName = tName;

            Assert.AreEqual(tName, p.myName);
        }

        [Test]
        public void SetAndGetPlayerID()
        {
            Player p = new Player();

            UInt16 id = 42;
            p.myID = id;

            Assert.AreEqual(id, p.myID);
        }

        [Test]
        public void NewPlayerDefaultRankIsThirtySixKyu()
        {
            Player p = new Player();

            eRankNumber rank = p.GetRankNumber();

            Assert.AreEqual(eRankNumber.rank36kyu, rank);
        }

        [Test]
        public void NewPlayerDefaultRungIsMiddleRung()
        {
            Player p = new Player();

            eRungPosition rung = p.GetRungPosition();

            Assert.AreEqual(eRungPosition.rungPositionMiddle, rung);
        }

        [Test]
        public void SetNewPlayerThroughConstructor()
        {
            string name = "Aditya";
            Player p = new Player(name, eRankNumber.rank3kyu, eRungPosition.rungPositionBottom);

            eRankNumber rank = p.GetRankNumber();
            eRungPosition rung = p.GetRungPosition();

            Assert.AreEqual(eRankNumber.rank3kyu, rank);
            Assert.AreEqual(eRungPosition.rungPositionBottom, rung);
            Assert.AreEqual(name, p.myName);
        }
    }
}
