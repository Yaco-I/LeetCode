using LeetCode.Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Test.UnitTest
{
    [TestClass]
    public class UnitTest0038_CountAndSay
    {
        [TestMethod]
        public void Method_CountAndSayMethod1()
        {
            // Arrange
            int n = 4;
            string expected = "1211";

            // Act
            string actual = CountAndSay.CountAndSayMethod(n);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
