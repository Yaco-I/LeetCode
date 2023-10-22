using LeetCode.Algorithms;

namespace LeetCode.Test.UnitTest;

[TestClass]
public class UnitTest0415_AddString
{
    [TestMethod]
    public void TestMethod()
    {
        var result = AddString.AddStrings("11", "123");
        Assert.AreEqual(result, "134");


        result = AddString.AddStrings("456", "77");
        Assert.AreEqual(result, "533");

        result = AddString.AddStrings("0", "0");
        Assert.AreEqual(result, "0");

        result = AddString.AddStrings("1", "9");
        Assert.AreEqual("10", result);

        result = AddString.AddStrings("125", "99");
        Assert.AreEqual(result, "224");



    }
}
