using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms._501_600
{
    public class ReverseStringII
    {
        public string ReverseStr(string s, int k)
        {
            char[] chars = s.ToCharArray();
            int n = chars.Length;

            for (int i = 0; i < n; i += 2 * k)
            {
                int start = i;
                int end = Math.Min(i + k - 1, n - 1); // Calcular el índice final para invertir
                ReverseSubstring(chars, start, end);
            }

            return new string(chars);
        }

        private void ReverseSubstring(char[] chars, int start, int end)
        {
            while (start < end)
            {
                char temp = chars[start];
                chars[start] = chars[end];
                chars[end] = temp;
                start++;
                end--;
            }
        }



    }
}
