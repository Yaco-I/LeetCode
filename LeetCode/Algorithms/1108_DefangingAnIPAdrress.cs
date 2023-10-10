using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms
{
    public class DefangingAnIPAdrress
    {
        public static string DefangIPaddr(string address)
        {
            return address.Replace(".", "[.]");
        }
        public static string DefangIPaddr2Option(string address)
        {
            for (int i = 0; i < address.Length; i++)
            {
                if (address[i] == '.')
                {
                    address = address.Substring(0, i) + "[.]" + address.Substring(i + 1);
                    i += 2;
                }
            }
            return address;
        }
    }
}
