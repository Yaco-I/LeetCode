using LeetCode.Algorithms;

namespace LeetCode.Test;

[TestClass]
public class UnitTest0026_RemoveElements
{
    [TestMethod]
    public void MethodTest_RemoveElements()
    {
        var list = new int[]{0, 0, 1, 1, 1, 2, 2, 3, 3, 4};
        var result = RemoveElements.RemoveElementMethod(list);
        Assert.AreEqual(5, result);
    }
}
