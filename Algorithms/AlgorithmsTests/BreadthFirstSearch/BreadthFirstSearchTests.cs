using Algorithms.BFS;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmsTests.BFS
{
    [TestClass]
    public class BreadthFirstSearchTests
    {
        [TestMethod]
        public void TestNumberOfIslands()
        {
            var numberOfIslands = new NumberOfIslandsBFS();

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

        [TestMethod]
        public void TestPerfectSquares()
        {
            var perfectSquares = new PerfectSquares();
            Assert.AreEqual(3, perfectSquares.NumSquares(12));
            Assert.AreEqual(2, perfectSquares.NumSquares(13));
        }
    }
}
