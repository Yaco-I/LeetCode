using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.Algorithms._1501_1600;

namespace LeetCode.Test._1501_1600
{
    [TestClass]
    public class UnitTest1512_NumberOfGoodPairs
    {
        [TestMethod]
        public void TestMethod_NumIdenticalPairsTest()
        {
            var input = new int[] { 1, 2, 3, 1, 1, 3 };
            var output = NumberOfGoodPairs.NumIdenticalPairs(input);
            Assert.AreEqual(4, output);
        }
    }
}
