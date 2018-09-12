using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.LinkedList
{
    public class ReverseLinkedList
    {
        public ListNode ReverseListIteratively(ListNode head)
        {
            ListNode prev = null;
            ListNode curr = head;
            while (curr != null)
            {
                ListNode nextTemp = curr.next;
                curr.next = prev;
                prev = curr;
                curr = nextTemp;
            }
            return prev;
        }

        public ListNode ReverseListRecursively(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }

            ListNode p = ReverseListRecursively(head.next);
            head.next.next = head;
            head.next = null;
            return p;

        }
    }
}
