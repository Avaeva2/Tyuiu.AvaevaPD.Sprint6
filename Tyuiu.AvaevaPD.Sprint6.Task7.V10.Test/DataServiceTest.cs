using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AvaevaPD.Sprint6.Task7.V10.Lib;
using System.IO;

namespace Tyuiu.AvaevaPD.Sprint6.Task7.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Asus\source\repos\Tyuiu.AvaevaPD.Sprint6\Tyuiu.AvaevaPD.Sprint6.Task7.V10\bin\Debug\InPutFileTask7V10.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
