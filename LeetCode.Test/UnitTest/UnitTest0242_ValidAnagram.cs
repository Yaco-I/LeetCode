using LeetCode.Algorithms;

namespace LeetCode.Test.UnitTest;

[TestClass]
public class UnitTest0242_ValidAnagram
{
    [TestMethod]
    public void TestMethod_IsAnagram()
    {
        Assert.IsTrue(ValidAnagram.IsAnagram("anagram", "nagaram"));
        Assert.IsFalse(ValidAnagram.IsAnagram("rat", "car"));
    }

}
