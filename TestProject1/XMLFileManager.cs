using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Project1
{
    public class XMLFileManager
    {
        public const string fileExtension = ".gls";
        public const string playerSeparator = "$Player";
        public const string gameSeparator = "$Game";
        private string fileName;
        public string name
        {
            get
            {
                return fileName;
            }
            set
            {
                if (value.Contains(fileExtension))
                    fileName = value;
                else
                    fileName = value + fileExtension;
            }
        }

        public void Save(Ladder ladder)
        {
            /*List<Player> list = ladder.get_PlayerList();

            File.WriteAllText(fileName, playerSeparator);

            for (int i = 0; i < list.Count; i++)
            {
                File.AppendAllText(fileName, Environment.NewLine);
                File.AppendAllText(fileName, list[i].myName);
                File.AppendAllText(fileName, Environment.NewLine);
                File.AppendAllText(fileName, ILadder.rankMap[(int)list[i].GetRankNumber()]);
                File.AppendAllText(fileName, Environment.NewLine);
                File.AppendAllText(fileName, ILadder.rungMap[(int)list[i].GetRungPosition()]);
            }

            File.AppendAllText(fileName, Environment.NewLine);
            File.AppendAllText(fileName, gameSeparator);*/
        }

        public Ladder Load(string fName)
        {/*
            if (File.Exists(fName) == false)
                return null;

            bool integrity = true;
            int counter = 0;
            Ladder localLadder = null;

            fileName = fName;
            
            string[] readLine = File.ReadAllLines(fName);

            if (readLine[counter++] != playerSeparator)
                integrity = false;

            bool gsFound = false;
            while (!gsFound && (counter < readLine.Length))
            {
                if (readLine[counter] == gameSeparator)
                    gsFound = true;
                else
                    counter++;
            }

            if ((gsFound == false) || ((counter - 1) % 3 != 0))
                integrity = false;
            else
            {
                int i = 1;
                localLadder = new Ladder();
                while (i < counter)
                {
                    string pName = readLine[i++];
                    int rankInt = Array.IndexOf(ILadder.rankMap, readLine[i++]);
                    int rungInt = Array.IndexOf(ILadder.rungMap, readLine[i++]);

                    localLadder.AddPlayer(pName, (eRankNumber)rankInt, (eRungPosition)rungInt);
                }
            }

            if (integrity == false)
                localLadder = null;
                
            return localLadder;*/

            return null;
        }
    }
}
