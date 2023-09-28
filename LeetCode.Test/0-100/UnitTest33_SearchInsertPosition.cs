using LeetCode.Algorithms.Easy._0_100;

namespace LeetCode.Test
{
    [TestClass]
    public class UnitTest33_SearchInsertPosition
    {
        [TestMethod]
        public void TestMethodSearchInsert()
        {

            int val1 = SearchInsertPosition.SearchInsert(new int[] { 1, 3, 5, 6 }, 5);
            int val2 = SearchInsertPosition.SearchInsert(new int[] { 1, 3, 5, 6 }, 2);
            int val3 = SearchInsertPosition.SearchInsert(new int[] { 1, 3, 5, 6 }, 7);


            Assert.AreEqual(2, val1);
            Assert.AreEqual(1, val2);
            Assert.AreEqual(4, val3);
        }
    }
}