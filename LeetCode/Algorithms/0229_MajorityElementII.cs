using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms
{
    public class MajorityElementII
    {
        public static IList<int> MajorityElement(int[] nums)
        {
            var result = new List<int>();
            var dict = new Dictionary<int, int>();
            var limit = nums.Length / 3;
            foreach (var num in nums)
            {
                if (dict.ContainsKey(num))
                {
                    dict[num]++;
                }
                else
                {
                    dict.Add(num, 1);
                }
            }
            foreach (var item in dict)
            {
                if (item.Value > limit)
                {
                    result.Add(item.Key);
                }
            }
            return result;
        }
    }
}
