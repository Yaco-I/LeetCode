using LeetCode.Algorithms;

namespace LeetCode.Test._501_600;

[TestClass]
public class UnitTest557_ReverseWordsInAStringIII
{
    [TestMethod]
    public void TestMethodReverseWords()
    {
        var input = "Let's take LeetCode contest";
        var output = "s'teL ekat edoCteeL tsetnoc";

        var result = ReverseWordsInAStringIII.ReverseWords(input);
        Assert.AreEqual(output, result);
        
    }
}
