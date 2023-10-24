using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.Algorithms;

namespace LeetCode.Test.UnitTest
{
    [TestClass]
    public class UnitTest0012_IntegerToRoman
    {
        [TestMethod]
        public void TestMethod1()
        {
            var input = 3;
            var expected = "III";

            var actual = IntegerToRoman.IntToRoman(input);
            Assert.AreEqual(expected, actual);

            input = 58;
            actual = IntegerToRoman.IntToRoman(input);
            expected = "LVIII";

            Assert.AreEqual(expected, actual);


            input = 1994;
            actual = IntegerToRoman.IntToRoman(input);
            expected = "MCMXCIV";

            Assert.AreEqual(expected, actual);
        }

        
    }
}
