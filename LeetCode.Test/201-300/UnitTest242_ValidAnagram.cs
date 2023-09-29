﻿using LeetCode.Algorithms.Easy._201_300;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Test._201_300
{
    [TestClass]
    public class UnitTest242_ValidAnagram
    {
        [TestMethod]
        public void TestMethod_IsAnagram()
        {
            Assert.IsTrue(ValidAnagram.IsAnagram("anagram", "nagaram"));
            Assert.IsFalse(ValidAnagram.IsAnagram("rat", "car"));
        }

    }
}
