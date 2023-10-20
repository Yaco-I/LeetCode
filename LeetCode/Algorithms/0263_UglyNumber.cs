using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms
{
    public class UglyNumber
    {
        public static bool IsUgly(int n)
        {
            while (true)
            {
                if(n == 1)
                {
                    return true;
                }
                else if(n % 2 == 0)
                {
                    n /= 2;
                }
                else if(n % 3 == 0)
                {
                    n /= 3;
                }
                else if(n % 5 == 0)
                {
                    n /= 5;
                }
                else
                {
                    return false;
                }
            }


        }
    }
}
