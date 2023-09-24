using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms.Easy
{
    public static class _9PalindromeNumber
    {
        public static bool PalindromeNumber(int numero)
        {
            string num = numero.ToString();
            int valor = num.Length / 2;

            for (int i = 0; i < valor ; i++)
            {
                if (num[i] != num[num.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;


        }
    }
}
