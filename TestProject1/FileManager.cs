using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Project1
{
    public class FileManager
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
            List<Player> list = ladder.get_PlayerList();

            File.WriteAllText(fileName, playerSeparator);

            for (int i = 0; i < list.Count; i++)
            {
                File.AppendAllText(fileName, Environment.NewLine);
                File.AppendAllText(fileName, list[i].myName);
                File.AppendAllText(fileName, Environment.NewLine);
                File.AppendAllText(fileName, ILadder.rankMap[(int)list[i].GetRankNumber()]);
                File.AppendAllText(fileName, Environment.NewLine);
                File.AppendAllText(fileName, ILadder.rankMap[(int)list[i].GetRungPosition()]);
            }

            File.AppendAllText(fileName, Environment.NewLine);
            File.AppendAllText(fileName, gameSeparator);
        }

        public Ladder Load(string fName)
        {
            if (File.Exists(fName) == false)
                return null;

            bool integrity = true;
            int counter = 0;
            Ladder l = new Ladder();

            fileName = fName;

            string[] readLine = File.ReadAllLines(fName);

            if (readLine[counter++] != playerSeparator)
                integrity = false;

            bool stayInLoop = true;
            while (integrity && stayInLoop)
            {
                string pName = readLine[counter++];
                //eRankNumber rank = (eRankNumber)readLine[counter++];
            }

            

            return l;
        }
    }
}
