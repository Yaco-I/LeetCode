using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms
{
    public class SearchInsertPosition
    {
        /*
         *There is an integer array nums sorted in ascending order (with distinct values).
         * Prior to being passed to your function, nums is possibly rotated at an unknown pivot index 
         * k (1 <= k < nums.length) such that the resulting array is [nums[k], nums[k+1], ..., nums[n-1], 
         * nums[0], nums[1], ..., nums[k-1]] (0-indexed). For example, [0,1,2,4,5,6,7] might be rotated at pivot index 3 and become [4,5,6,7,0,1,2].
         * Given the array nums after the possible rotation and an integer target, return the index of target
         * if it is in nums, or -1 if it is not in nums.
         * You must write an algorithm with O(log n) runtime complexity.
         *
         
         */
        public static int SearchInsert(int[] nums, int target)
        {
            int izquierda = 0, derecha = nums.Length - 1;

            while (izquierda <= derecha)
            {

                int indiceCentral = Convert.ToInt32(Math.Floor(Convert.ToDouble(izquierda + derecha) / 2));
                int valorCentral = nums[indiceCentral];
                // Si lo encontramos entonces regresamos el valor de manera inmediata
                if (valorCentral == target)
                {
                    return indiceCentral;
                }
                // Si no, debido a que esto ya está ordenado, analizamos dónde podría estar
                if (target < valorCentral)
                {
                    // Si lo que buscamos es menor, debe estar a la izquierda
                    derecha = indiceCentral - 1;
                }
                else
                {
                    // Si no, está a la derecha
                    izquierda = indiceCentral + 1;
                }

            }
            // Terminamos de buscar y no encontramos el elemento
            return izquierda;
        }
    }
}
