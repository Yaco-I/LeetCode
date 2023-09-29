using LeetCode.Algorithms.Easy._301_400;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Test
{
    [TestClass]
    public static class UnitTest389_FindTheDifference
    {
        [TestMethod]
        public static void TestMethod_FindTheDifference()
        {
            Assert.AreEqual('e', FindTheDifference.FindTheDifferenceMethod("abcd", "abcde"));
            Assert.AreEqual('y', FindTheDifference.FindTheDifferenceMethod("","y"));
        }
    }
}
