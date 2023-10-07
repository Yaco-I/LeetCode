using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms
{
    public class FurthestPointFromOrigin
    {
        public static int FurthestDistanceFromOrigin(string moves)
        {
            var count = 0;
            var count_ = 0;
            foreach (var move in moves)
            {
                if(move == 'L')
                {
                    count--;
                }
                else if(move == 'R')
                {
                    count++;
                }else if(move == '_')
                {
                    count_++;
                }
            }
            return Math.Abs(count) + count_;
        }

    }
}
