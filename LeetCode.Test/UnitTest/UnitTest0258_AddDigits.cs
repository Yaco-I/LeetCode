using LeetCode.Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Test.UnitTest;

[TestClass]
public class UnitTest0258_AddDigits
{
    [TestMethod]
    public void TestMethod_AddDigitsMethod()
    {
        Assert.AreEqual(2, AddDigits.AddDigitsMethod(38));
        Assert.AreEqual(0, AddDigits.AddDigitsMethod(0));
    }
}
