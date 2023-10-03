using LeetCode.Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Test
{
    [TestClass]
    public class UnitTest905_SortArrayByParity
    {
        [TestMethod]
        public void MethodSortArrayByParity_1()
        {
            int[] nums = { 3, 1, 2, 4 };
            int[] expected = { 2, 4, 3, 1 };
            int[] actual = SortArrayByParity.SortArrayByParityy(nums);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
