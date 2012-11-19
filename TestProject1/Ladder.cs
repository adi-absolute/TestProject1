using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project1
{
    public class Ladder
    {
        uint myLastPlayerID;
        uint myLastGameID;
        List<Player> myPlayerList = new List<Player>();
        List<Game> myGameList = new List<Game>();

        public uint get_NumberOfPlayers()
        {
            return (uint)myPlayerList.Count;
        }

        public List<Player> get_PlayerList()
        {
            return myPlayerList;
        }

        public bool AddPlayer(string name, eRankNumber rank, eRungPosition rung)
        {
            myLastPlayerID++;

            Player newPlayer = new Player(name, rank, rung);
            newPlayer.myID = myLastPlayerID;

            myPlayerList.Add(newPlayer);
            return true;
        }

        public bool RemovePlayer(uint id)
        {
            Player found = myPlayerList.Find(f => f.myID == id);
            myPlayerList.Remove(found);
            return false;
        }

        public List<Player> findPlayers(string partial)
        {
            List<Player> pList = myPlayerList.FindAll(f => true == f.myName.Contains(partial));
            return pList;
        }

        public List<Player> findPlayers(eRankNumber rank)
        {
            List<Player> pList = myPlayerList.FindAll(f => rank == f.GetRankNumber());
            return pList;
        }

        public uint get_NumberOfGames()
        {
            return (uint)myGameList.Count;
        }

        public void AddGame(Game game)
        {
            myLastGameID++;

            game.GameID = myLastGameID;
            myGameList.Add(game);
        }

        public Game get_Game(uint id)
        {
            Game game = myGameList.Find(g => id == g.GameID);
            
            return game;
        }
    }
}
