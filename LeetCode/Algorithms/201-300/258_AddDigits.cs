using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms.Easy._201_300;

public class AddDigits
{
    /*
     Given an integer num, repeatedly add all its digits until the result has only one digit, and return it.
     */

    public static int AddDigitsMethod(int num)
    {
        int valor = 0;
        string numero = num.ToString();
        while (numero.Count() != 1)
        {

            foreach (char c in numero)
            {
                valor += int.Parse(c.ToString());
            }
            numero = valor.ToString();
            valor = 0;
        }
        return int.Parse(numero);

    }

}
