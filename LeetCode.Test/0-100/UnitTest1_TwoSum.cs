using LeetCode.Algorithms.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Test
{
    [TestClass]
    public class UnitTest1_TwoSum
    {
        
        [TestMethod]
        public void TestMethodTwoSum() {
           
            int[] nums = { 2, 7, 11, 15 };
            int[] result = TwoSum.TwoSumMethod(nums, 9);
            Assert.AreEqual(0, result[0]);
            Assert.AreEqual(1, result[1]);
        }
    }
}
