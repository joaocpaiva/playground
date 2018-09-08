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

        [TestMethod]
        public void TestNumberOfIslands()
        {
            var numberOfIslands = new NumberOfIslands();

            var input = new char[,]
            {
                { '1', '1', '1', '1', '0' },
                { '1', '1', '0', '1', '0' },
                { '1', '1', '0', '0', '0' },
                { '0', '0', '0', '0', '0' },
            };

            Assert.AreEqual(1, numberOfIslands.NumIslands(input));

            input = new char[,]
            {
                { '1', '1', '0', '0', '0' },
                { '1', '1', '0', '0', '0' },
                { '0', '0', '1', '0', '0' },
                { '0', '0', '0', '1', '1' },
            };

            Assert.AreEqual(3, numberOfIslands.NumIslands(input));
        }

        [TestMethod]
        public void TestOpenTheLock()
        {
            var openTheLock = new OpenTheLock();

            Assert.AreEqual(6, openTheLock.OpenLock(new string[] { "0201", "0101", "0102", "1212", "2002" }, "0202"));

            Assert.AreEqual(1, openTheLock.OpenLock(new string[] { "8888" }, "0009"));

            Assert.AreEqual(-1, openTheLock.OpenLock(new string[] { "8887", "8889", "8878", "8898", "8788", "8988", "7888", "9888" }, "8888"));

            Assert.AreEqual(-1, openTheLock.OpenLock(new string[] { "0000" }, "8888"));
        }
    }
}
