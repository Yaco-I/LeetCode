using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms
{
    public class LongestCommonPrefix
    {
        public static string LongestCommonPrefixMethod(string[] strs)
        {
            string prefix = strs[0];
            
            foreach (var str in strs)
            {
                for (int i = 0; i < prefix.Length; i++)
                {
                    if (i >= str.Length || prefix[i] != str[i])
                    {
                        prefix = prefix.Substring(0, i);
                        break;
                    }
                }
            }

            return prefix;
        }
    }
}
