using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms
{
    public class BackspaceStringCompare
    {
        public static bool BackspaceCompare(string s, string t)
        {
            string sResult = BackspaceString(s);
            string tResult = BackspaceString(t);

            return sResult == tResult;
        }


        private static string BackspaceString(string s)
        {
            List<char> chars = new List<char>();

            foreach (var character in s)
            {
                if (character == '#')
                {
                    if (chars.Count > 0)
                    {
                        chars.RemoveAt(chars.Count - 1);
                    }
                }
                else
                {
                    chars.Add(character);
                }
            }
            return new string(chars.ToArray());
        }
    }
}
