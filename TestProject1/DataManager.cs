using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Project1
{
    public class DataManager
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
    }
}
