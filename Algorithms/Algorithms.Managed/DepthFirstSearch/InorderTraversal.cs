using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.DFS
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    /// <summary>
    /// Given a binary tree, return the inorder traversal of its nodes' values.
    /// Example:
    ///     Input: [1,null,2,3]
    ///         1
    ///          \
    ///           2
    ///          /
    ///         3
    ///     
    ///     Output: [1,3,2]
    /// </summary>
    public class InorderTraversal
    {
        public List<int> Compute(TreeNode root)
        {
            var res = new List<int>();
            var stack = new Stack<TreeNode>();
            TreeNode curr = root;

            // Loop while node is not null OR stack is not empty
            while (curr != null || stack.Count > 0)
            {
                while (curr != null)
                {
                    // Add node to stack and advance to left node
                    stack.Push(curr);
                    curr = curr.left;
                }

                // Take the stack value
                curr = stack.Pop();
                res.Add(curr.val);

                // Advance to right node
                curr = curr.right;
            }

            return res;
        }
    }
}
