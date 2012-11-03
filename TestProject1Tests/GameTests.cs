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

            g.set_BlackPlayerID(10);
            UInt16 id = g.get_BlackPlayerID();
            Assert.AreEqual(10, id);

            g.set_WhitePlayerID(11);
            id = g.get_WhitePlayerID();
            Assert.AreEqual(11, id);
        }

        [Test]
        public void GetAndSetGameIDs()
        {
            Game g = new Game();

            g.set_GameID(1000);
            UInt16 id = g.get_GameID();
            Assert.AreEqual(1000, id);
        }

        [Test]
        public void GetAndSetResult()
        {
            Game g = new Game();

            g.set_Result(eResult.abandoned);
            eResult result = g.get_Result();
            Assert.AreEqual(eResult.abandoned, result);
        }

        [Test]
        public void GetAndSetKome()
        {
            Game g = new Game();

            g.set_Kome(25);
            UInt16 kome = g.get_Kome();
            Assert.AreEqual(25, kome);
        }

        [Test]
        public void GetAndSetGameDetailsThroughConstructor()
        {
            Game g = new Game(155, 13, 6, 7, eResult.whiteWin);

            Assert.AreEqual(155, g.get_GameID());
            Assert.AreEqual(13, g.get_BlackPlayerID());
            Assert.AreEqual(6, g.get_WhitePlayerID());
            Assert.AreEqual(7, g.get_Kome());
            Assert.AreEqual(eResult.whiteWin, g.get_Result());
        }
    }
}
