using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms
{
    public class ReverseString
    {
        public static void ReverseStringMethod(char[] s)
        {
            int left = 0;
            int right = s.Length - 1;

            while (left < right)
            {
                // Intercambiar los caracteres en las posiciones left y right
                char temp = s[left];
                s[left] = s[right];
                s[right] = temp;

                // Mover los punteros hacia el centro de la cadena
                left++;
                right--;
            }


        }
    }
}
