using LeetCode.Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Test.UnitTest
{
    [TestClass]
    public class UnitTest0342_PowerOfFour
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            int n = 16;
            bool expected = true;

            // Act
            bool actual = PowerOfFour.IsPowerOfFour(n);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
