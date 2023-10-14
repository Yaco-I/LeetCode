using LeetCode.Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Test.UnitTest
{
    [TestClass]
    public class UnitTest500_KeyboardRow
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            string[] words = new string[] { "Hello", "Alaska", "Dad", "Peace" };
            string[] expected = new string[] { "Alaska", "Dad" };

            // Act
            
            string[] actual = KeyboardRow.FindWords(words);

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
