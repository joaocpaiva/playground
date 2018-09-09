using Algorithms.DFS;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmsTests.DFS
{
    [TestClass]
    public class DepthFirstSearchTests
    {
        [TestMethod]
        public void TestNumberOfIslands()
        {
            var numberOfIslands = new NumberOfIslandsDFS();

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
        public void TestInorderTraversal()
        {
            var traversal = new InorderTraversal();

            TreeNode tree = new TreeNode(1);
            tree.left = new TreeNode(2);
            tree.right = new TreeNode(3);

            tree.left.left = new TreeNode(4);
            tree.left.right = new TreeNode(5);

            tree.right.left = new TreeNode(6);

            CollectionAssert.AreEqual(new int[] { 4, 2, 5, 1, 6, 3 }, traversal.Compute(tree));
        }
    }
}
