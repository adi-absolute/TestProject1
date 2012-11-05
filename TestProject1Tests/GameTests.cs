using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Project1;
using NUnit.Framework;

namespace Project1
{
    [TestFixture]
    public class GameTests
    {
        [Test]
        public void GetAndSetPlayerIDs()
        {
            Game g = new Game();

            g.BlackPlayerID = 10;
            UInt16 id = g.BlackPlayerID;
            Assert.AreEqual(10, id);

            g.WhitePlayerID = 11;
            id = g.WhitePlayerID;
            Assert.AreEqual(11, id);
        }

        [Test]
        public void GetAndSetGameIDs()
        {
            Game g = new Game();

            g.GameID = 1000;
            UInt16 id = g.GameID;
            Assert.AreEqual(1000, id);
        }

        [Test]
        public void GetAndSetResult()
        {
            Game g = new Game();

            g.Result = eResult.abandoned;
            eResult result = g.Result;
            Assert.AreEqual(eResult.abandoned, result);
        }

        [Test]
        public void GetAndSetKome()
        {
            Game g = new Game();

            g.Kome = 25 ;
            UInt16 kome = g.Kome;
            Assert.AreEqual(25, kome);
        }

        [Test]
        public void GetAndSetGameDetailsThroughConstructor()
        {
            Game g = new Game(155, 13, 6, 7, eResult.whiteWin);

            Assert.AreEqual(155, g.GameID);
            Assert.AreEqual(13, g.BlackPlayerID);
            Assert.AreEqual(6, g.WhitePlayerID);
            Assert.AreEqual(7, g.Kome);
            Assert.AreEqual(eResult.whiteWin, g.Result);
        }
    }
}
