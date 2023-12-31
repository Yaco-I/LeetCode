﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms;

public static class AddTwoNumbers
{


    /// <summary>
    /// It was made with github copilot only using the function name
    /// </summary>
    /// <param name="l1"></param>
    /// <param name="l2"></param>
    /// <returns></returns>
    public static ListNode AddTwoNumbersMethod(ListNode l1, ListNode l2)
    {
        ListNode result = new ListNode();
        ListNode current = result;
        int carry = 0;
        while (l1 != null || l2 != null)
        {
            int sum = carry;
            if (l1 != null)
            {
                sum += l1.val;
                l1 = l1.next;
            }
            if (l2 != null)
            {
                sum += l2.val;
                l2 = l2.next;
            }
            current.next = new ListNode(sum % 10);
            current = current.next;
            carry = sum / 10;
        }
        if (carry > 0)
            current.next = new ListNode(carry);
        return result.next;
    }



}
public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}
