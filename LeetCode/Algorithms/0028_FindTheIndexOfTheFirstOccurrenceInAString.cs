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
            HashSet<int>posibilidades = new HashSet<int>();
            int indexPosibilidades = 0;
            //int indexPosibilidadesNeedle = 0;
            int index = -1;
            int indexNeedle = 0;
            for (int i = 0; i < haystack.Length; i++)
            {
                if (haystack[i] == needle[0] && indexNeedle != 1)
                {
                    posibilidades.Add(i - 1);
                }
                if (haystack[i] == needle[indexNeedle])
                {
                    if(index == -1)
                    {
                        index = i;
                    }
                    indexNeedle++;
                    if(indexNeedle == needle.Length)
                    {
                        return index;
                    }
                }
                else
                {
                    index = -1;
                    indexNeedle = 0;

                    if(posibilidades.Count > indexPosibilidades)
                    {
                        i = posibilidades.ElementAt(indexPosibilidades);
                        indexPosibilidades++;
                        
                    }
                }

            }

            return indexNeedle == needle.Length ? index : -1;
        }
    }
}
