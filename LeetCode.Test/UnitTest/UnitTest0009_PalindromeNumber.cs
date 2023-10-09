using LeetCode.Algorithms;

namespace LeetCode.Test.UnitTest;

[TestClass]
public class UnitTest0009_PalindromeNumber
{
    [TestMethod]
    public void TestMethod_PalindromeNumberMethod()
    {
        Assert.IsTrue(PalindromeNumber.PalindromeNumberMethod(121));
        Assert.IsFalse(PalindromeNumber.PalindromeNumberMethod(-121));
        Assert.IsFalse(PalindromeNumber.PalindromeNumberMethod(10));
    }
}
