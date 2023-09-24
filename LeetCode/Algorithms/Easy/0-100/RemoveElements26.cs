using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms.Easy._0_100
{
    public class RemoveElements26
    {
        public RemoveElements26(int[] Array)
        {
            Console.WriteLine(RemoveElement(Array));
            
        }

        public int RemoveElement(int[] nums)
        {
            int count = 0;
            var list = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (i == 0)
                {
                    count++;
                    list.Add(nums[i]);
                    continue;
                }
                if (nums[i] != nums[i - 1])
                {
                    count++;
                    list.Add(nums[i]);
                }

            }
            
            var array= list.ToArray();
            Array.Copy(array, nums, array.Length);

            return count;
        }



    }
}
