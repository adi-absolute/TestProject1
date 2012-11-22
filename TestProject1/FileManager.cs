using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project1
{
    public class FileManager
    {
        public string name { get; set; }
        //{
        //    get 
        //    {
        //        return name;
        //    }
        //    set
        //    {
        //        //if (value.Contains(".gop"))
        //        //{
        //            //int location = value.IndexOf(".");
        //            //value.Remove(location);
        //            //name = value;
        //        //}
        //        //else
        //            name = value;
        //    }
        //}

        public void Save(string fName, Ladder ladder)
        {
            List<Player> list = ladder.get_PlayerList();


        }
    }
}
