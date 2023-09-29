using LeetCode.Algorithms.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Test
{
    [TestClass]
    public class UnitTest9_PalindromeNumber
    {
        [TestMethod]
        public void TestMethod_PalindromeNumberMethod()
        {
            Assert.IsTrue(PalindromeNumber.PalindromeNumberMethod(121));
            Assert.IsFalse(PalindromeNumber.PalindromeNumberMethod(-121));
            Assert.IsFalse(PalindromeNumber.PalindromeNumberMethod(10));
        }
    }
}
