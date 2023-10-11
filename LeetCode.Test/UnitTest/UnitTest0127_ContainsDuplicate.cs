using LeetCode.Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Test.UnitTest
{
    [TestClass]
    public class UnitTest0127_ContainsDuplicate
    {
        [TestMethod]
        public void TestMethodContainsDuplicate()
        {
            int[] nums = { 1, 2, 3, 1 };
            bool result = ContainsDuplicate.ContainsDuplicateMethod(nums);
            Assert.AreEqual(true, result);
        }
    }
}
