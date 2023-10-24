using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace LeetCode.Algorithms
{
    public class IntegerToRoman
    {
        public static string IntToRoman(int num)
        {
            string numString = num.ToString();

            StringBuilder stringBuilder = new StringBuilder();

            var romanDictionary = new Dictionary<int, string>
            {
                { 1, "I" },
                { 5, "V" },
                { 10, "X" },
                { 50, "L" },
                { 100, "C" },
                { 500, "D" },
                { 1000, "M" }
            };

            var array1 = new int[] { 1, 10, 100, 1000 };
            var array5 = new int[] { 5, 50, 500 };

            for (int k = 0;k < numString.Length; k++)
            {

                int i = numString.Length - k - 1 ;
                //Convertimos a integer
                int numero = Convert.ToInt16(numString[k].ToString());

                // numero 0 continua porque no se tiene que poner nada
                if (numero == 0)
                    continue;
                else if (numero > 8 )
                {
                    //repetimos el valor anterior
                    stringBuilder.Append(repeatString(romanDictionary[array1[i]] ,10 - numero ));
                    //Agregamos el valor siguiente
                    stringBuilder.Append(romanDictionary[array1[i + 1]]);

                }else if(numero <= 3 )
                    //Si es menor a tres se repite por por la cantidad necesaria
                    stringBuilder.Append(repeatString(romanDictionary[array1[i]], numero));
                else
                {
                    if(numero == 5)
                        stringBuilder.Append(romanDictionary[array5[i]]);
                    else if(numero > 5 )
                    {
                        //repetimos el valor de 5
                        stringBuilder.Append(romanDictionary[array5[i]]);
                        //Agregamos el valor siguiente
                        stringBuilder.Append(repeatString(romanDictionary[array1[i]],  numero - 5));
                    }
                    else
                    {
                        
                        //repetimos el valor de 5
                        stringBuilder.Append(repeatString(romanDictionary[array1[i]],5 - numero ));
                        //Agregamos el valor siguiente
                        stringBuilder.Append(romanDictionary[array5[i]]);
                    }
                }
            }

            var result = stringBuilder.ToString();
            return result;
        }

        private static string repeatString(string st, int n)
        {
            return new StringBuilder().Insert(0, st, n).ToString();
        }
    }
}
