using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode;

public static class Views
{
    public static void Array<T>(T[] array)
    {
        foreach (T parameter in array)
        {
            Console.Write(parameter + " ");
        }
        Console.WriteLine();
    }
}
