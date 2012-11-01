using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project1
{
    public class Ladder
    {
        UInt16 myNumberOfPlayers;
        List<Player> myPlayerList = new List<Player>();

        public UInt16 get_NumberOfPlayers()
        {
            return myNumberOfPlayers;
        }

        public void set_NumberOfPlayers(UInt16 players)
        {
            myNumberOfPlayers = players;
        }

        public List<Player> get_PlayerList()
        {
            return myPlayerList;
        }

        public bool AddPlayer(string name, eRankNumber rank, eRungPosition rung)
        {
            myNumberOfPlayers++;
            Player newPlayer = new Player(name, rank, rung);
            newPlayer.set_ID(myNumberOfPlayers);

            myPlayerList.Add(newPlayer);

            return true;
        }

        public bool RemovePlayer(UInt16 id)
        {
            Player found = myPlayerList.Find(f => f.get_ID() == id);

            myPlayerList.Remove(found);

            return false;
        }

        public List<Player> findPlayers(string partial)
        {
            List<Player> pList = myPlayerList.FindAll(f => true == f.get_name().Contains(partial));

            return pList;
        }

        public List<Player> findPlayers(eRankNumber rank)
        {
            List<Player> pList = myPlayerList.FindAll(f => rank == f.GetRankNumber());

            return pList;
        }
    }
}
