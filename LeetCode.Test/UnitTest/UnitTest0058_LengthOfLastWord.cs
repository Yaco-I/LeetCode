﻿using LeetCode.Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Test.UnitTest;

[TestClass]
public class UnitTest0058_LengthOfLastWord
{
    [TestMethod]
    public void TestMethod1()
    {
        var input = "Hello World";
        var expected = 5;
        var actual = LengthOfLastWord.LengthOfLastWordMethod(input);
        Assert.AreEqual(expected, actual);
    }
}
