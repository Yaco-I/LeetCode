using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms
{
    public class MyHashMap
    {
        private int[] contains = new int[1_000_001];

        public void Put(int key, int value) => contains[key] = value + 1;

        public int Get(int key) => contains[key] - 1;

        public void Remove(int key) => contains[key] = 0;
    }

}
