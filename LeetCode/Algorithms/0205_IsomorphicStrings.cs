using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms
{
    public class IsomorphicStrings
    {
        public static bool IsIsomorphic(string s, string t)
        {
            Dictionary<char, char> mapS = new Dictionary<char, char>();
            Dictionary<char, char> mapT = new Dictionary<char, char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!mapS.ContainsKey(s[i]))
                {
                    if (mapT.ContainsKey(t[i]))
                    {
                        return false;
                    }
                    mapS.Add(s[i], t[i]);
                    mapT.Add(t[i], s[i]);
                }
                else
                {
                    if (mapS[s[i]] != t[i])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
