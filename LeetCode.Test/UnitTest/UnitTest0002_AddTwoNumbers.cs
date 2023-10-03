using LeetCode.Algorithms;

namespace LeetCode.Test
{
    [TestClass]
    public class UnitTest0002_AddTwoNumbers
    {
        [TestMethod]
        public void TestMethod_AddTwoNumbers()
        {
              var node1 = new ListNode(2);
            node1.next = new ListNode(4);
            node1.next.next = new ListNode(3);

            var node2 = new ListNode(5);
            node2.next = new ListNode(6);
            node2.next.next = new ListNode(4);

            var result = AddTwoNumbers.AddTwoNumbersMethod(node1, node2);
            Assert.AreEqual(7, result.val);
            Assert.AreEqual(0, result.next.val);
            Assert.AreEqual(8, result.next.next.val);
        }
    }
}
