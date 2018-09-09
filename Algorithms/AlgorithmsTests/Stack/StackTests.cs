using Algorithms.Stack;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsTests.Stack
{
    [TestClass]
    public class StackTests
    {
        [TestMethod]
        public void TestMinStack()
        {
            var minStack = new MinStack();

            minStack.Push(-2);
            minStack.Push(0);
            minStack.Push(-3);
            Assert.AreEqual(-3, minStack.GetMin());
            minStack.Pop();
            Assert.AreEqual(0, minStack.Top());
            Assert.AreEqual(-2, minStack.GetMin());

            minStack = new MinStack();

            minStack.Push(0);
            minStack.Push(1);
            minStack.Push(2);
            minStack.Push(3);
            Assert.AreEqual(0, minStack.GetMin());
            minStack.Push(-2);
            Assert.AreEqual(-2, minStack.GetMin());
            minStack.Push(4);
            minStack.Pop();
            Assert.AreEqual(-2, minStack.GetMin());
            minStack.Pop();
            Assert.AreEqual(0, minStack.GetMin());
        }
    }
}
