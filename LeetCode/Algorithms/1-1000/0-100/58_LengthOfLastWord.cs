using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms._0_100
{
    public class LengthOfLastWord
    {
        /*
        * Given a string s consisting of words and spaces, return the length of the last word in the string.
        * A word is a maximal
        * substring
        * consisting of non-space characters only.
        */
        public static int LengthOfLastWordMethod(string s)
        {
            var count = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] != ' ')
                    count++;
                else if (count > 0 && s[i] == ' ')
                    return count;
            }
            return 0;
            
            
            foreach (var word in s.Split(' ').Reverse())
            {
                if (!string.IsNullOrEmpty(word))
                {
                    return word.Length;
                }
            }
            return 0;
        }
    }
}
