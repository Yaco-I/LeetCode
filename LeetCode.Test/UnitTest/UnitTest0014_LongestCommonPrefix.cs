using LeetCode.Algorithms;

namespace LeetCode.Test.UnitTest;

[TestClass]
public class UnitTest0014_LongestCommonPrefix
{
    [TestMethod]
    public void TestMethod1()
    {
        // Arrange
        var input = new string[] { "flower", "flow", "flight" };
        var expected = "fl";

        // Act
        var actual = LongestCommonPrefix.LongestCommonPrefixMethod(input);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
