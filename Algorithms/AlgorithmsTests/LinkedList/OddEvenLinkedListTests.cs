using System;
using Algorithms.LinkedList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmsTests.LinkedList
{
    [TestClass]
    public class OddEvenLinkedListTests
    {
        [TestMethod]
        public void TestOddEvenLinkedList()
        {
            var root = new ListNode(1);
            var node = root;
            for (int i = 2; i <= 5; i++)
            {
                node.next = new ListNode(i);
                node = node.next;
            }

            node = root;
            Assert.AreEqual(1, node.val);
            node = node.next;
            Assert.AreEqual(2, node.val);
            node = node.next;
            Assert.AreEqual(3, node.val);
            node = node.next;
            Assert.AreEqual(4, node.val);
            node = node.next;
            Assert.AreEqual(5, node.val);
            node = node.next;
            Assert.IsNull(node);

            var ll = new OddEvenLinkedList();
            node = ll.OddEvenList(root);
            Assert.AreEqual(1, node.val);
            node = node.next;
            Assert.AreEqual(3, node.val);
            node = node.next;
            Assert.AreEqual(5, node.val);
            node = node.next;
            Assert.AreEqual(2, node.val);
            node = node.next;
            Assert.AreEqual(4, node.val);
            node = node.next;
            Assert.IsNull(node);
        }
    }
}
