using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using zadacha2;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod21()
        {
            double a = 1;
            double b = -3;
            double c = 2;
            double[] result = Class1.Naidi2(a, b, c);
            CollectionAssert.AreEqual(new double[] { 2, 1 }, result, Comparer<double>.Default);
        }

        [TestMethod]
        public void TestMethod22()
        {
            double a = 1;
            double b = -2;
            double c = 1;
            double[] result = Class1.Naidi2(a, b, c);
            CollectionAssert.AreEqual(new double[] { 1 }, result, Comparer<double>.Default);
        }

        [TestMethod]
        public void TestMethod23()
        {
            double a = 1;
            double b = 2;
            double c = 5;
            double[] result = Class1.Naidi2(a, b, c);
            CollectionAssert.AreEqual(new double[0], result, Comparer<double>.Default);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestMethod24()
        {
            double a = 0;
            double b = 2;
            double c = 3;
            double[] result = Class1.Naidi2(a, b, c);
        }
    }
}
