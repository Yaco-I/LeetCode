using LeetCode.Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Test.UnitTest
{
    [TestClass]
    public class UnitTest0735_AsteroidCollision
    {
        [TestMethod]
        public void TestMethod_AsteroidCollision()
        {
            
            int[] asteroids = { 5, 10, -5 };
            int[] expected = { 5, 10 };
            int[] result = AsteroidCollision.AsteroidCollisionMethod(asteroids);
            Assert.AreEqual(expected.Length, result.Length);
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }
    }
}
