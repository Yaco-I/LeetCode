using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms._801_900
{
    public static class MonotonicArray
    {
        public static bool IsMonotonic(int[] nums)
        {
            bool isIncreasing = true;
            bool isDecreasing = true;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > nums[i - 1])
                    isDecreasing = false;
                else if (nums[i] < nums[i - 1])
                    isIncreasing = false;
            }

            return isIncreasing || isDecreasing;
        }
    }
}
