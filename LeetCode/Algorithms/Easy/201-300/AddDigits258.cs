using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms.Easy._201_300
{
    public class AddDigits258
    {
        public AddDigits258()
        {
            Console.WriteLine(AddDigits(38));
        }

        public int AddDigits(int num)
        {
            int valor = 0;
            string numero = num.ToString();
            while (numero.Count() != 1) {
                
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
}
