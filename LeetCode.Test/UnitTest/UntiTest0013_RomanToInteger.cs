using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.Algorithms;

namespace LeetCode.Test.UnitTest
{
    [TestClass]
    public class UntiTest0013_RomanToInteger
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(3, RomanToInteger.RomanToInt("III"));

            Assert.AreEqual(1994, RomanToInteger.RomanToInt("MCMXCIV"));
        }
    }
}
