using LeetCode.Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Test.UnitTest
{
    [TestClass]
    public class UnitTest0075_SortColors
    {
        [TestMethod]
        public void TestMethod()
        {
            var nums = new int[] { 2, 0, 2, 1, 1, 0 };
            SortColors.SortColorsMethod(nums);
            var expected = new int[] { 0, 0, 1, 1, 2, 2 };
            Assert.AreEqual(expected.Length, nums.Length);
        }
    }
}
