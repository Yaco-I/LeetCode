using LeetCode.Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Test.UnitTest
{
    [TestClass]
    public class UnitTest0007_ReverseInteger
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            int x = 123;
            int expected = 321;

            int actual = ReverseInteger.Reverse(x);
            // Assert
            Assert.AreEqual(expected, actual);


            x = -2147483648;
            expected = 0;
            actual = ReverseInteger.Reverse(x);
            // Assert
            Assert.AreEqual(expected, actual);


            x = -463847412;
            expected = -214748364;
            actual = ReverseInteger.Reverse(x);
            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
