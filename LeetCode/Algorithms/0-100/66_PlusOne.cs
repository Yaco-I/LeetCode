using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms._0_100
{
    public class PlusOne
    {
        public static int[] PlusOneMethod(int[] digits)
        {
            int carry = 1;
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (carry == 1)
                {
                    if (digits[i] == 9)
                    {
                        digits[i] = 0;
                        carry = 1;
                    }
                    else
                    {
                        digits[i] += 1;
                        carry = 0;
                    }
                }
                else if (carry == 0)
                {
                    break;
                }
            }
            return digits;
        }
    }
}
