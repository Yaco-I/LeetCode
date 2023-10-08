using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms
{
    public class ValidPalindrome
    {
        public static bool IsPalindrome(string s)
        {
            s = s.Replace(" ", "");
            for (int i = 0, j = s.Length - 1; i < s.Length / 2; i++, j--)
            {
                if (s[i] != s[j])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
