using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms
{
    public class FindFirstAndLastPositionOfElementInSortedArray
    {
        public static int[] SearchRange(int[] nums, int target)
        {
            int izquierda = 0, derecha = nums.Length - 1;
            while (izquierda <= derecha)
            {

                int indiceCentral = Convert.ToInt32(Math.Floor(Convert.ToDouble(izquierda + derecha) / 2));
                int valorCentral = nums[indiceCentral];
                // Si lo encontramos entonces regresamos el valor de manera inmediata
                if (valorCentral == target)
                {
                    for (int i = indiceCentral - 1; i >= 0; i--)
                    {
                        if (nums[i] != target)
                        {
                            izquierda = i + 1;
                            break;
                        }

                    }
                    for (int i = indiceCentral + 1; i < nums.Length; i++)
                    {
                        if (nums[i] != target)
                        {
                            derecha = i - 1;
                            break;
                        }

                    }
                    return new int[] { izquierda, derecha };
                    //logica de busqueda
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
            return new int[]{ -1,-1};

        }


    }
}
