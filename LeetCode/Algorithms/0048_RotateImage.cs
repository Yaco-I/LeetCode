using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms;

public class RotateImage
{
    public static int[][] Rotate(int[][] matrix)
    {
        //int n = matrix.Length;

        //// Transponer la matriz en su lugar
        //for (int i = 0; i < n; i++)
        //{
        //    for (int j = i + 1; j < n; j++)
        //    {
        //        int temp = matrix[i][j];
        //        matrix[i][j] = matrix[j][i];
        //        matrix[j][i] = temp;
        //    }
        //}

        //// Invertir las columnas para obtener la rotación de 90 grados
        //for (int i = 0; i < n; i++)
        //{
        //    for (int j = 0; j < n / 2; j++)
        //    {
        //        int temp = matrix[i][j];
        //        matrix[i][j] = matrix[i][n - 1 - j];
        //        matrix[i][n - 1 - j] = temp;
        //    }
        //}
        //return matrix;


        int length = matrix.Length;

        for (int i = 0; i < length; i++)
        {
            for (int j = i; j < length; j++)
            {
                int temp = matrix[i][j];
                int vali = i;
                int valj = j;
                do
                {
                    matrix[vali][valj] = temp;
                    var tem = valj;
                    valj = length - vali;
                    vali = tem;
                    temp = matrix[valj][length - vali];


                } while (vali != i || valj != j); ;
            }
        }
        return matrix;


    }
}
