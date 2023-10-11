using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms
{
    public class ContainsDuplicate
    {
        public static bool ContainsDuplicateMethod(int[] nums)
        {
            Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();
            foreach (var num in nums) { 
                if(keyValuePairs.ContainsKey(num))
                {
                    return true;
                }
                keyValuePairs.Add(num, 0);
            }
            return false;
        }
    }
}
