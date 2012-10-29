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
            p.set_name(tName);

            Assert.AreEqual(tName, p.get_name());
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
        public void SetNewPlayerRankThroughConstructor()
        {
            Player p = new Player(eRankNumber.rank3kyu, eRungPosition.rungPositionBottom);

            eRankNumber rank = p.GetRankNumber();
            eRungPosition rung = p.GetRungPosition();

            Assert.AreEqual(eRankNumber.rank3kyu, rank);
            Assert.AreEqual(eRungPosition.rungPositionBottom, rung);
        }
    }
}
