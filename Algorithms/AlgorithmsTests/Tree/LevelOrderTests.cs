using Algorithms.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmsTests.Tree
{
    [TestClass]
    public class LevelOrderTests
    {
        [TestMethod]
        public void TestLevelOrder()
        {
            var levelOrder = new LevelOrder();

            TreeNode tree = new TreeNode(3);
            tree.left = new TreeNode(9);
            tree.right = new TreeNode(20);

            tree.right.left = new TreeNode(15);
            tree.right.right = new TreeNode(7);

            var result = levelOrder.Compute(tree);
            var expected = new List<IList<int>>
            {
                new List<int> { 3 },
                new List<int> { 9, 20 },
                new List<int> { 15, 7 }
            };

            for (int i = 0; i < expected.Count; i++)
            {
                CollectionAssert.AreEqual(expected[i].ToArray(), result[i].ToArray());
            }
        }
    }
}
