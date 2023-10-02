using LeetCode.Algorithms._501_600;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Test._501_600
{
    [TestClass]
    public class UnitTest557_ReverseWordsInAStringIII
    {
        [TestMethod]
        public void TestMethodReverseWords()
        {
            var input = "Let's take LeetCode contest";
            var output = "s'teL ekat edoCteeL tsetnoc";

            var result = ReverseWordsInAStringIII.ReverseWords(input);
            Assert.AreEqual(output, result);
            
        }
    }
}
