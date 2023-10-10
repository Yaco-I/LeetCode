using LeetCode.Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Test.UnitTest
{
    [TestClass]
    public class UnitTest0136_SingleNumber
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            int[] nums = new int[] { 2, 2, 1 };
            int expected = 1;
            
            // Act
            int actual = SingleNumber.SingleNumberMethod(nums);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
