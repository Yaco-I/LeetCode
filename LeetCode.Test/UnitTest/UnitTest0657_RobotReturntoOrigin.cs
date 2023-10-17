using LeetCode.Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Test.UnitTest
{
    [TestClass]
    public class UnitTest0657_RobotReturntoOrigin
    {
        [TestMethod]
        public void TestMethod_JudgeCircle()
        {
            var input = "UD";
            var expected = true;
            var actual = RobotReturntoOrigin.JudgeCircle(input);
            Assert.AreEqual(expected, actual);
        }
    }
}
