using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Test.UnitTest
{
    [TestClass]
    public class UnitTest0034_FindFirstAndLastPositionOfElementInSortedArray
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            var input = new int[] { 5, 7, 7, 8, 8, 10 };
            var target = 8;

            // Act
            var result = LeetCode.Algorithms.FindFirstAndLastPositionOfElementInSortedArray.SearchRange(input, target);

            // Assert
            Assert.AreEqual(3, result[0]);
            Assert.AreEqual(4, result[1]);
        }
    }
}
