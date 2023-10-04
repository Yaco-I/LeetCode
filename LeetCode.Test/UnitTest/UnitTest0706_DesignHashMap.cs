using LeetCode.Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Test.UnitTest
{
    [TestClass]
    public class UnitTest0706_DesignHashMap
    {
        [TestMethod]
        public void TestMethod_MyHashMap()
        {
            MyHashMap hashMap = new MyHashMap();
            hashMap.Put(1, 1);
            hashMap.Put(2, 2);
            Assert.AreEqual(1,hashMap.Get(1));            // returns 1
            Assert.AreEqual(-1, hashMap.Get(3));            // returns -1 (not found)
            hashMap.Put(2, 1);          // update the existing value
            Assert.AreEqual(1, hashMap.Get(2));            // returns 1 
            hashMap.Remove(2);          // remove the mapping for 2
            Assert.AreEqual(-1, hashMap.Get(2));            // returns -1 (not found)
        }
    }
}
