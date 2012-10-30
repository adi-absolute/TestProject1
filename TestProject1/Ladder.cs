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

        public void AddPlayer(string name, eRankNumber rank, eRungPosition rung)
        {
            myNumberOfPlayers++;
            Player newPlayer = new Player(name, rank, rung);
            newPlayer.set_ID(myNumberOfPlayers);

            myPlayerList.Add(newPlayer);
        }
    }
}
