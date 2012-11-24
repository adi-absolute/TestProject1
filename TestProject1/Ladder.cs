using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Project1
{
    [DataContract(Name = "Ladder", Namespace = "Project1")]
    public class Ladder : IExtensibleDataObject
    {
        [DataMember()]
        int myLastPlayerID;
        [DataMember()]
        int myLastGameID;
        [DataMember()]
        List<Player> myPlayerList = new List<Player>();
        [DataMember()]
        List<Game> myGameList = new List<Game>();

        public int get_NumberOfPlayers()
        {
            return (int)myPlayerList.Count;
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

        public bool RemovePlayer(int id)
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

        public int get_NumberOfGames()
        {
            return (int)myGameList.Count;
        }

        public void AddGame(Game game)
        {
            myLastGameID++;

            game.GameID = myLastGameID;
            myGameList.Add(game);
        }

        public Game get_Game(int id)
        {
            Game game = myGameList.Find(g => id == g.GameID);
            
            return game;
        }

        /*For Serialising*/

        private ExtensionDataObject extensionData_Value;

        public ExtensionDataObject ExtensionData
        {
            get
            {
                return extensionData_Value;
            }
            set
            {
                extensionData_Value = value;
            }
        }
    }
}
