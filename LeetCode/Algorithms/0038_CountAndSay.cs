using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms;

public class CountAndSay
{

    public static string CountAndSayMethod(int n)
    {
        string result = "1";
        for (int i = 1; i < n; i++)
        {
            result = CountAndSayString(result);
        }
        return result;

    }

    public static string CountAndSayString(string s)
    {
        StringBuilder sb = new StringBuilder();

        int count = 0;
        char current = s[0];
        foreach (var sSingle in s)
        {
            if(current != sSingle)
            {
                sb.Append(count);
                sb.Append(current);
                count = 1;
                current = sSingle;
            }
            else
            {
                count ++;
            }
        }
        sb.Append(count);
        sb.Append(current);

        return sb.ToString();

    }
}
