using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using zadacha4;


namespace UnitTestProject4
{
    [TestClass]
    public class EmailValidatorTests4 
    {
        [TestMethod]
        public void TestMethod1()
        {
            string validEmail = "test@test.test";
            bool result = EmailValidator.IsValidEmail(validEmail);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string invalidEmail = "invalid.email";
            bool result = EmailValidator.IsValidEmail(invalidEmail);
            Assert.IsFalse(result);
        }
    }
}
