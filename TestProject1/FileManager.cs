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
        private string sName;
        public string name
        {
            get
            {
                return sName;
            }
            set
            {
                if (value.Contains(fileExtension))
                    sName = value;
                else
                    sName = value + fileExtension;
            }
        }

        public void Save(Ladder ladder)
        {
            List<Player> list = ladder.get_PlayerList();

            File.WriteAllText(sName, "$Player");

            for (int i = 0; i < list.Count; i++)
            {
                File.AppendAllText(sName, Environment.NewLine);
                File.AppendAllText(sName, list[i].myName);
                File.AppendAllText(sName, Environment.NewLine);
                File.AppendAllText(sName, list[i].GetRankNumber().ToString());
                File.AppendAllText(sName, Environment.NewLine);
                File.AppendAllText(sName, list[i].GetRungPosition().ToString());
            }

            File.AppendAllText(sName, Environment.NewLine);
            File.AppendAllText(sName, "$Game");

        }
    }
}
