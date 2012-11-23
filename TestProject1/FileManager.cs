using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Project1
{
    public class FileManager
    {
        private string sName;
        public string name
        {
            get
            {
                return sName;
            }
            set
            {
                if (value.Contains(".gop"))
                {
                    string vs = Path.GetFileNameWithoutExtension(value);
                    sName = vs;
                }
                else
                {
                    sName = value;
                }
            }
        }

        public void Save(string fName, Ladder ladder)
        {
            //List<Player> list = ladder.get_PlayerList();


        }
    }
}
