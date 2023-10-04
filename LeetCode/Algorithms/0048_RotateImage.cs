using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms
{
    public class RotateImage
    {
        public static int[][] Rotate(int[][] matrix)
        {
            
            //int n = 3; // Cambia este valor según tus necesidades
            int[][] matriz = new int[matrix.Length][];

            for (int i = 0; i < matrix.Length; i++)
            {
                matriz[i] = new int[matriz.Length];
            }

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = matrix.Length - 1; j >= 0; j--)
                {
                    matriz[i][ matrix.Length - 1 - j] = matrix[j][i];
                }
            }
            
            return matriz;
        }
    }
}
