using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms.Easy
{
    public static class IsSubsequence
    {
        
        public static bool IsSubsequenceMethod(string s, string t)
        {
            int index = 0;
            bool flag = false;
            for (int i = 0; i < s.Length; i++)
            {
                flag = false;
                for(int j = index; j <t.Length; j++)
                {
                    if (s[i] == t[j])
                    {
                        index = j + 1;
                        flag = true;
                        break;
                    }
                }
                if (!flag)
                    return false;
            }
            return true;
        }
    }
}
