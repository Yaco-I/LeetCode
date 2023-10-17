using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms;
    public class RobotReturntoOrigin
    {
    public static bool JudgeCircle(string moves)
    {
        int countX = 0;
        int countY = 0;
        foreach(var move in moves)
        {
            switch (move)
            {
                case 'U':
                    countY++;
                    break;
                case 'D':
                    countY--;
                    break;
                case 'L':
                    countX++;
                    break;
                case 'R':
                    countY--;
                    break;
            }
        }

        return countX == 0 && countY == 0;
    }

}
