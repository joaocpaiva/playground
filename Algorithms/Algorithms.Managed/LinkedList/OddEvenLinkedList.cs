using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.LinkedList
{
    public class OddEvenLinkedList
    {
        public ListNode OddEvenList(ListNode head)
        {
            ListNode prevOdd = null;
            ListNode prevEven = null;

            ListNode curr = head;
            ListNode firstEven = head?.next;
            int i = 1;
            while (curr != null)
            {
                if (i % 2 != 0)
                {
                    if (prevOdd != null)
                    {
                        prevOdd.next = curr;
                    }

                    prevOdd = curr;
                }
                else
                {
                    if (prevEven != null)
                    {
                        prevEven.next = curr;
                    }

                    prevEven = curr;
                }

                curr = curr.next;
                i++;
            }

            if (prevOdd != null)
            {
                prevOdd.next = firstEven;
            }

            if (prevEven != null)
            {
                prevEven.next = null;
            }

            return head;
        }
    }
}
