using LeetCode.Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Test.UnitTest
{
    [TestClass]
    public class UnitTest2278_PercentageOfLetterInString
    {
        [TestMethod]
        public void TestMethod1()
        {
            string s = "Hello World";
            char letter = 'l';
            int expected = 3;
            int actual = PercentageOfLetterInString.PercentageLetter(s, letter);
            Assert.AreEqual(expected, actual);
        }
    }
}
