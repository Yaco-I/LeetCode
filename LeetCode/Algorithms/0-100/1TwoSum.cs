using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeetCode.Algorithms.Easy;

public class TwoSum
{
    

   
    public static int[] TwoSumMethod(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                if (i == j)
                    continue;
                if (nums[i] + nums[j] == target)
                    return new int[] { i, j };
            }
        }
        return null;
    }

}
