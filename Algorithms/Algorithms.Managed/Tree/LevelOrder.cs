using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Tree
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    /// <summary>
    /// Given a binary tree, return the level order traversal of its nodes' values. (ie, from left to right, level by level).
    /// 
    /// For example: given binary tree[3, 9, 20, null, null, 15, 7],
    ///    3
    ///   / \
    ///  9  20
    ///    /  \
    ///   15   7
    ///
    /// return its level order traversal as:
    /// [
    ///   [3],
    ///   [9,20],
    ///   [15,7]
    /// ]
    /// </summary>
    public class LevelOrder
    {
        public IList<IList<int>> Compute(TreeNode root)
        {
            var result = new List<IList<int>>();
            Stack<Tuple<TreeNode, int>> stack = new Stack<Tuple<TreeNode, int>>();

            stack.Push(new Tuple<TreeNode, int>(root, 0));
            while (stack.Any())
            {
                var tuple = stack.Pop();
                var node = tuple.Item1;
                var level = tuple.Item2;

                if (node != null)
                {
                    if (result.Count == level)
                    {
                        result.Add(new List<int>());
                    }

                    result[level].Add(node.val);

                    stack.Push(new Tuple<TreeNode, int>(node.right, level + 1));
                    stack.Push(new Tuple<TreeNode, int>(node.left, level + 1));
                }
            }

            return result;
        }
    }
}
