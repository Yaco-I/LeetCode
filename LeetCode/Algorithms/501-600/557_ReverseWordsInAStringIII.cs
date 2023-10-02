using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms._501_600
{
    public class ReverseWordsInAStringIII
    {
        public static string ReverseWords(string s)
        {
            string[] words = s.Split(' ');

            StringBuilder result = new StringBuilder();

            foreach (string word in words)
            {
                string reversedWord = new string(word.Reverse().ToArray());
                result.Append(reversedWord);
                result.Append(' ');
            }
            if (result.Length > 0)
            {
                result.Length--;
            }

            return result.ToString();
        }


    }
}
