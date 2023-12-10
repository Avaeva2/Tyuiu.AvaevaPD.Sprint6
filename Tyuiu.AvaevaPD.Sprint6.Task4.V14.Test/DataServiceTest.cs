using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AvaevaPD.Sprint6.Task4.V14.Lib;
namespace Tyuiu.AvaevaPD.Sprint6.Task4.V14.Test
{
    [TestClass]
    public class DataServiceTest

    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            int len = ds.GetMassFunction(startValue, stopValue).Length;

            double[] valueWaitArray = new double[len];


            valueWaitArray[0] = -19.62;
            valueWaitArray[1] = -17.12;
            valueWaitArray[2] = -18.15;
            valueWaitArray[3] = -63.13;
            valueWaitArray[4] = -24.92;
            valueWaitArray[5] = -5;
            valueWaitArray[6] = -1.46;
            valueWaitArray[7] = 1.57;
            valueWaitArray[8] = 6.38;
            valueWaitArray[9] = 32.78;
            valueWaitArray[10] = 225.11;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);



            CollectionAssert.AreEqual(valueWaitArray, res);

        }
    }
}
