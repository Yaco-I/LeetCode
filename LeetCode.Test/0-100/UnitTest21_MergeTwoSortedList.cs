using LeetCode.Algorithms.Easy;
using LeetCode.Algorithms.Medium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Test
{
    [TestClass]
    public class UnitTest21_MergeTwoSortedList
    {
        public void TestMethod1()
        {
            var node1 = new ListNode(1);
            node1.next = new ListNode(2);
            node1.next.next = new ListNode(4);

            var node2 = new ListNode(1);
            node2.next = new ListNode(3);
            node2.next.next = new ListNode(4);

            var result = MergeTwoSortedList.MergeTwoLists(node1, node2);
            Assert.AreEqual(1, result.val);
            Assert.AreEqual(1, result.next.val);
            Assert.AreEqual(2, result.next.next.val);
            Assert.AreEqual(3, result.next.next.next.val);
            Assert.AreEqual(4, result.next.next.next.next.val);
            Assert.AreEqual(4, result.next.next.next.next.next.val);
        }
    }
}
