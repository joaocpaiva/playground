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

        /// <summary>
        /// Given a linked list, reverse the nodes of a linked list k at a time and return its modified list.
        /// k is a positive integer and is less than or equal to the length of the linked list.
        /// If the number of nodes is not a multiple of k then left-out nodes in the end should remain as it is.
        /// Example: given this linked list: 1->2->3->4->5
        ///     For k = 2, you should return: 2->1->4->3->5
        ///     For k = 3, you should return: 3->2->1->4->5
        /// </summary>
        public ListNode ReverseEveryXNodes(ListNode head, int k)
        {
            ListNode curr = head;
            ListNode tail = null;
            ListNode newHead = null;

            var nodes = new ListNode[k];
            int i = 0;
            while (curr != null)
            {
                nodes[i++ % k] = curr;
                curr = curr.next;

                int validNodes = nodes.Where(e => e != null).Count();
                if (curr == null || validNodes == k)
                {
                    if (validNodes < k)
                    {
                        // Left-out nodes in the end should remain as it is.
                        nodes = nodes.Reverse().ToArray();
                    }

                    if (tail == null)
                    {
                        tail = nodes[k - 1];
                        newHead = tail;
                        nodes[k - 1] = null;
                    }

                    tail = AppendListToTail(nodes, tail);
                    Array.Clear(nodes, 0, k);
                }
            }

            return newHead;
        }

        private ListNode AppendListToTail(ListNode[] nodes, ListNode tail)
        {
            var curr = tail;

            for (int i = nodes.Length - 1; i >= 0; i--)
            {
                if (nodes[i] != null)
                {
                    tail.next = nodes[i];
                    tail = nodes[i];
                }
            }

            tail.next = null;
            return tail;
        }
    }
}
