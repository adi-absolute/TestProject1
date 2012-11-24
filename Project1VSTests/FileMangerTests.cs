using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Project1;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Project1
{
    [TestClass]
    public class FileMangerTests
    {
        [TestMethod]
        public void SetAndGetName()
        {
            FileManager fm = new FileManager();
            string fName = "sdrfs.gls";
            fm.name = fName;
            string result = fm.name;

            Assert.AreEqual(fName, result);
        }
        
        [TestMethod]
        public void SetAndGetNameWithoutExtension()
        {
            FileManager fm = new FileManager();
            string fName = "sdrfs";
            string fExt = FileManager.fileExtension;
            string a = fName;// +fExt;
            fm.name = a;

            string result = fm.name;

            Assert.AreEqual(fName + fExt, result);
        }

        [TestMethod]
        public void EmptyLadderSetsAtLeastThePlayerAndGameHeaders()
        {
            Ladder ladder = new Ladder();
            FileManager f = new FileManager();
            f.name = "filename.gls";

            f.Save(ladder);

            string[] expectedFile = 
            {
                "$Player",
                "$Game"
            };

            string[] actualFile = File.ReadAllLines(f.name);
            bool result = actualFile[0].Equals(expectedFile[0]);
            Assert.AreEqual(true, result);
            result = actualFile[1].Equals(expectedFile[1]);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void SaveLadderToFileWithPlayerNames()
        {
            Ladder ladder = new Ladder();
            FileManager f = new FileManager();
            f.name = "filename.gls";
            
            ladder.AddPlayer("First", eRankNumber.rank10kyu, eRungPosition.rungPositionFirst);

            f.Save(ladder);

            string[] expectedFile = 
            {
                "$Player",
                "First",
                eRankNumber.rank10kyu.ToString(),
                eRungPosition.rungPositionFirst.ToString(),
                "$Game"
            };

            string[] actualFile = File.ReadAllLines(f.name);
            
            for (int i = 0; i < expectedFile.Length; i++)
            {
                bool result = actualFile[i].Equals(expectedFile[i]);
                Assert.AreEqual(true, result);
            }

            //Assert.AreEqual(expectedFile, actualFile);
            
        }
    }
}
