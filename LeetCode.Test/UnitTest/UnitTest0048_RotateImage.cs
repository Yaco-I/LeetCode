using LeetCode.Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Test.UnitTest
{
    [TestClass]
    public class UnitTest0048_RotateImage
    {
        [TestMethod]
        public void TestMethod_RotateImage()
        {
            int[][] matrix = new int[3][];
            matrix[0] = new int[] { 1, 2, 3 };
            matrix[1] = new int[] { 4, 5, 6 };
            matrix[2] = new int[] { 7, 8, 9 };

            int[][] expected = new int[3][];
            expected[0] = new int[] { 7, 4, 1 };
            expected[1] = new int[] { 8, 5, 2 };
            expected[2] = new int[] { 9, 6, 3 };

            
            int[][] actual = RotateImage.Rotate(matrix);

            Assert.AreEqual(expected.Length, actual.Length);
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i].Length, actual[i].Length);
                for (int j = 0; j < expected[i].Length; j++)
                {
                    Assert.AreEqual(expected[i][j], actual[i][j]);
                }
            }
        }   
    }
}
