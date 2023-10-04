using LeetCode.Algorithms;

namespace LeetCode.Test._0_100;

[TestClass]
public class UnitTest0066_PlusOne
{
    [TestMethod]
    public void PlusOneMethod()
    {
        int[] digits = new int[] { 1, 2, 3 };
        int[] expected = new int[] { 1, 2, 4 };
        
        int[] actual = PlusOne.PlusOneMethod(digits);
        CollectionAssert.AreEqual(expected, actual);
    }
}
