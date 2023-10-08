using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms
{
    public class RomanToInteger
    {
        public static int RomanToInt(string s)
        {
            int sum = 0;
            Dictionary<char, int> map = new Dictionary<char, int>
{
    { 'I', 1 },
    { 'V', 5 },
    { 'X', 10 },
    { 'L', 50 },
    { 'C', 100 },
    { 'D', 500 },
    { 'M', 1000 }
};

            int prev = int.MaxValue;

            foreach (var character in s)
            {
                if (map[character] > prev)
                {
                    sum -= prev * 2;
                    sum += map[character];
                }
                else
                {
                    sum += map[character];
                }

                prev = map[character];
            }
            return sum;
        }
    }
}
