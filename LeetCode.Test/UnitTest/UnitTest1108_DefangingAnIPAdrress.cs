using LeetCode.Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Test.UnitTest;

[TestClass]
public class UnitTest1108_DefangingAnIPAdrress
{
    [TestMethod]
    public void TestMethod1()
    {
        Assert.AreEqual("1[.]1[.]1[.]1", DefangingAnIPAdrress.DefangIPaddr("1.1.1.1"));
    }
}
