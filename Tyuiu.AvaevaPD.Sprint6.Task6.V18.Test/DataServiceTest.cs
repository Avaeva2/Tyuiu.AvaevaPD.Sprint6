using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AvaevaPD.Sprint6.Task6.V18.Lib;
using System.IO;
namespace Tyuiu.AvaevaPD.Sprint6.Task6.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Asus\source\repos\Tyuiu.AvaevaPD.Sprint6\Tyuiu.AvaevaPD.Sprint6.Task6.V18\bin\Debug\InPutFileTask6V18.txt";
            DataService ds = new DataService();

            string res = ds.CollectTextFromFile("n", path);

            string wait = "VAYYbnhDwTg sNnk CMmHkUlnNoZen nqrB";

            Assert.AreEqual(wait, res);
        }
    }
}
