using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms
{
    public class SortArrayByParity
    {

        public static int[] SortArrayByParityy(int[] nums)
        {
            List<int> par = new List<int>();
            List<int> impar = new List<int>();

            foreach (int i in nums)
            {
                if (i % 2 == 0)
                    par.Add(i);
                else
                    impar.Add(i);
            }
            return par.Concat(impar).ToArray();
        }
    }
}
