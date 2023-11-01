using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms
{
    public class PercentageOfLetterInString
    {
        public static int PercentageLetter(string s, char letter)
        {
            int count = s.Count();
            int letterCount = s.Count(c => c == letter);
            return letterCount * 100 / count;
        }
    }
}
