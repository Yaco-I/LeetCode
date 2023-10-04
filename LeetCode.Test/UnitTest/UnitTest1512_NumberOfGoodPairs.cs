using LeetCode.Algorithms;

namespace LeetCode.Test.UnitTest;

[TestClass]
public class UnitTest1512_NumberOfGoodPairs
{
    [TestMethod]
    public void TestMethod_NumIdenticalPairsTest()
    {
        var input = new int[] { 1, 2, 3, 1, 1, 3 };
        var output = NumberOfGoodPairs.NumIdenticalPairs(input);
        Assert.AreEqual(4, output);
    }
}
