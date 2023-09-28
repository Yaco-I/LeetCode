using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms.Easy._0_100
{
    public class SearchInsertPosition
    {
        //Con test
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
