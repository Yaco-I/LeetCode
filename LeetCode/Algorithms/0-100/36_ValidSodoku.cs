using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms.Medium
{
    public class ValidSodoku
    {
        public static bool IsValidSudoku(char[][] board)
        {
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[i].Length; j++)
                {
                    if (board[i][j] == '.')
                        continue;
                    var result = CheckSquare(board, i, j);
                    if (!result)
                        return false;
                    for (int k = 0; k < board.Length; k++)
                    {
                        if (board[k][j] != '.')
                            if (board[k][j] == board[i][j] && k != i)
                                return false;
                        if (board[i][k] != '.')
                            if (board[i][k] == board[i][j] && k != j)
                                return false;
                    }

                }
            }


            return true;
        }

        private static bool CheckSquare(char[][] board, int i, int j)
        {
            int iStart = i - (i % 3);
            int jStart = j - (j % 3);

            for (int k = iStart; k < iStart + 3; k++)
            {
                for (int l = jStart; l < jStart + 3; l++)
                {
                    if (board[k][l] != '.')
                        if (board[k][l] == board[i][j] && k != i && l != j)
                            return false;
                }
            }

            return true;
        }
    }
}
