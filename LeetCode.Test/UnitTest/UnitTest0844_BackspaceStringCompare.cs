using LeetCode.Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Test.UnitTest
{
    [TestClass]
    public class UnitTest0844_BackspaceStringCompare
    {
        [TestMethod]
        public void TestMethod1()
        {
            string s = "ab#c";
            string t = "ad#c";

            bool result = BackspaceStringCompare.BackspaceCompare(s, t);

            Assert.IsTrue(result);
        }
    }
}
