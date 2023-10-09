using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms
{
    public class MinimumMovesToConvertString
    {
        public static int MinimumMoves(string s)
        {
            int moves = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != 'O')
                {
                    moves++;
                    i += 2;
                }
            }
            return moves;
        }

    }
}
