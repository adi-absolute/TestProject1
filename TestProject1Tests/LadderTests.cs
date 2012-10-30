using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Project1;
using NUnit.Framework;

namespace Project1
{
    [TestFixture]
    public class LadderTests
    {
        [Test]
        public void NumberOfPlayersIsZeroWhenLadderIsCreated()
        {
            Ladder ladder = new Ladder();

            Assert.AreEqual(0, ladder.get_NumberOfPlayers());
        }

        [Test]
        public void SetAndGetNumberOfPlayers()
        {
            Ladder ladder = new Ladder();

            ladder.set_NumberOfPlayers(4);
            Assert.AreEqual(4, ladder.get_NumberOfPlayers());
        }

        [Test]
        public void AddPlayerToEmptyList()
        {
            Ladder ladder = new Ladder();

            string name = "Test";
            ladder.AddPlayer(name, eRankNumber.rank10kyu, eRungPosition.rungPositionMiddle);
            
            Assert.AreEqual(1, ladder.get_NumberOfPlayers());
        }

        [Test]
        public void GetPlayerList()
        {
            Ladder ladder = new Ladder();

            string name = "Test";
            ladder.AddPlayer(name, eRankNumber.rank10kyu, eRungPosition.rungPositionMiddle);

            List<Player> pList = ladder.get_PlayerList();

            int numberOfPlayers = pList.Count;
            Assert.AreEqual(1, numberOfPlayers);
        }

        [Test]
        public void GetIDofLastPlayerInList()
        {
            Ladder ladder = new Ladder();

            string name = "Test";
            ladder.AddPlayer(name, eRankNumber.rank10kyu, eRungPosition.rungPositionMiddle);

            List<Player> pList = ladder.get_PlayerList();

            UInt16 id = pList.ElementAt(0).get_ID();
            Assert.AreEqual(1, id);
        }
    }
}