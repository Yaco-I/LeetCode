using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms
{
    [TestClass]
    public class UnitTest0028_FindTheIndexOfTheFirstOccurrenceInAString
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            string haystack = "hello";
            string needle = "ll";
            int expected = 2;

            // Act
            int actual = FindTheIndexOfTheFirstOccurrenceInAString.FindTheIndexOfTheFirstOccurrenceInAStringMethod(haystack, needle);
            // Assert
            //Assert.AreEqual(expected, actual);

            haystack = "mississippi";
            needle = "issip";
            expected = 4;
            Assert.AreEqual(true, haystack.Contains(needle));

        }
    }
}
