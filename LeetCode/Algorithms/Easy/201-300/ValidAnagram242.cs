using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms.Easy._201_300
{
    public class ValidAnagram242
    {
        public ValidAnagram242()
        {
            var result = IsAnagram("anagram", "nagaram");
            Console.WriteLine(result);
        }

        public bool IsAnagram(string s, string t)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();
            List<char> list = new List<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (dic.ContainsKey(s[i]))
                {
                    dic[s[i]]++;
                }
                else
                {
                    dic.Add(s[i], 1);
                    list.Add(s[i]);
                }
            }
            foreach (char c in t)
            {
                if (!dic.ContainsKey(c))
                {
                    return false;
                }
                else
                {
                    dic[c]--;
                }
            }
            foreach (var item in list)
            {
                if (dic[item] != 0)
                {
                    return false;
                }
            }


            return true;
        }


        
    }
}
