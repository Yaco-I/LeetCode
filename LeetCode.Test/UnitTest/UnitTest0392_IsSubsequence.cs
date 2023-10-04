using LeetCode.Algorithms;

namespace LeetCode.Test
{
    //TODO: Add tests
    [TestClass]
    public class UnitTest392_IsSubsequence
    {
        [TestMethod]
        public void TestMethod_IsSubsequence()
        {
            Assert.IsTrue(IsSubsequence.IsSubsequenceMethod("abc", "ahbgdc"));
            Assert.IsFalse(IsSubsequence.IsSubsequenceMethod("axc", "ahbgdc"));
        }
    }
}
