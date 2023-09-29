using LeetCode.Algorithms.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Test
{
    //TODO: Add tests
    [TestClass]
    public class UnitTest392_IsSubsequence
    {
        [TestMethod]
        public void TestMethod_IsSubsequence()
        {
            Assert.IsTrue(IsSubsequence.IsSubsequenceMethod("abc", "ahbgdc"));
            Assert.IsFalse(IsSubsequence.IsSubsequenceMethod("axc", "ahbgdc"));
        }
    }
}
