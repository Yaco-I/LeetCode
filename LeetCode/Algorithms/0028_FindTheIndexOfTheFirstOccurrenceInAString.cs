using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms
{
    public class FindTheIndexOfTheFirstOccurrenceInAString
    {
        public static int FindTheIndexOfTheFirstOccurrenceInAStringMethod(string haystack, string needle)
        {
            //Todo: re hacer
            if (needle == "")
            {
                return 0;
            }
            if (haystack == "")
            {
                return -1;
            }
            int index = -1;
            int indexNeedle = 0;
            for (int i = 0; i < haystack.Length; i++)
            {
                if (haystack[i] == needle[indexNeedle])
                {
                    if (index == -1)
                    {
                        index = i;
                    }
                    indexNeedle++;
                    if (indexNeedle == needle.Length)
                    {
                        return index;
                    }
                }
                else
                {
                    if (haystack[i] == needle[0])
                    {
                        index = i;
                        indexNeedle = 1;
                    }
                    else if (i - 1 >= 0 && haystack[i - 1] == needle[0])
                    {
                        index = i;
                        indexNeedle = 1;
                    }
                    else
                    {
                        index = -1;
                        indexNeedle = 0;
                    }
                }
            }

            return indexNeedle == needle.Length ? index : -1;
        }
    }
}
