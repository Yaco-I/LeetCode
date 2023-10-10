using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms;

public class SingleNumber
{
    public static int SingleNumberMethod(int[] nums)
    {
        Array.Sort(nums);
        int numeroAnterior = nums[nums.Length - 1];
        bool esUnico = true;
        foreach (var num in nums)
        {
            if (num != numeroAnterior)
            {
                if (!esUnico)
                {
                    break;
                }
                numeroAnterior = num;
                esUnico = false;
            }
            else
            {
                esUnico = true;
            }
            numeroAnterior = num;
        }

        return numeroAnterior;
        //Dictionary<int, bool> dict = new Dictionary<int, bool>();
        //foreach (var num in nums)
        //{
        //    if (dict.ContainsKey(num))
        //    {
        //        dict[num] = true;
        //    }
        //    else
        //    {
        //        dict.Add(num, false);
        //    }
        //}

        //foreach (var item in dict)
        //{
        //    if (!item.Value)
        //    {
        //        return item.Key;
        //    }
        //}
        //return -1;
    }


}
