using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Project1;
using System.IO;
using System.Windows.Forms;
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
                FileManager.playerSeparator,
                FileManager.gameSeparator
            };

            string[] actualFile = File.ReadAllLines(f.name);
            bool result = actualFile[0].Equals(expectedFile[0]);
            Assert.AreEqual(true, result);
            result = actualFile[1].Equals(expectedFile[1]);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void SaveLadderToFileWithOnePlayerName()
        {
            Ladder ladder = new Ladder();
            FileManager f = new FileManager();
            f.name = "filename.gls";
            
            ladder.AddPlayer("First", eRankNumber.rank10kyu, eRungPosition.rungPositionFirst);

            f.Save(ladder);

            string[] expectedFile = 
            {
                FileManager.playerSeparator,
                "First",
                ILadder.rankMap[(int)eRankNumber.rank10kyu],
                ILadder.rungMap[(int)eRungPosition.rungPositionFirst],
                FileManager.gameSeparator
            };

            string[] actualFile = File.ReadAllLines(f.name);
            
            for (int i = 0; i < expectedFile.Length; i++)
            {
                bool result = actualFile[i].Equals(expectedFile[i]);
                Assert.AreEqual(true, result);
            }
        }

        [TestMethod]
        public void SaveLadderToFileWithMultiplePlayerNames()
        {
            Ladder ladder = new Ladder();
            FileManager f = new FileManager();
            f.name = "filename.gls";

            ladder.AddPlayer("First", eRankNumber.rank10kyu, eRungPosition.rungPositionFirst);
            ladder.AddPlayer("Second", eRankNumber.rank1kyu, eRungPosition.rungPositionSecond);
            ladder.AddPlayer("Third", eRankNumber.rank1Dan, eRungPosition.rungPositionThird);

            f.Save(ladder);

            string[] expectedFile = 
            {
                FileManager.playerSeparator,
                "First",
                ILadder.rankMap[(int)eRankNumber.rank10kyu],
                ILadder.rungMap[(int)eRungPosition.rungPositionFirst],
                "Second",
                ILadder.rankMap[(int)eRankNumber.rank1kyu],
                ILadder.rungMap[(int)eRungPosition.rungPositionSecond],
                "Third",
                ILadder.rankMap[(int)eRankNumber.rank1Dan],
                ILadder.rungMap[(int)eRungPosition.rungPositionThird],
                FileManager.gameSeparator
            };

            string[] actualFile = File.ReadAllLines(f.name);

            for (int i = 0; i < expectedFile.Length; i++)
            {
                bool result = actualFile[i].Equals(expectedFile[i]);
                Assert.AreEqual(true, result);
            }
        }

        [TestMethod]
        public void LoadingLadderSavesNameIfFileExists()
        {
            Ladder ladder = new Ladder();
            FileManager f = new FileManager();
            f.name = "filename.gls";

            ladder.AddPlayer("First", eRankNumber.rank10kyu, eRungPosition.rungPositionFirst);

            f.Save(ladder);

            FileManager f2 = new FileManager();
            Ladder l2 = f2.Load(f.name);

            Assert.AreEqual(f.name, f2.name);
        }



        [TestMethod]
        public void LoadingLadderDoesNotSaveNameIfFileDoesNotExist()
        {
            FileManager f = new FileManager();
            string fName = "filename_dne.gls";

            Ladder ladder = f.Load(fName);

            Assert.AreEqual(null, f.name);
            Assert.AreEqual(null, ladder);
        }

        [TestMethod]
        public void IncompleteFileReturnsNull()
        {
            FileManager f = new FileManager();
            string fName = "filename_load1.gls";

            string[] savedText =                 
            {
                FileManager.playerSeparator,
                "First",
            };

            File.WriteAllLines(fName, savedText);

            Ladder ladder = f.Load(fName);

            Assert.AreEqual(null, ladder);
            
        }

        [TestMethod]
        public void LoadSavedFileToLadder()
        {
            Ladder ladder = new Ladder();
            FileManager f = new FileManager();
            string fName = "filename_load1.gls";
            f.name = fName;

            ladder.AddPlayer("First", eRankNumber.rank10kyu, eRungPosition.rungPositionFirst);

            f.Save(ladder);

            FileManager f2 = new FileManager();
            Ladder l2 = f2.Load(fName);

            Assert.AreEqual(1, l2.get_NumberOfPlayers());
            
            List<Player> pList = l2.get_PlayerList();
            Assert.AreEqual("First", pList[0].myName);
        }
    }
}
