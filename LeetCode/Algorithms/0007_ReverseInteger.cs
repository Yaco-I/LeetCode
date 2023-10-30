using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms
{
    public class ReverseInteger
    {
        public static int Reverse(int x)
        {
            string xString = x.ToString();
            StringBuilder sb = new StringBuilder();
            string max = int.MaxValue.ToString();
            if (xString[0] == '-')
            {
                sb.Append('-');
            }
            for (int i = xString.Length - 1; i >= 0; i--)
            {
                if (xString[i] == '-')
                {
                    continue;
                }
                sb.Append(xString[i]);
            }

            if((max.Length == sb.Length && xString[0] != '-')
                || (xString[0] == '-' && max.Length == sb.Length - 1 ) )
            {
                int negative = xString[0] == '-' ? 1 : 0 ;
                for (int i = 0; i < max.Length; i++)
                {
                    if (sb[i + negative] > max[i])
                    {
                        return 0;
                    }
                    else if (sb[i + negative] < max[i])
                    {
                        break;
                    }
                }
            }
            else if(max.Length < sb.Length)
            {
                return 0;
            }

            return int.Parse(sb.ToString());
        }

    }
}
