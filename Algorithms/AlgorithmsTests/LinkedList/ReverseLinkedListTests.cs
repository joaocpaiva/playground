using System;
using Algorithms.LinkedList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmsTests.LinkedList
{
    [TestClass]
    public class ReverseLinkedListTests
    {
        [TestMethod]
        public void TestReverseListIteratively()
        {
            var root = new ListNode(1);
            var node = root;
            for (int i = 2; i <= 5; i++)
            {
                node.next = new ListNode(i);
                node = node.next;
            }

            var ll = new ReverseLinkedList();
            node = ll.ReverseListIteratively(root);
            for (int i = 5; i >= 1; i--)
            {
                Assert.AreEqual(i, node.val);
                node = node.next;
            }
        }

        [TestMethod]
        public void TestReverseListRecursively()
        {
            var root = new ListNode(1);
            var node = root;
            for (int i = 2; i <= 5; i++)
            {
                node.next = new ListNode(i);
                node = node.next;
            }

            var ll = new ReverseLinkedList();
            node = ll.ReverseListRecursively(root);
            for (int i = 5; i >= 1; i--)
            {
                Assert.AreEqual(i, node.val);
                node = node.next;
            }
        }
    }
}
