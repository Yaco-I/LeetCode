using LeetCode.Algorithms.Medium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms.Easy
{
    public static class _21MergeTwoSortedList
    {


        public static void ViewExercise() {
            ListNode list1 = new ListNode(1, new ListNode(2, new ListNode(4)));
            ListNode list2 = new ListNode(1, new ListNode(3, new ListNode(4)));
            ListNode result = MergeTwoLists(list1, list2);
            while (result != null)
            {
                Console.WriteLine(result.val);
                result = result.next;
            }
        }

        


        public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode listNode = new ListNode();
            ListNode result = listNode;

            while (list1 != null && list2 != null)
            {
                if (list1.val < list2.val)
                {
                    result.next = list1;
                    list1 = list1.next;
                }
                else if (list1.val > list2.val)
                {
                    result.next = list2;
                    list2 = list2.next;
                }
                else
                {
                    result.next = list1;
                    result = result.next;
                    list1 = list1.next;

                    result.next = list2;
                    list2 = list2.next;
                }
                result = result.next;
            }
            result.next = list1 ?? list2;
            return listNode.next;
        }
    }
}
