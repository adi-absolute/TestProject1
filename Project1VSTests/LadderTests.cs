using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Project1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Project1
{
    [TestClass]
    public class LadderTests
    {
        [TestMethod]
        public void NumberOfPlayersIsZeroWhenLadderIsCreated()
        {
            Ladder ladder = new Ladder();

            Assert.AreEqual(0, ladder.get_NumberOfPlayers());
        }

        [TestMethod]
        public void AddPlayerToEmptyList()
        {
            Ladder ladder = new Ladder();

            string name = "TestMethod";
            ladder.AddPlayer(name, eRankNumber.rank10kyu, eRungPosition.rungPositionFirst);
            
            Assert.AreEqual(1, ladder.get_NumberOfPlayers());
        }

        [TestMethod]
        public void GetPlayerList()
        {
            Ladder ladder = new Ladder();

            string name = "TestMethod";
            ladder.AddPlayer(name, eRankNumber.rank10kyu, eRungPosition.rungPositionFirst);

            List<Player> pList = ladder.get_PlayerList();

            int numberOfPlayers = pList.Count;
            Assert.AreEqual(1, numberOfPlayers);
        }

        [TestMethod]
        public void GetIDofLastPlayerInList()
        {
            Ladder ladder = new Ladder();

            string name = "TestMethod";
            ladder.AddPlayer(name, eRankNumber.rank10kyu, eRungPosition.rungPositionFirst);

            List<Player> pList = ladder.get_PlayerList();

            int id = pList.ElementAt(0).myID;
            Assert.AreEqual(1, id);
        }

        [TestMethod]
        public void GetNameofLastPlayerInList()
        {
            Ladder ladder = new Ladder();

            string name = "TestMethod";
            ladder.AddPlayer(name, eRankNumber.rank10kyu, eRungPosition.rungPositionFirst);

            List<Player> pList = ladder.get_PlayerList();

            string listName = pList.ElementAt(0).myName;
            Assert.AreEqual(name, listName);
        }

        [TestMethod]
        public void SuccessfulAdditionOfPlayerReturnsTrue()
        {
            Ladder ladder = new Ladder();

            string name = "TestMethod";
            bool result = ladder.AddPlayer(name, eRankNumber.rank10kyu, eRungPosition.rungPositionFirst);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void RemovePlayerDeletesPlayerFromList()
        {
            Ladder ladder = new Ladder();

            string name = "TestMethod";
            bool result = ladder.AddPlayer(name, eRankNumber.rank10kyu, eRungPosition.rungPositionFirst);

            ladder.RemovePlayer(1);
            List<Player> pList = ladder.get_PlayerList();
            Assert.AreEqual(0, pList.Count);
        }

        [TestMethod]
        public void FindPlayerFromListWithName()
        {
            Ladder ladder = new Ladder();

            string name = "TestMethod";
            bool result = ladder.AddPlayer(name, eRankNumber.rank10kyu, eRungPosition.rungPositionFirst);
            string partialName = "Tes";
            
            List<Player> pList = ladder.findPlayers(partialName);
            
            Assert.IsNotNull(pList);
            string listName = pList.ElementAt(0).myName;
            Assert.AreEqual(name, listName);
        }

        [TestMethod]
        public void FindPlayerFromListWithRank()
        {
            Ladder ladder = new Ladder();

            string name = "TestMethod";
            eRankNumber rank = eRankNumber.rank5Dan;
            bool result = ladder.AddPlayer(name, rank, eRungPosition.rungPositionFirst);
            
            List<Player> pList = ladder.findPlayers(rank);

            Assert.IsNotNull(pList);
            string listName = pList.ElementAt(0).myName;
            Assert.AreEqual(name, listName);
        }

        [TestMethod]
        public void FindMultiplePlayersFromListWithSameRank()
        {
            Ladder ladder = new Ladder();

            string name1 = "Test1";
            string name2 = "Test2";
            string name3 = "Test3";
            eRankNumber rank1 = eRankNumber.rank5Dan;
            eRankNumber rank2 = eRankNumber.rank4Dan;
            eRankNumber rank3 = eRankNumber.rank5Dan;

            ladder.AddPlayer(name1, rank1, eRungPosition.rungPositionFirst);
            ladder.AddPlayer(name2, rank2, eRungPosition.rungPositionFirst);
            ladder.AddPlayer(name3, rank3, eRungPosition.rungPositionFirst);

            List<Player> pList = ladder.findPlayers(rank1);

            Assert.AreEqual(2, pList.Count);
            string listName = pList.ElementAt(0).myName;
            Assert.AreEqual(name1, listName);
            listName = pList.ElementAt(1).myName;
            Assert.AreEqual(name3, listName);
        }

        [TestMethod]
        public void DeletingMiddlePlayerInListKeepsOthers()
        {
            Ladder ladder = new Ladder();

            string name1 = "Test1";
            string name2 = "Test2";
            string name3 = "Test3";
            eRankNumber rank1 = eRankNumber.rank5Dan;
            eRankNumber rank2 = eRankNumber.rank4Dan;
            eRankNumber rank3 = eRankNumber.rank5Dan;

            ladder.AddPlayer(name1, rank1, eRungPosition.rungPositionFirst);
            ladder.AddPlayer(name2, rank2, eRungPosition.rungPositionFirst);
            ladder.AddPlayer(name3, rank3, eRungPosition.rungPositionFirst);
            ladder.RemovePlayer(2);

            List<Player> pList = ladder.get_PlayerList();

            Assert.AreEqual(2, pList.Count);
            string listName = pList.ElementAt(0).myName;
            Assert.AreEqual(name1, listName);
            listName = pList.ElementAt(1).myName;
            Assert.AreEqual(name3, listName);
        }

        [TestMethod]
        public void DeletingLastPlayerInListAndAddingPlayerAfterwards()
        {
            Ladder ladder = new Ladder();

            string name1 = "Test1";
            string name2 = "Test2";
            string name3 = "Test3";
            string name4 = "Test4";
            eRankNumber rank1 = eRankNumber.rank5Dan;
            eRankNumber rank2 = eRankNumber.rank4Dan;
            eRankNumber rank3 = eRankNumber.rank3Dan;
            eRankNumber rank4 = eRankNumber.rank2Dan;

            ladder.AddPlayer(name1, rank1, eRungPosition.rungPositionFirst);
            ladder.AddPlayer(name2, rank2, eRungPosition.rungPositionFirst);
            ladder.AddPlayer(name3, rank3, eRungPosition.rungPositionFirst);
            ladder.RemovePlayer(3);
            ladder.AddPlayer(name4, rank4, eRungPosition.rungPositionFirst);
            
            List<Player> pList = ladder.get_PlayerList();

            Assert.AreEqual(3, pList.Count);
            string listName = pList.ElementAt(0).myName;
            Assert.AreEqual(name1, listName);
            listName = pList.ElementAt(2).myName;
            Assert.AreEqual(name4, listName);
        }

        [TestMethod]
        public void NewLadderHasNoGames()
        {
            Ladder ladder = new Ladder();

            int nGames = ladder.get_NumberOfGames();

            Assert.AreEqual(0, nGames);
        }

        [TestMethod]
        public void AddingGamesIncreasesTheCounter()
        {
            Ladder ladder = new Ladder();

            Game g = new Game();
            ladder.AddGame(g);
            int nGames = ladder.get_NumberOfGames();
            Assert.AreEqual(1, nGames);

            ladder.AddGame(g);
            nGames = ladder.get_NumberOfGames();
            Assert.AreEqual(2, nGames);
        }

        [TestMethod]
        public void AddingGamesAutomaticallyAddsGameID()
        {
            Ladder ladder = new Ladder();

            Game g = new Game(0, 5, 3, 2, eResult.whiteWin);
            ladder.AddGame(g);
            int nGames = ladder.get_NumberOfGames();
            Assert.AreEqual(1, nGames);

            Game g2 = ladder.get_Game(1);
            Assert.AreEqual(1, g2.GameID);
        }
    }
}