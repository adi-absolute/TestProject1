﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Project1;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Runtime.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Project1
{
    [TestClass]
    public class DataManagerTests
    {
        [TestMethod]
        public void SetAndGetName()
        {
            DataManager fm = new DataManager();
            string fName = "sdrfs.gls";
            fm.name = fName;
            string result = fm.name;

            Assert.AreEqual(fName, result);
        }

        [TestMethod]
        public void SetAndGetNameWithoutExtension()
        {
            DataManager fm = new DataManager();
            string fName = "sdrfs";
            string fExt = DataManager.fileExtension;
            string a = fName;
            fm.name = a;

            string result = fm.name;

            Assert.AreEqual(fName + fExt, result);
        }

        [TestMethod]
        public void SaveLadder()
        {
            DataManager dm = new DataManager();
            string fileName = "SaveLadderTest.gls";

            dm.name = fileName;

            Ladder lad = new Ladder();
            lad.AddPlayer("First", eRankNumber.rank11kyu, eRungPosition.rungPositionFirst);

            dm.Save(lad);

            FileStream fs = new FileStream(fileName, FileMode.Open);
            
            XmlDictionaryReader reader =
                XmlDictionaryReader.CreateTextReader(fs, new XmlDictionaryReaderQuotas());
            
            DataContractSerializer ser = new DataContractSerializer(typeof(Ladder));

            // Deserialize the data and read it from the instance.
            Ladder readLadder =
                (Ladder)ser.ReadObject(reader, true);
            
            //reader.Close();
            fs.Close();

            Assert.AreEqual(1, readLadder.get_NumberOfPlayers());
        }
    }
}
