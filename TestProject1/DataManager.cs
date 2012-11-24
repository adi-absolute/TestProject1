﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.Xml;

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

        public void Save(Ladder ladder)
        {
            DataContractSerializer d = new DataContractSerializer(ladder.GetType());
            FileStream writer = new FileStream(fileName, FileMode.Create);

            d.WriteObject(writer, ladder);
            writer.Close();
        }
    }
}
