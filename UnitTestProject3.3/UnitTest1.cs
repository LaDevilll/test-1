using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using zadacha3._3;

namespace UnitTestProject3._3
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void TestMethod1()
        {
            int leapYear = 2020;
            int result = YearDaysCalculator.CalculateDaysInYear(leapYear);
            Assert.AreEqual(366, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int nonLeapYear = 2021;
            int result = YearDaysCalculator.CalculateDaysInYear(nonLeapYear);
            Assert.AreEqual(365, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestMethod3()
        {
            int negativeYear = -2022;
            int result = YearDaysCalculator.CalculateDaysInYear(negativeYear);
        }
    }
}
