﻿using LeetCode.Algorithms;

namespace LeetCode.Test.UnitTest;

[TestClass]
public class UnitTest896_MonotonicArray
{
    [TestMethod]
    public void TestMethod_IsMonotonicArray()
    {
        int[] nums = new int[] { 1, 2, 2, 3 };
        var result = MonotonicArray.IsMonotonic(nums);


        int[] nums2 = new int[] { 6, 5, 4, 4 };
        var result2 = MonotonicArray.IsMonotonic(nums2);

        int[] nums3 = new int[] { 1, 3, 2 };
        var result3 = MonotonicArray.IsMonotonic(nums3);


        Assert.IsTrue(result);
        Assert.IsTrue(result2);
        Assert.IsFalse(result3);
    }
}
