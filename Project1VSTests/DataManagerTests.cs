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
            string a = fName;// +fExt;
            fm.name = a;

            string result = fm.name;

            Assert.AreEqual(fName + fExt, result);
        }
    }
}
