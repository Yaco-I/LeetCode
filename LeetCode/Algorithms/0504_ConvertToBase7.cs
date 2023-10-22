using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms
{

    public class ConvertToBase7
    {
        public static string ConvertToBase7Method(int num)
        {
            var result = num;
            int sum = 0;
            int count = 0;
            while(result > 6 || result < -6)
            {
                sum += (result % 7) * (int)Math.Pow(10, count);
                count++;
                result = result / 7;
            }
            sum += result * (int)Math.Pow(10, count + 1);
            return sum.ToString();
        }
    }
}
