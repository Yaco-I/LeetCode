using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms
{
    public class LetterCombitanionsOfaPhoneNumber
    {
        public static IList<string> LetterCombinations(string digits)
        {
            IList<string> numbers = new List<string>();

            Dictionary<string, string> t9Dictionary = new Dictionary<string, string>
        {
            {"1", ""},         // El 1 no tiene letras asociadas
            {"2", "abc"},
            {"3", "def"},
            {"4", "ghi"},
            {"5", "jkl"},
            {"6", "mno"},
            {"7", "pqrs"},
            {"8", "tuv"},
            {"9", "wxyz"},
        };
            List<string> newList = new List<string>();
            List<string> oldList = new List<string>();

            for (int i = 0; i < digits.Length; i++)
            {
                foreach (char c in t9Dictionary[digits[i].ToString()])
                {
                    if(i == 0)
                    {
                        newList.Add(c.ToString());
                    }
                    foreach (var s in oldList)
                    {
                        newList.Add(s + c.ToString());
                    }

                }
                oldList = newList;
                newList = new List<string>();
            }

            numbers = newList;

            return numbers;
        }


    }
}
