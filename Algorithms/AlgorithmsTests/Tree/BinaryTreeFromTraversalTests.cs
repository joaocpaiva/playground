using System;
using Algorithms.Tree;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmsTests.Tree
{
    [TestClass]
    public class BinaryTreeFromTraversalTests
    {
        [TestMethod]
        public void TestCreateTreeFromInorderPostorder()
        {
            var order = new BinaryTreeFromTraversal();
            var root = order.BuildTreeFromInorderAndPostorder(new int[] { 9, 3, 15, 20, 7 }, new int[] { 9, 15, 7, 20, 3 });

            Assert.AreEqual(3, root.val);

            Assert.AreEqual(9, root.left.val);
            Assert.IsNull(root.left.left);
            Assert.IsNull(root.left.right);

            Assert.AreEqual(20, root.right.val);

            Assert.AreEqual(15, root.right.left.val);
            Assert.IsNull(root.right.left.left);
            Assert.IsNull(root.right.left.right);

            Assert.AreEqual(7, root.right.right.val);
            Assert.IsNull(root.right.right.left);
            Assert.IsNull(root.right.right.right);
        }

        [TestMethod]
        public void TestCreateTreeFromPreorderInorder()
        {
            var order = new BinaryTreeFromTraversal();
            var root = order.BuildTreeFromPreorderAndInorder(new int[] { 3, 9, 20, 15, 7 }, new int[] { 9, 3, 15, 20, 7 });

            Assert.AreEqual(3, root.val);

            Assert.AreEqual(9, root.left.val);
            Assert.IsNull(root.left.left);
            Assert.IsNull(root.left.right);

            Assert.AreEqual(20, root.right.val);

            Assert.AreEqual(15, root.right.left.val);
            Assert.IsNull(root.right.left.left);
            Assert.IsNull(root.right.left.right);

            Assert.AreEqual(7, root.right.right.val);
            Assert.IsNull(root.right.right.left);
            Assert.IsNull(root.right.right.right);
        }
    }
}
