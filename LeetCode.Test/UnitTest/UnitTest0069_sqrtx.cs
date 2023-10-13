using LeetCode.Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Test.UnitTest
{
    [TestClass]
    public class UnitTest0069_sqrtx
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            int x = 4;
            int expected = 2;

            // Act
            int actual = sqrtx.MySqrt(x);
            
            Assert.AreEqual(expected, actual);

            x = 2147395600;
            expected = 46340;
            actual = sqrtx.MySqrt(x);

            Assert.AreEqual(expected, actual);
        }
    }
}
