using LeetCode.Algorithms;

namespace LeetCode.Test.UnitTest
{
    [TestClass]
    public class UnitTest0231_PowerOfTwo
    {
        [TestMethod]
        public void TestMethod1()
        {
            var input = 1;
            var expected = true;
            var actual = PowerOfTwo.IsPowerOfTwo(input);
            Assert.AreEqual(expected, actual);
        }
    }
}
