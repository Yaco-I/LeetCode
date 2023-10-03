using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.Algorithms;

namespace LeetCode.Test
{
    [TestClass]
    public class UnitTest0118_PascalsTriangle
    {
        [TestMethod]
        public void TestMethod_PascalsTriangle1()
        {
            int numRows = 5;
            IList<IList<int>> expected = new List<IList<int>>();
            expected.Add(new List<int>() { 1 });
            expected.Add(new List<int>() { 1, 1 });
            expected.Add(new List<int>() { 1, 2, 1 });
            expected.Add(new List<int>() { 1, 3, 3, 1 });
            expected.Add(new List<int>() { 1, 4, 6, 4, 1 });
            IList<IList<int>> actual = PascalsTriangle.Generate(numRows);
            CollectionAssert.AreEqual(expected[0].ToList(), actual[0].ToList());
            CollectionAssert.AreEqual(expected[1].ToList(), actual[1].ToList());
            CollectionAssert.AreEqual(expected[2].ToList(), actual[2].ToList());
            CollectionAssert.AreEqual(expected[3].ToList(), actual[3].ToList());
            CollectionAssert.AreEqual(expected[4].ToList(), actual[4].ToList());
        }   
    }
}
