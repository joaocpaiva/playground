using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Tree
{
    public class BinaryTreeFromTraversal
    {
        /// <summary>
        /// Given inorder and postorder traversal of a tree, construct the binary tree.
        /// Note: you may assume that duplicates do not exist in the tree.
        /// 
        /// For example, given
        ///     inorder = [9, 3, 15, 20, 7]
        ///     postorder = [9, 15, 7, 20, 3]
        /// Return the following binary tree:
        ///     3
        ///    / \
        ///   9  20
        ///     /  \
        ///    15   7
        /// </summary>
        public TreeNode BuildTreeFromInorderAndPostorder(int[] inorder, int[] postorder)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            int postIndex = inorder.Length - 1;

            for (int i = 0; i < inorder.Length; i++)
            {
                dict.Add(inorder[i], i);
            }

            return BuildTreeFromInorderAndPostorder(postorder, inorder, 0, inorder.Length - 1, dict, ref postIndex);
        }

        private TreeNode BuildTreeFromInorderAndPostorder(int[] postorder, int[] inorder, int start, int end, Dictionary<int, int> dict, ref int postIndex)
        {
            if (start > end || postIndex < 0)
            {
                return null;
            }

            TreeNode node = new TreeNode(postorder[postIndex--]);
            if (start == end)
            {
                return node;
            }

            int index = dict[node.val];

            node.right = BuildTreeFromInorderAndPostorder(postorder, inorder, index + 1, end, dict, ref postIndex);
            node.left = BuildTreeFromInorderAndPostorder(postorder, inorder, start, index - 1, dict, ref postIndex);

            return node;
        }

        /// <summary>
        /// Given inorder and postorder traversal of a tree, construct the binary tree.
        /// Note: you may assume that duplicates do not exist in the tree.
        /// 
        /// For example, given
        ///     preorder = [3,9,20,15,7]
        ///     inorder = [9, 3, 15, 20, 7]
        /// Return the following binary tree:
        ///     3
        ///    / \
        ///   9  20
        ///     /  \
        ///    15   7
        /// </summary>
        public TreeNode BuildTreeFromPreorderAndInorder(int[] preorder, int[] inorder)
        {
            Dictionary<int, int> inorderMap = new Dictionary<int, int>();
            int preorderIdx = 0;

            for (int i = 0; i < inorder.Length; i++)
            {
                inorderMap.Add(inorder[i], i);
            }

            return BuildTreeFromPreorderAndInorder(preorder, inorder, 0, inorder.Length - 1, inorderMap, ref preorderIdx);
        }

        private TreeNode BuildTreeFromPreorderAndInorder(int[] preorder, int[] inorder, int start, int end, Dictionary<int, int> inorderMap, ref int preorderIdx)
        {
            if (start > end || preorderIdx == preorder.Length)
            {
                return null;
            }

            TreeNode node = new TreeNode(preorder[preorderIdx ++]);
            if (start == end)
            {
                return node;
            }

            int index = inorderMap[node.val];

            node.left = BuildTreeFromPreorderAndInorder(preorder, inorder, start, index - 1, inorderMap, ref preorderIdx);
            node.right = BuildTreeFromPreorderAndInorder(preorder, inorder, index + 1, end, inorderMap, ref preorderIdx);

            return node;
        }
    }
}
