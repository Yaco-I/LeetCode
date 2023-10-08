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
            Dictionary<char,int> map = new Dictionary<char,int>();
            map.Add('I', 1);
            map.Add('V', 5);
            map.Add('X', 10);
            map.Add('L', 50);
            map.Add('C', 100);
            map.Add('D', 500);
            map.Add('M', 1000);

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



            //for (int i = 0; i < s.Length; i++)
            //{
            //    if (map[s[i]] > prev)
            //    {
            //        sum -= map[s[i]];
            //    }
            //    else
            //    {
            //        sum += map[s[i]];
            //    }
            //    prev = map[s[i]];
            //}
            return sum;
        }
    }
}
