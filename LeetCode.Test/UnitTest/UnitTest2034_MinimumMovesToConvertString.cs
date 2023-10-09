using LeetCode.Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Test.UnitTest
{
    [TestClass]
    public class UnitTest2034_MinimumMovesToConvertString
    {
        [TestMethod]
        public void UnitTest2034_MinimumMoves()
        {
            string s = "XXX";
            int expected = 1;
            int actual = MinimumMovesToConvertString.MinimumMoves(s);
            Assert.AreEqual(expected, actual);
        }
    }
}
