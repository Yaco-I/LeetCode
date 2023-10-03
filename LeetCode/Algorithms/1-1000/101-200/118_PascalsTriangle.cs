using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms.Easy._101_200
{
    public static class PascalsTriangle
    {
        /*
         * Given an integer numRows, return the first numRows of Pascal's triangle.
         * In Pascal's triangle, each number is the sum of the two numbers directly above it as shown:
         */

        public static IList<IList<int>> Generate(int numRows)
        {
              IList<IList<int>> result = new List<IList<int>>();
            if (numRows == 0)
                return result;
            result.Add(new List<int>() { 1 });
            if (numRows == 1)
                return result;
            result.Add(new List<int>() { 1, 1 });
            if (numRows == 2)
                return result;

            for (int i = 2; i < numRows; i++)
            {
                IList<int> list = new List<int>();
                list.Add(1);
                for (int j = 1; j < i; j++)
                {
                    list.Add(result[i - 1][j - 1] + result[i - 1][j]);
                }
                list.Add(1);
                result.Add(list);
            }
            return result;
        }
    }
}
