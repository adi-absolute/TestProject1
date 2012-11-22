using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Project1;
using System.IO;
using NUnit.Framework;

namespace Project1
{
    [TestFixture]
    public class FileMangerTests
    {
        [Test]
        public void SetAndGetName()
        {
            FileManager fm = new FileManager();
            string fName = "sdrfs";
            fm.name = fName;
            string result = fm.name;

            Assert.AreEqual(fName, result);
        }
        /*
        [Test]
        public void SetAndGetNameWithExtension()
        {
            FileManager fm = new FileManager();
            string fName = "sdrfs";
            string fExt = ".gop";
            string a = fName + fExt;
            fm.name = a;

            string result = fm.name;

            Assert.AreEqual(fName, result);
        }*/

        [Test, Ignore]
        public void Rename()
        {
            Ladder ladder = new Ladder();
            FileManager f = new FileManager();
            string fName = "filename.gop";

            ladder.AddPlayer("First", eRankNumber.rank10kyu, eRungPosition.rungPositionFirst);

            f.Save(fName, ladder);

            FileStream fs = File.OpenRead(fName);
            TextReader tr = new StreamReader(fs);
            
            //char c = (char)tr.Read();
            char[] buf = new char[100];
            
            tr.Read(buf, 0, 100);
            string b = new string(buf);

            string e = "%%" + fName +
                "%" + (char)eRankNumber.rank10kyu +
                "%" + (char)eRungPosition.rungPositionFirst;

            bool result = b.Equals(e);
            Assert.True(result);
            
        }
    }
}
