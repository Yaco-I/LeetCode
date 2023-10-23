using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms
{
    public class PowerOfFour
    {
        public static bool IsPowerOfFour(int n)
        {
            bool result = false;
            decimal nDecimal = n;

            if (nDecimal == 1)
            {
                result = true;
            }

            while (nDecimal > 1)
            {
                nDecimal = nDecimal / 4;
                if (nDecimal == 1)
                {
                    result = true;
                }
            }
            return result;
        }
    }
}
