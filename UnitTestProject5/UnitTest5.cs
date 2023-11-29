using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using zadacha5;

namespace UnitTestProject5
{
    [TestClass]
    public class UnitTest5
    {
        [TestMethod]
        public void TestMethod1()
        {
            string positiveInteger = "12345";
            int result = DigitSumCalculator.CalculateDigitSum(positiveInteger);
            Assert.AreEqual(15, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestMethod2()
        {
            string nonDigitInput = "12a34";
            int result = DigitSumCalculator.CalculateDigitSum(nonDigitInput);
        }
    }
}
