using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CP4.Trigonom;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFactorial()
        {
            Assert.AreEqual(24, TrigFunc.Factorial(4));
        }
        [TestMethod]
        public void TestPower()
        {
            Assert.AreEqual(25, TrigFunc.Power(5, 2));
        }
        [TestMethod]
        public void TestAbs()
        {
            Assert.AreEqual(24, TrigFunc.Abs(24));
        }


            [TestMethod]
        public void TestSin()
        {
           Assert.AreEqual(Math.Round(Math.Sin(60 * Math.PI / 180), 4), Math.Round(TrigFunc.Sin(60 * Math.PI / 180), 4));
        }
        [TestMethod]
        public void TestCos()
        {
            Assert.AreEqual(Math.Round(Math.Cos(60 * Math.PI / 180), 4), Math.Round(TrigFunc.Cos(60 * Math.PI / 180), 4));
        }
        [TestMethod]
        public void TestCoSec()
        {
            Assert.AreEqual(Math.Round(1 / Math.Sin(60 * Math.PI / 180), 4), Math.Round(1/TrigFunc.Sin(60 * Math.PI / 180), 4));
        }
        [TestMethod]
        public void TestCoTan()
        {
            Assert.AreEqual(Math.Round(1/Math.Tan(60 * Math.PI / 180), 4), Math.Round(TrigFunc.CoTan(60 * Math.PI / 180), 4));
        }
        [TestMethod]
        public void TestSum()
        {
            Assert.AreEqual(24, TrigFunc.Factorial(4));
        }
        [TestMethod]
        public void TestLnxx()
        {
            Assert.AreEqual(Math.Round(Math.Log(1 - Math.E), 4), Math.Round(TrigFunc.Lnxx(1 - Math.E), 4));
        }
    }
}
