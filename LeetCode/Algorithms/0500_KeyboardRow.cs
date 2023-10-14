using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms
{
    public class KeyboardRow
    {
        public static string[] FindWords(string[] words)
        {
            List<string> result = new List<string>();

            foreach(string word in words)
            {
                string lowerWord = word.ToLower();

                if (lowerWord.All(c => "qwertyuiop".Contains(c)) ||
                                       lowerWord.All(c => "asdfghjkl".Contains(c)) ||
                                                          lowerWord.All(c => "zxcvbnm".Contains(c)))
                {
                    result.Add(word);
                }
            }
            return result.ToArray();
        }
    }
}
