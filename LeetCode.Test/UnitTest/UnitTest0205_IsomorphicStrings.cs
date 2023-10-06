using LeetCode.Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Test.UnitTest
{
    [TestClass]
    public class UnitTest0205_IsomorphicStrings
    {
        [TestMethod]
        public void TestMethod_IsIsomorphic()
        {
            var result1 = IsomorphicStrings.IsIsomorphic("egg", "add");
            var result2 = IsomorphicStrings.IsIsomorphic("foo", "bar");
            var result3 = IsomorphicStrings.IsIsomorphic("paper", "title");

            Assert.IsTrue(result1);
            Assert.IsFalse(result2);
            Assert.IsTrue(result3);
        }

    }
}
