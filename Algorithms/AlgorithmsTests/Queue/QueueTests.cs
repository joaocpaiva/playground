using Algorithms.Queue;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmsTests.Queue
{
    [TestClass]
    public class QueueTests
    {
        [TestMethod]
        public void TestCircularQueue()
        {
            CircularQueue circularQueue = new CircularQueue(3);
            Assert.IsTrue(circularQueue.EnQueue(1));    // return true
            Assert.IsTrue(circularQueue.EnQueue(2));    // return true
            Assert.IsTrue(circularQueue.EnQueue(3));    // return true
            Assert.IsFalse(circularQueue.EnQueue(4));   // return false, the queue is full
            Assert.AreEqual(3, circularQueue.Rear());   // return 3
            Assert.IsTrue(circularQueue.IsFull());      // return true
            Assert.IsTrue(circularQueue.DeQueue());     // return true
            Assert.IsTrue(circularQueue.EnQueue(4));    // return true
            Assert.AreEqual(4, circularQueue.Rear());   // return 4
        }
    }
}
