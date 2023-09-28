using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms.Easy._0_100
{
    public class ContainsDuplicateII
    {

        public ContainsDuplicateII()
        {
            Console.WriteLine(ContainsNearbyDuplicate(new int[] { 1, 2, 3, 1 }, 3));
            Console.WriteLine(ContainsNearbyDuplicate(new int[] { 1, 2, 3, 1, 2, 3 }, 2));
            //Console.WriteLine(ContainsNearbyDuplicate(new int[] { 1, 0,1,1 }, 3));

        }

        public bool ContainsNearbyDuplicate(int[] nums, int k)
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
