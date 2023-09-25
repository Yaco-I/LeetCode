﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms.Easy._301_400
{
    public class EncuentraLaDiferecia389
    {
        public EncuentraLaDiferecia389()
        {
            
        }

        private int FindTheDifference(string s, string t)
        {
            var sArray = s.ToCharArray();
            var tArray = t.ToCharArray();
            Array.Sort(sArray);
            Array.Sort(tArray);
            for (int i = 0; i < sArray.Length; i++)
            {
                if (sArray[i] != tArray[i])
                {
                    return tArray[i];
                }
            }
            return tArray[tArray.Length - 1];
        }


    }
}
