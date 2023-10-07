using LeetCode.Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Test.UnitTest
{
    [TestClass]
    public class UnitTest2833_FurthestDistanceFromOrigin
    {
        [TestMethod]
        public void TestMethod1()
        {
            var input = "L_RL__R";
            var expected = 3;
            var actual = FurthestPointFromOrigin.FurthestDistanceFromOrigin(input);
            Assert.AreEqual(expected, actual);
        }
    }
}
