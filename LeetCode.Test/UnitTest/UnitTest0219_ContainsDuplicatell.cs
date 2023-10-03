using LeetCode.Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Test
{
    [TestClass]
    public class UnitTest0219_ContainsDuplicatell
    {
        [TestMethod]
        public void TestMethod_ContainsDuplicateMethod()
        {
            Assert.IsTrue(ContainsDuplicateII.ContainsNearbyDuplicate(new int[] { 1, 2, 3, 1 },3));
            Assert.IsTrue(ContainsDuplicateII.ContainsNearbyDuplicate(new int[] { 1, 0, 1, 1 }, 1));
            Assert.IsFalse(ContainsDuplicateII.ContainsNearbyDuplicate(new int[] { 1, 2, 3, 1, 2, 3 }, 2));
        }
    }
}
