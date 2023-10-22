
using LeetCode.Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Test.UnitTest
{
    [TestClass]
    public class UnitTest504_Base7
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            int num = 100;
            string expected = "202";

            // Act
            string actual = ConvertToBase7.ConvertToBase7Method(num);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
