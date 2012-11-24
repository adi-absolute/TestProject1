using System;
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

        public bool Load(string name, out Ladder ladder)
        {
            bool fileExists = File.Exists(name);
            ladder = null;

            if (fileExists)
            {
                FileStream fs = new FileStream(name, FileMode.Open);
                XmlDictionaryReader reader =
                    XmlDictionaryReader.CreateTextReader(fs, new XmlDictionaryReaderQuotas());
                DataContractSerializer ser = new DataContractSerializer(typeof(Ladder));

                ladder = (Ladder)ser.ReadObject(reader, true);
            }

            return fileExists;
        }
    }
}
