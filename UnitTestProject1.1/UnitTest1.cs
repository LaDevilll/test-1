using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using _1._1;

namespace UnitTestProject1._1
{
    [TestClass]
    public class NNNTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            int n = 5;
            string result = NNN.Naidi(n);
            Assert.AreEqual("ABCDE", result);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestMethod12()
        {
            int n = 27;
            string result = NNN.Naidi(n);
        }
    }
}
