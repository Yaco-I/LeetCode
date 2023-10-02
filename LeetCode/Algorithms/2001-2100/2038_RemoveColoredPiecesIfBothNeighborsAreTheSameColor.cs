using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms._2001_2100
{
    public class RemoveColoredPiecesIfBothNeighborsAreTheSameColor
    {
        public static bool WinnerOfGame(string colors)
        {
            int alice = 0;
            int bob = 0;
            for (int i = 1; i < colors.Length - 1; i++)
            {
                if (colors[i - 1] == colors[i] && colors[i] == colors[i + 1])
                {
                    if (colors[i] == 'A')
                    {
                        alice++;
                    }
                    else
                    {
                        bob++;
                    }
                }
            }
            return alice > bob;
        }
    }
}
