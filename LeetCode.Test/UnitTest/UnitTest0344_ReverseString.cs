using LeetCode.Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Test.UnitTest
{
    [TestClass]
    public class UnitTest0344_ReverseString
    {
        [TestMethod]
        public void TestMethod()
        {
            char[] arr = { 'h', 'e', 'l', 'l', 'o' };
            char[] expected = { 'o', 'l', 'l', 'e', 'h' };

            ReverseString.ReverseStringMethod(arr);

            Assert.AreEqual(arr.Length, expected.Length);

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], arr[i]);

            }
        }
    }
}
