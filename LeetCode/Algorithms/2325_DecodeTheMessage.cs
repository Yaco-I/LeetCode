using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms
{
    public class DecodeTheMessage
    {
        public static string DecodeMessage(string key, string message)
        {
            char letter = 'a';

            var dict = new Dictionary<char, char>();

            foreach(var character in key)
            {
                if(character == ' ')
                    continue;
                if (!dict.ContainsKey(character))
                {
                    dict.Add(character, letter);
                    letter++;
                    if(letter > 'z')
                    {
                        break;
                    }
                }
            }

            StringBuilder st = new StringBuilder();
            foreach(var chararcter in message)
            {
                if(chararcter == ' ')
                {
                    st.Append(' ');
                    continue;
                }
                st.Append(dict[chararcter]);
            }

            return st.ToString();
        }
    }
}
