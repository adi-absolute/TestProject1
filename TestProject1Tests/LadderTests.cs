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

        [Test]
        public void GetNameofLastPlayerInList()
        {
            Ladder ladder = new Ladder();

            string name = "Test";
            ladder.AddPlayer(name, eRankNumber.rank10kyu, eRungPosition.rungPositionMiddle);

            List<Player> pList = ladder.get_PlayerList();

            string listName = pList.ElementAt(0).get_name();
            Assert.AreEqual(name, listName);
        }

        [Test]
        public void SuccessfulAdditionOfPlayerReturnsTrue()
        {
            Ladder ladder = new Ladder();

            string name = "Test";
            bool result = ladder.AddPlayer(name, eRankNumber.rank10kyu, eRungPosition.rungPositionMiddle);

            Assert.IsTrue(result);
        }

        [Test]
        public void RemovePlayerDeletesPlayerFromList()
        {
            Ladder ladder = new Ladder();

            string name = "Test";
            bool result = ladder.AddPlayer(name, eRankNumber.rank10kyu, eRungPosition.rungPositionMiddle);

            ladder.RemovePlayer(1);
            List<Player> pList = ladder.get_PlayerList();
            Assert.IsEmpty(pList);
        }

        [Test]
        public void FindPlayerFromListWithName()
        {
            Ladder ladder = new Ladder();

            string name = "Test";
            bool result = ladder.AddPlayer(name, eRankNumber.rank10kyu, eRungPosition.rungPositionMiddle);
            string partialName = "Tes";
            
            List<Player> pList = ladder.findPlayers(partialName);
            
            Assert.IsNotEmpty(pList);
            string listName = pList.ElementAt(0).get_name();
            Assert.AreEqual(name, listName);
        }

        [Test]
        public void FindPlayerFromListWithRank()
        {
            Ladder ladder = new Ladder();

            string name = "Test";
            eRankNumber rank = eRankNumber.rank5Dan;
            bool result = ladder.AddPlayer(name, rank, eRungPosition.rungPositionMiddle);
            
            List<Player> pList = ladder.findPlayers(rank);

            Assert.IsNotEmpty(pList);
            string listName = pList.ElementAt(0).get_name();
            Assert.AreEqual(name, listName);
        }

        [Test]
        public void FindMultiplePlayersFromListWithSameRank()
        {
            Ladder ladder = new Ladder();

            string name1 = "Test1";
            string name2 = "Test2";
            string name3 = "Test3";
            eRankNumber rank1 = eRankNumber.rank5Dan;
            eRankNumber rank2 = eRankNumber.rank4Dan;
            eRankNumber rank3 = eRankNumber.rank5Dan;

            ladder.AddPlayer(name1, rank1, eRungPosition.rungPositionMiddle);
            ladder.AddPlayer(name2, rank2, eRungPosition.rungPositionMiddle);
            ladder.AddPlayer(name3, rank3, eRungPosition.rungPositionMiddle);

            List<Player> pList = ladder.findPlayers(rank1);

            Assert.AreEqual(2, pList.Count);
            string listName = pList.ElementAt(0).get_name();
            Assert.AreEqual(name1, listName);
            listName = pList.ElementAt(1).get_name();
            Assert.AreEqual(name3, listName);
        }

        [Test]
        public void DeletingMiddlePlayerInListKeepsOthers()
        {
            Ladder ladder = new Ladder();

            string name1 = "Test1";
            string name2 = "Test2";
            string name3 = "Test3";
            eRankNumber rank1 = eRankNumber.rank5Dan;
            eRankNumber rank2 = eRankNumber.rank4Dan;
            eRankNumber rank3 = eRankNumber.rank5Dan;

            ladder.AddPlayer(name1, rank1, eRungPosition.rungPositionMiddle);
            ladder.AddPlayer(name2, rank2, eRungPosition.rungPositionMiddle);
            ladder.AddPlayer(name3, rank3, eRungPosition.rungPositionMiddle);
            ladder.RemovePlayer(2);

            List<Player> pList = ladder.get_PlayerList();

            Assert.AreEqual(2, pList.Count);
            string listName = pList.ElementAt(0).get_name();
            Assert.AreEqual(name1, listName);
            listName = pList.ElementAt(1).get_name();
            Assert.AreEqual(name3, listName);
        }

    }
}