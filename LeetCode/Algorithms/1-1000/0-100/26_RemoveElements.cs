﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms.Easy._0_100
{
    public class RemoveElements
    {
        /*
         *Given an integer array nums sorted in non-decreasing order, remove the duplicates in-place such that each unique element appears only once.
         * The relative order of the elements should be kept the same. Then return the number of unique elements in nums.
         * Consider the number of unique elements of nums to be k, to get accepted, you need to do the following things:
         * Change the array nums such that the first k elements of nums contain the unique elements in the order they were present in nums initially. 
         * The remaining elements of nums are not important as well as the size of nums.
         * Return k.         
         */

        public static int RemoveElementMethod(int[] nums)
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
