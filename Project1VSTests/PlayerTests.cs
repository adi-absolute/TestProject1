﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Project1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Project1
{
    [TestClass]
    public class PlayerTests
    {
        [TestMethod]
        public void SetAndGetPlayerName()
        {
            Player p = new Player();

            string tName = "Aditya";
            p.myName = tName;

            Assert.AreEqual(tName, p.myName);
        }

        [TestMethod]
        public void SetAndGetPlayerID()
        {
            Player p = new Player();

            int id = 42;
            p.myID = id;

            Assert.AreEqual(id, p.myID);
        }

        [TestMethod]
        public void NewPlayerDefaultRankIsThirtySixKyu()
        {
            Player p = new Player();

            eRankNumber rank = p.GetRankNumber();

            Assert.AreEqual(eRankNumber.rank36kyu, rank);
        }

        [TestMethod]
        public void NewPlayerDefaultRungIsMiddleRung()
        {
            Player p = new Player();

            eRungPosition rung = p.GetRungPosition();

            Assert.AreEqual(eRungPosition.rungPositionFirst, rung);
        }

        [TestMethod]
        public void SetNewPlayerThroughConstructor()
        {
            string name = "Aditya";
            Player p = new Player(name, eRankNumber.rank3kyu, eRungPosition.rungPositionSecond);

            eRankNumber rank = p.GetRankNumber();
            eRungPosition rung = p.GetRungPosition();

            Assert.AreEqual(eRankNumber.rank3kyu, rank);
            Assert.AreEqual(eRungPosition.rungPositionSecond, rung);
            Assert.AreEqual(name, p.myName);
        }
    }
}
