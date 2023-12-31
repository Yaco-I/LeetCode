﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms
{
    public static class PalindromeNumber
    {
        /*
         * Given an integer x, return true if x is a
         * palindrome, and false otherwise.
         */
        public static bool PalindromeNumberMethod(int numero)
        {
            string num = numero.ToString();
            int valor = num.Length / 2;

            for (int i = 0; i < valor; i++)
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
