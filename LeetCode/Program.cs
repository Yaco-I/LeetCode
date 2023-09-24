// See https://aka.ms/new-console-template for more information
using LeetCode.Algorithms.Easy;
using LeetCode.Algorithms.Easy._0_100;

var view = new RemoveElements26(new int[] { 1, 1, 2 });


public class Exercices
{
    public static int E1572(int[][] array)
    {
        var result = 0;
      
        for (int i = 0; i < array.Length; i++)
        {
            if (i != array.Length - i - 1)
                result += array[i][i] + array[i][array.Length - 1 - i];
            else
                result += array[i][i];
        }
        return result;
    }

    // 1 + 1     1+3
    // 2 + 2     
    // 3 + 3 
    //
    public static  IList<IList<int>> E1282(int[] groupSizes)
    {
        List<IList<int>> result = new List<IList<int>>();
        Dictionary<int, List<int>> groupMap = new Dictionary<int, List<int>>();

        for (int i = 0; i < groupSizes.Length; i++)
        {
            int size = groupSizes[i];

            if (!groupMap.ContainsKey(size))
            {
                groupMap[size] = new List<int>();
            }

            groupMap[size].Add(i);

            if (groupMap[size].Count == size)
            {
                result.Add(groupMap[size]);
                groupMap[size] = new List<int>();
            }
        }

        return result;
    }

    public static void ViewArray(int[] array)
    {
        foreach (int number in array)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }


    public static void E1282View(int[] array) {
        var result = E1282(array);
        foreach (List<int> innerList in result)
        {
            foreach (int number in innerList)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine(); // Agrega una nueva línea después de cada lista interna
        }
    }

}