using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary1;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void Test_Assignment()
        {
            AssignmentClass assignmentClass = new AssignmentClass();
            int input = 33;

            string result = assignmentClass.greadCalculate(input);
            Assert.AreEqual("F", result);
        }
        [TestMethod]
        public void Test_Assignment2()
        {
            AssignmentClass ac = new AssignmentClass();
            double result = ac.getdistance(3, 2, 7, 8);
            Assert.AreEqual(7.21, result);
            result = ac.getdistance(-3, 2, 7, -8);
            Assert.AreEqual(14.14, result);
            result = ac.getdistance(-3, -2, -7, -8);
            Assert.AreEqual(7.21, result);
            result = ac.getdistance(3, -2, -7, 8);
            Assert.AreEqual(14.14, result);

        }
        [TestMethod]
        public void Test_Assignment3()
        {
            AssignmentClass ac = new AssignmentClass();
            int result = ac.getFactorial(5);
            Assert.AreEqual(120, result);
            result = ac.getFactorial(1);
            Assert.AreEqual(1, result);
            result = ac.getFactorial(0);
            Assert.AreEqual(1, result);
            result = ac.getFactorial(0);
            Assert.AreEqual(1, result);

        }
        [TestMethod]
        public void Test_Assignment4()
        {
            AssignmentClass ac = new AssignmentClass();
            string Password1 = "abc";
            int Password2 = 123;
            string Password13 = Convert.ToString(Password1);
            bool Password = ac.checkPassword(Password1, Password13);
        }
    }
}
