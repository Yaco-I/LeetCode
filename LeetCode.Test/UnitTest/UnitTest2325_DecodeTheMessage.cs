using LeetCode.Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Test.UnitTest
{
    [TestClass] 
    public class UnitTest2325_DecodeTheMessage
    {
        [TestMethod]
        public void TestMethod_DecodeMessage()
        {
            var key = "the quick brown fox jumps over the lazy dog";
            var message = "vkbs bs t suepuv";
            var expected = "this is a secret";
            var actual = DecodeTheMessage.DecodeMessage(key, message);
            Assert.AreEqual(expected, actual);
        }
    }
}
