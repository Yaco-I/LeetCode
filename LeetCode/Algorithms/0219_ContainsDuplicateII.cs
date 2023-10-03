using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms
{
    public class ContainsDuplicateII
    {
        /*
         * Given an integer array nums and an integer k,
         * return true if there are two distinct indices i and j 
         * in the array such that nums[i] == nums[j] and abs(i - j) <= k.
         */


        public static bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            int cant = nums.Length;
            if (cant == 0)
                return false;

            var val = 0;
            var abs = 0;
            for (int i = 0; i < cant; i++)
            {
                for (int j = 0; j < cant; j++)
                {
                    if (i == j)
                        continue;

                    if (nums[i] == nums[j])
                    {
                        val = i - j;
                        abs = val > 0 ? val : val * -1;
                        if (abs <= k)
                        {
                            return true;
                        }
                    }

                }
            }
            return false;
        }
    }
}
